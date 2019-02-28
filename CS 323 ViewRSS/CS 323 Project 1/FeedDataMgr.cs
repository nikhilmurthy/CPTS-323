using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.Drawing;
using System.ComponentModel;

namespace CS_323_Project_1
{
    // row format capturing the key fields returned by Feed

    public class FeedData  
    {
        public FeedInfo info {get;set;}
        public int updateRefTime { get; set; }
        public int nextRefTime {get;set;}
        public List<FeedRow> feedItems;

    };

    // Manages the list of feeds and associated data
    // Handles Feed Refresh and notifying UserInterface for any screen updates

    class FeedDataMgr
    {
        const int defaultUpdateRefTime = 30; // time in ticks
        const int defaultNumLines = 20;
        List<FeedData> feedList = new List<FeedData>();
        int timerTick = 0; // timerTick initial value
        int giNumLines;
        int giUpdatePeriod;

        public delegate void FeedDataChangedHandler(object source, PropertyChangedEventArgs e);
        public event FeedDataChangedHandler DataChanged;

        public FeedDataMgr()
        {
        }

        // Gets the feed rows for each feed and updates the feedList

        public void load(List<FeedInfo> fil, GlobalInfo gi)
        {
            feedList.Clear(); // Clear existing list

            giNumLines = Convert.ToInt32(gi.nbrLines);

            if (gi.nbrLines == "0") // Default
            {
                giNumLines = defaultNumLines;
            }

            giUpdatePeriod = Convert.ToInt32(gi.updatePeriod);

            if (gi.updatePeriod == "0") // Default
            {
                giUpdatePeriod = defaultUpdateRefTime;
            }

            foreach (FeedInfo info in fil)
            {
                FeedData data = new FeedData();
                data.info = info;
                data.feedItems = FeedParser.parse(info.link, giNumLines);
                data.updateRefTime = Convert.ToInt32(info.refMins);
                if (data.updateRefTime <= 0)
                    data.updateRefTime = defaultUpdateRefTime;
                data.nextRefTime = data.updateRefTime + timerTick;
                feedList.Add(data);
            };

        }

        // Returns the feed rows for a specific feed

        public List<FeedRow> getFeedItems(String feedName)
        {
            List<FeedRow> fdItems = null; // new List<FeedRow>();
            foreach (FeedData data in feedList)
            {
                if (data.info.name == feedName)
                {
                    fdItems = data.feedItems;
                    break;
                }
            };
            return fdItems;
        }

        // Returns the feed rows for a specific feed that were published within the last deltaMins

        public List<FeedRow> getFeedItems(String feedName, int deltaMins)
        {
            List<FeedRow> fdItems = new List<FeedRow>();
            DateTime cutOffTime = DateTime.Now.AddMinutes(-deltaMins) ;
            foreach (FeedData data in feedList)
            {
                if (data.info.name == feedName)
                {
                    foreach (FeedRow fr in data.feedItems)
                    {
                        if (fr.pubDate > cutOffTime)
                        {
                            fdItems.Add(fr);
                        }
                    }
                    break;
                }
            };
            return fdItems;
        }

        // Returns the feed rows for a specific feed that were published within the date range

        public List<FeedRow> getFeedItems(String feedName, DateTime dtFrom, DateTime dtTo)
        {
            List<FeedRow> fdItems = new List<FeedRow>();
           
            foreach (FeedData data in feedList)
            {
                if (data.info.name == feedName)
                {
                    foreach (FeedRow fr in data.feedItems)
                    {
                        if ((fr.pubDate >= dtFrom) && (fr.pubDate <= dtTo))
                        {
                            fdItems.Add(fr);
                        }
                    }
                    break;
                }
            };
            return fdItems;
        }

        /*
        public bool setFeedInfo(FeedInfo info)
        {
            string name = info.name;
            List<FeedRow> lfr;
            int i = 0;
            foreach (FeedData fd in feedList)
                if (fd.info.name == name)
                {
                    if (fd.info.link != info.link) // link changed
                    {
//                        FeedParser rs = new FeedParser();
//                        feedList[i].feedItems = rs.parse(info.link, giNumLines);
                        feedList[i].feedItems = FeedParser.parse(info.link, giNumLines);
 
      
                    };
                    feedList[i].info = info;
                    feedList[i].nextRefTime = Convert.ToInt32(info.refMins);
                    return true;
                }
                else i++;
            return false;
        } */

        // Sets readFlag to yes for a specific FeedRow of a feed

        public bool setReadFlg(string feedName, int rowIndex)
        {
            foreach (FeedData data in feedList)
            {
                if (data.info.name == feedName)
                {
                    data.feedItems[rowIndex].readFlag = "Yes";
                    return true;
                }
            }

            return false;
        }

        // Toggles readFlag to opposite value for a specific FeedRow of a feed

        public bool switchReadFlg(string feedName, int rowIndex)
        {
            foreach (FeedData data in feedList)
            {
                if (data.info.name == feedName)
                {
                    if (data.feedItems[rowIndex].readFlag == "Yes")
                        data.feedItems[rowIndex].readFlag = "No";
                    else
                        data.feedItems[rowIndex].readFlag = "Yes";
                    return true;
                }
            }

            return false;
        }

        // Gets feed rows for feeds that are ready to be refreshed based on nextRefTime
        // Merges feed rows with the current entries
        // Triggers the feedDataChangedEvent (notifies subscribers)

        public void timerTickEvent(int interval)
        {
            List<FeedRow> fr;
            int i = 0;
            timerTick++;
            foreach (FeedData data in feedList)
            {
                if (data.nextRefTime <= timerTick)
                {
                    int newRows = 0;
                    fr = FeedParser.parse(data.info.link, giNumLines);

                    if (fr != null)
                    {
                        newRows = mergeFeed (feedList[i].feedItems, fr);
                        feedList[i].nextRefTime += feedList[i].updateRefTime;
                        // notify if the refresh has changed existing data
                        if (newRows > 0)
                        {  
 //                         MessageBox.Show("Feed Refreshed (changed) **" + data.info.name);
                            FeedDataChangedHandler handler = DataChanged;
                            if (handler != null)
                            {
                                handler(this, new PropertyChangedEventArgs(data.info.name));
                            }
                        }
                    };
                };

                i++;
            };
         }

        // Merges fr2 with fr1 based on matching title and pubDate

        private int mergeFeed(List<FeedRow> fr1, List<FeedRow> fr2)
        {
            int i = 0;
            FeedRow fx = fr1.First();


            foreach (FeedRow fr in fr2)
            {
                if ((fr.title == fx.title) && (fr.pubDate == fx.pubDate))
                    break;
                else
                {
                    fr1.Insert(i, fr);
                    i++;
                };
            };

            if (fr1.Count > giNumLines) // Remove excess entries
            {
                fr1.RemoveRange(giNumLines, (fr1.Count - giNumLines));
            }

            return i;
        }
    }
}
