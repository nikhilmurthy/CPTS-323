using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CS_323_Project_1
{
    // interface data structures between UserInterface, ConfigMgr and FeedDataMgr

    public enum NodeType
    {
        Root,
        Channel,
        Feed,
        Unknown
    }

    public struct GlobalInfo
    {
        public string name;
        public string nbrLines;
        public string updatePeriod;

    }
    public struct ChannelInfo
    {
        public string name;
        public string comment;
    }
    public struct FeedInfo
    {
        public string name;
        public string link;
        public string refMins;
        public string enable;
    }
 
    public class FeedRow
    {
        public string title { get; set; }
        public string link { get; set; }
  //      public string pubDate { get; set; }
        public DateTime pubDate { get; set; }
        public string description { get; set; }
        public string readFlag { get; set; }

        public FeedRow()
        {
            title = "";
            link = "";
     //       pubDate = "";
            pubDate = DateTime.Now;
            description = "";
            readFlag = "";
        }
    }
 
    class Global
    {
    }
}
