using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.Drawing;

namespace CS_323_Project_1
{
    // Static Class FeedParser
    //      Parses RSS feeds (RSS 2.0 and Atom 1.0) 
    //      Returns a list of FeedRow entries up to maxRows
    //      Returns null on any error conditions

    public static class FeedParser
    {

        public static List<FeedRow> parse(string feedurl, int maxRows)
        {
            XmlNode xnode;
            XmlDocument feedXml = new XmlDocument(); // Feed data stored as DOM

            try
            {
                feedXml.Load(feedurl);
            }
            
            // Multiple exceptions can happen
            catch
            {
                return null;
            }

            xnode = feedXml.DocumentElement; 

            // Check for the RSS format type and call the appropriate function

            if ((xnode.Name == "rss") && (xnode.Attributes["version"].Value == "2.0"))
            {
                return parseRSS(xnode, maxRows);
            }
            else if ((xnode.Name == "feed") && (xnode.Attributes["xmlns"].Value == "http://www.w3.org/2005/Atom"))  // atom format
            {
                return parseAtom(xnode, maxRows);
            }
            else
                return null;    
        }

        // Parses RSS 2.0 Format
        // Fields picked are title, link, description, and pubDate
        // All except pubDate will be parsed and stored as strings
        // pubDate will be parsed and stored as DateTime format

        private static List<FeedRow> parseRSS(XmlNode root, int MaxRows)
        {
            XmlNode xnode = root;
            List<FeedRow> feedRowList = new List<FeedRow>();
            int count = 0;

            xnode = xnode.ChildNodes[0];
            
            foreach (XmlNode node in xnode.ChildNodes)
            {
                if (count >= MaxRows)
                    break;
                if (node.Name == "item")
                {
                    FeedRow f = new FeedRow();
                    foreach (XmlNode inode in node.ChildNodes)
                    {
                        if ((inode.Name == "title") && (inode.ChildNodes[0] != null))
                            f.title = inode.ChildNodes[0].Value;
                        else if ((inode.Name == "link") && (inode.ChildNodes[0] != null))
                            f.link = inode.ChildNodes[0].Value;
                        else if ((inode.Name == "description") && (inode.ChildNodes[0] != null))
                            f.description = inode.ChildNodes[0].Value;
                        else if ((inode.Name == "pubDate") && (inode.ChildNodes[0] != null))
                            f.pubDate = convertToDateTime(inode.ChildNodes[0].Value);
                    };

                    f.readFlag = "no";
                    feedRowList.Add(f);
                    count++;
                }
            }

            return feedRowList;
        }

        // Parses Atom 1.0 format
        // Similar to RSS

        private static List<FeedRow> parseAtom(XmlNode root, int MaxRows)
        {
            XmlNode xnode = root;
            List<FeedRow> feedRowList = new List<FeedRow>();
            int count = 0;

            foreach (XmlNode node in xnode.ChildNodes)
            {
                if (count >= MaxRows)
                    break;
                if (node.Name == "entry")
                {
                    FeedRow f = new FeedRow();
                    foreach (XmlNode inode in node.ChildNodes)
                    {
                        if (inode.Name == "title")
                            f.title = inode.ChildNodes[0].Value;
                        else if (inode.Name == "link")
                             f.link = inode.Attributes["href"].Value;
                        else if (inode.Name == "content")
                            f.description = inode.ChildNodes[0].Value;
                        else if (inode.Name == "updated")
                            f.pubDate = convertToDateTime (inode.ChildNodes[0].Value);
                    };
                    
                    f.readFlag = "no";
                    feedRowList.Add(f);
                    count++;
                }
            }

            return feedRowList;
        }

        // Converts pubDate to DateTime format
        // The standard formats are handled by convertToDateTime
        // Exceptions (Time Zones) are handled by checking and replacing them with GMT offset
        // Can only handle popular U.S. time zones

        static DateTime convertToDateTime(string strDate)
        {
            DateTime cDate;

            try
            {
                cDate = Convert.ToDateTime(strDate);
                return cDate;
            }
            catch (FormatException fex)
            {
                // find the time zone (if any)
                int TZbegin = strDate.LastIndexOf(" ");

                if (TZbegin != -1)
                {
                    string TZstr = strDate.Substring(TZbegin + 1);
                    string TZvalue;

                    // add other time zone - turn it into a seperate function

                    if (TZstr == "EDT")
                        TZvalue = "-0400";
                    else if (TZstr == "EST")
                        TZvalue = "-0500";
                    else if (TZstr == "CDT")
                        TZvalue = "-0500";
                    else if (TZstr == "CST")
                        TZvalue = "-0600";
                    else if (TZstr == "PDT")
                        TZvalue = "-0700";
                    else if (TZstr == "PST")
                        TZvalue = "-0800";
                    else
                        TZvalue = null;

                    // known time zone
                    if (TZvalue != null)
                    {
                        // replace timezone name with actual hours (GMT based)
                        string NewDateStr = strDate.Replace(TZstr, TZvalue);

                        try
                        {
                            cDate = Convert.ToDateTime(NewDateStr);

                            // success this time
                            return cDate;
                        }

                        catch (FormatException innerfex)
                        {
                            return DateTime.MinValue; // Conversion did not happen
                        }
                    }
                }
                
                 return DateTime.MinValue; // Conversion did not happen
            }
        }
    }
}
   
