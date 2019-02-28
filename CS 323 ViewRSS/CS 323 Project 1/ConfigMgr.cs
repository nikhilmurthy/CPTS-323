using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.Drawing;
 
 

namespace CS_323_Project_1
{


    public class ConfigMgr
    {
        XmlDocument ConfigXML = new XmlDocument(); // Config file stored as DOM (Document Object Model)
        TreeNode ConfigTN; // Root of tree node graph that matches XML graph of userConfig
        bool fileLoaded = false;
        bool fileChanged = false;
        string fileName;


        public ConfigMgr()
        {

        }

        // Checks if a node name is valid in the XML tree
        public bool validNodeName(string name)
        {
            XmlNode root = ConfigXML;
            XmlNode xnode;
            xnode = SearchNode(name, root);
            if (xnode != null)
                return true;
            else
                return false;
        }

        // returns the type of TreeNode 

        public NodeType getNodeType(TreeNode tnode)
        {
            XmlNode xnode = (XmlNode)tnode.Tag;

            if (xnode.Attributes["id"].Value == "root")
                return NodeType.Root;
            else if (xnode.Attributes["id"].Value == "channel")
                return NodeType.Channel;
            else if (xnode.Attributes["id"].Value == "feed")
                return NodeType.Feed;
            else
                return NodeType.Unknown;

        }

        // returns global attributes

        public GlobalInfo getGlobalInfo(TreeNode tnode)
        {
            XmlNode xnode = (XmlNode)tnode.Tag;

            GlobalInfo info = new GlobalInfo();
            info.name = xnode.Name;
            info.nbrLines = xnode.Attributes["nbrLines"].Value;
            info.updatePeriod = xnode.Attributes["updatePeriod"].Value;
            return info;

        }

        // returns channel attributes

        public ChannelInfo getChannelInfo(TreeNode tnode)
        {
            XmlNode xnode = (XmlNode)tnode.Tag;
            ChannelInfo info = new ChannelInfo();
            info.name = xnode.Name;
            info.comment = xnode.Attributes["comment"].Value;
            return info;

        }

        // returns feed attributes

        public FeedInfo getFeedInfo(TreeNode tnode)
        {
            XmlNode xnode = (XmlNode)tnode.Tag;
            FeedInfo info = new FeedInfo();
            info.name = xnode.Name;
            info.link = xnode.Attributes["link"].Value;
            info.refMins = xnode.Attributes["refMins"].Value;
            info.enable = xnode.Attributes["enable"].Value;
            return info;

        }

        // Updates global info of the XML node (root) with new user settings

        public TreeNode setGlobalInfo(TreeNode inTnode, GlobalInfo info)
        {
            TreeNode tnode = inTnode;
            XmlNode xnode = (XmlNode)tnode.Tag;

            XmlElement id = ConfigXML.CreateElement("id");

            // Node name cannot be changed

            /*
            if (xnode.Name != info.name)
            {
                XmlNode pnode = xnode.ParentNode;
                XmlElement newXNode = ConfigXML.CreateElement(info.name);

               // MessageBox.Show("name has changed");
                newXNode.InnerXml = xnode.InnerXml;
                foreach (XmlAttribute attr in xnode.Attributes)
                {
                    newXNode.SetAttribute(attr.Name, attr.Value);
                }

                pnode.RemoveChild(xnode);
                pnode.AppendChild(newXNode);

                xnode = newXNode;
                tnode.Name = newXNode.Name;
                tnode.Text = newXNode.Name;
                tnode.Tag = newXNode;
            }; */

            if (xnode.Attributes["nbrLines"].Value != info.nbrLines)
            {
                // MessageBox.Show("NbrLines has changed");
                xnode.Attributes["nbrLines"].Value = info.nbrLines;
            }

            if (xnode.Attributes["updatePeriod"].Value != info.updatePeriod)
            {
                // MessageBox.Show("updatePeriod has changed");
                xnode.Attributes["updatePeriod"].Value = info.updatePeriod;
            }

            fileChanged = true;

            return tnode;
        }

        // Updates channel info of the XML node with new user settings
        // If node name is changed, subtree must be recreated

        public TreeNode setChannelInfo(TreeNode inTnode, ChannelInfo info)
        {
            TreeNode tnode = inTnode;
            XmlNode xnode = (XmlNode)tnode.Tag;

            XmlElement id = ConfigXML.CreateElement("id");

            // If node name is changed, 
            // a new tree node is created for copying the subTree of the original tree node

            if (xnode.Name != info.name) // node name changed
            {
                XmlNode pnode = xnode.ParentNode;
                XmlElement newXNode = ConfigXML.CreateElement(info.name);

      //        MessageBox.Show("name has changed");
                newXNode.InnerXml = xnode.InnerXml;
                foreach (XmlAttribute attr in xnode.Attributes)
                {
                    newXNode.SetAttribute(attr.Name, attr.Value);
                }

                pnode.RemoveChild(xnode);
                pnode.AppendChild(newXNode);

                xnode = newXNode;
                tnode.Name = newXNode.Name;
                tnode.Text = newXNode.Name;
                tnode.Tag = newXNode;
            };
            if (xnode.Attributes["comment"].Value != info.comment)
            {
       //       MessageBox.Show("comments have changed");
                xnode.Attributes["comment"].Value = info.comment;
            }

            fileChanged = true;
            return tnode;
        }

        // Returns FeedInfo list for all the feeds
        public List<FeedInfo> getFeedInfo()
        {
            List<FeedInfo> lfi = new List<FeedInfo>();
            recFeedInfo(ConfigXML.DocumentElement, lfi);
            return lfi;
        }

        // Updates feed info of the XML node with new user settings
        // If node name is changed, subtree must be removed and recreated

        public TreeNode setFeedInfo(TreeNode inTnode, FeedInfo info)
        {
            TreeNode tnode = inTnode;
            XmlNode xnode = (XmlNode)tnode.Tag;

            XmlElement id = ConfigXML.CreateElement("id");

            // If node name is changed, 
            // a new tree node is created for copying the subTree of the original tree node

            if (xnode.Name != info.name) // node name changed
            {
                XmlNode pnode = xnode.ParentNode;
                XmlElement newXNode = ConfigXML.CreateElement(info.name);

       //       MessageBox.Show("name has changed");
                newXNode.InnerXml = xnode.InnerXml;
                foreach (XmlAttribute attr in xnode.Attributes)
                {
                    newXNode.SetAttribute(attr.Name, attr.Value);
                }

                pnode.RemoveChild(xnode);
                pnode.AppendChild(newXNode);

                xnode = newXNode;
                tnode.Name = newXNode.Name;
                tnode.Text = newXNode.Name;
                tnode.Tag = xnode;
            };
            if (xnode.Attributes["link"].Value != info.link)
            {
       //       MessageBox.Show("link has changed");
                xnode.Attributes["link"].Value = info.link;
            };
            if (xnode.Attributes["refMins"].Value != info.refMins)
            {
       //       MessageBox.Show("refMins has changed");
                xnode.Attributes["refMins"].Value = info.refMins;
            }
            if (xnode.Attributes["enable"].Value != info.enable)
            {
       //       MessageBox.Show("enable has changed");
                xnode.Attributes["enable"].Value = info.enable;
            }

            fileChanged = true;
            return tnode;

        }

        // Selected node and its children gets deleted both from XML graph and Tree Node graph
        // Returns deleted node's parent

        public TreeNode deleteNode(TreeNode inTnode)
        {
            TreeNode tnode = inTnode;
            if ((inTnode != null) && (inTnode.Parent != null))
            {
                XmlNode xnode = (XmlNode)tnode.Tag;

                // Removes the xml node

                XmlNode pnode = xnode.ParentNode;
                pnode.RemoveChild(xnode);

                // Removes the tree node

                tnode = inTnode.Parent;
                inTnode.Remove();

                fileChanged = true;
            }

            return tnode;
        }

        // Adds a child feed node if the selected node is a channel or root otherwise,
        // if selected node is a feed, then feed is inserted above the current node
        // Automatically generates a unique feed name that user can modify later
        // Provides default settings

        public TreeNode insertChildFeed(TreeNode inTnode)
        {
            TreeNode tnode = inTnode;
            if (inTnode != null)
            {
                String name;
                name = genValidName("Feed");
                XmlNode xnode = (XmlNode)tnode.Tag;
                XmlElement newXNode = ConfigXML.CreateElement(name);
                newXNode.SetAttribute("id", "feed");
                newXNode.SetAttribute("link", "");
                newXNode.SetAttribute("refMins", "10");
                newXNode.SetAttribute("enable", "No");

                TreeNode newTNode = new TreeNode(newXNode.Name);
                newTNode.Name = newXNode.Name;
                newTNode.Tag = newXNode;

                newTNode.ForeColor = Color.Red;

                if (xnode.Attributes["id"].Value == "feed")
                {
                    XmlNode pXNode = xnode.ParentNode;
                    pXNode.InsertAfter(newXNode, xnode);

                    TreeNode pTNode = tnode.Parent;
                    pTNode.Nodes.Insert(pTNode.Nodes.IndexOf(tnode) + 1, newTNode);
                }

                else
                {
                    xnode.InsertBefore(newXNode, xnode.FirstChild);

                    tnode.Nodes.Insert(0, newTNode);
                };

                tnode = newTNode;

                fileChanged = true;
            }

            return tnode;
        }

        // Adds a child channel node if the selected node is a channel or root otherwise,
        // Automatically generates a unique channel name that user can modify later
        // Provides default settings

        public TreeNode insertChildChannel(TreeNode inTnode)
        {
            TreeNode tnode = inTnode;
            if (inTnode != null)
            {

                XmlNode xnode = (XmlNode)tnode.Tag;
                if ((xnode.Attributes["id"].Value == "root") || (xnode.Attributes["id"].Value == "channel"))
                {
                    String name;
                    name = genValidName("Channel");
                    XmlElement newXNode = ConfigXML.CreateElement(name);
                    newXNode.SetAttribute("id", "channel");
                    newXNode.SetAttribute("comment", "");


                    TreeNode newTNode = new TreeNode(newXNode.Name);
                    newTNode.Name = newXNode.Name;
                    newTNode.Tag = newXNode;

                    xnode.InsertBefore(newXNode, xnode.FirstChild);
                    tnode.Nodes.Insert(0, newTNode);


                    tnode = newTNode;
                    fileChanged = true;
                };
            }

            return tnode;
        }

        // Adds a channel node after the selected channel node as a peer channel
        // Automatically generates a unique channel name that user can modify later
        // Provides default settings

        public TreeNode insertNextChannel(TreeNode inTnode)
        {
            TreeNode tnode = inTnode;


            if (tnode != null)
            {
                String name;
                name = genValidName("Channel");

                XmlNode xnode = (XmlNode)tnode.Tag;
                XmlElement newXNode = ConfigXML.CreateElement(name);
                newXNode.SetAttribute("id", "channel");
                newXNode.SetAttribute("comment", "");

                TreeNode newTNode = new TreeNode(newXNode.Name);
                newTNode.Name = newXNode.Name;
                newTNode.Tag = newXNode;

                if (xnode.Attributes["id"].Value == "channel")
                {
                    XmlNode pXNode = xnode.ParentNode;
                    pXNode.InsertAfter(newXNode, xnode);

                    TreeNode pTNode = tnode.Parent;
                    pTNode.Nodes.Insert(pTNode.Nodes.IndexOf(tnode) + 1, newTNode);

                    tnode = newTNode;

                    fileChanged = true;
                }
            }

            return tnode;
        }

        // Creates and loads a new config file with a root template

        public TreeNode create(string xmlFileName)
        {

            string xmlString = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> <My_Collection id=\"root\" nbrLines=\"14\" updatePeriod=\"15\"> </My_Collection>";
            ConfigXML.LoadXml(xmlString);
            ConfigXML.Save(xmlFileName);
            fileName = xmlFileName;

            return (load(xmlFileName));

        }

        // Saves any modification made to config file

        public bool save()
        {
            if (fileChanged)
            {
                fileChanged = false;
                ConfigXML.Save(fileName);
        //      MessageBox.Show("file changes saved");
                return true;
            }

            else
                return false;
        }

        // loads a config file & sets the XML & Tree graph data structures
        // Returns root of TreeNode graph
        // TreeNode graph structure matches the XML Node graph with the name and text set to the XML Node name
        // and the tag field is set to the corresponding XML object for faster access (avoids walking through tree)

        public TreeNode load(string xmlFileName)
        {
            TreeNode tnode = new TreeNode();
            XmlNode xnode;

            // Load XML data from file to XML document

            try
            {
                ConfigXML.Load(xmlFileName);
            }

            catch (XmlException exception)
            {
                MessageBox.Show("Invalid xml file");
                return null;
            }

            xnode = ConfigXML.DocumentElement; // Set xnode to root element

            if (xnode.Name != "My_Collection")
            {
                MessageBox.Show("Invalid xml file");
                return null;
            }

            // Set tnode to root xnode

            tnode.Name = xnode.Name;
            tnode.Text = xnode.Name;
            tnode.Tag = xnode;

            // Recursively build tree node graph from xnode graph

            recAddTNode(xnode, tnode);

            // set class globals

            fileName = xmlFileName;
            ConfigTN = tnode; // Root for tree node graph
            fileLoaded = true;
            fileChanged = false;

            return tnode;
        }
        
        // Recursively adds Tree Nodes that matches the XML Nodes
        // Sets tag field of the tree node to the corresponding XML Node to speed up search

        private void recAddTNode(XmlNode xmln, TreeNode xtNode)
        {
            foreach (XmlNode xnode in xmln.ChildNodes)
            {
                // Create a tree node and add it as a child to the xtNode

                TreeNode ltNode = new TreeNode();
                ltNode.Text = xnode.Name;
                ltNode.Name = xnode.Name;
                ltNode.Tag = xnode;

                // Set the color attribute of tree node to red for feed nodes

                if (xnode.Attributes["id"].Value == "feed")
                {
                    ltNode.ForeColor = Color.Red;
                }

                xtNode.Nodes.Add(ltNode);
                recAddTNode(xnode, ltNode);
            }
        }

        // Recursively goes through the xml tree to generate the feed info list
        private void recFeedInfo(XmlNode xmln, List<FeedInfo> lfi)
        {
            foreach (XmlNode xnode in xmln.ChildNodes)
            {
                if (xnode.Attributes["id"].Value == "feed")
                {
                    FeedInfo info = new FeedInfo();
                    info.name = xnode.Name;
                    info.link = xnode.Attributes["link"].Value;
                    info.refMins = xnode.Attributes["refMins"].Value;
                    info.enable = xnode.Attributes["enable"].Value;

                    lfi.Add(info);
                }

                recFeedInfo(xnode, lfi);
            }
        }


        private XmlNode SearchNode(string name, XmlNode pnode)
        {
              XmlNode tnode;
              if (pnode.Name == name)
                  return pnode;
              foreach (XmlNode xnode in pnode.ChildNodes)
              {
                  tnode = SearchNode(name, xnode);
                  if (tnode != null)
                      return tnode;

              }

              return null;
        }

        // Generates a unique node name to for the XML/TreeNode graphs

        private string genValidName(string prefix)
        {
            XmlNode root = ConfigXML;
            string name = "";
            bool loop = true;

            while (loop)
            {
                Random rnd = new Random();
                int i = rnd.Next(9999);

                name = prefix + "-" + Convert.ToString(i);
                loop = validNodeName(name);
            }

            return name;

        } 
    }
}
