using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
 
 
using System.Xml;

namespace CS_323_Project_1
{
    public partial class UserInterface : Form
    {
        
        public UserInterface()
        {
            InitializeComponent();

            // Display only the file option at the beginning and
            // assign the function to be triggered on FeedDataChangedEvent

            this.editToolStripMenuItem.Visible = false;
            this.timeFilterToolStripMenuItem.Visible = false;
            userFG.DataChanged += new FeedDataMgr.FeedDataChangedHandler (this.onFeedDataChange);
        }

        const int MAXLINES = 100;
        const int MAXUPDATEPD = 1440; // One day in minutes

        // data associated with Demo use case

        int cr = 0; // current row to display

        // Config related data

        TreeNode root;
        bool editMode = false;

        // time filtering variables

        bool timeFilter = false;
        bool dateFilter = false;
        int timeDelta = 0;
        ToolStripMenuItem  currentTsmi; 
        DateTime dateFrom, dateTo;

        // Two key objects to manage config data and feed data

        ConfigMgr userConfig = new ConfigMgr();
        FeedDataMgr userFG = new FeedDataMgr();

        // Feed/Grid related data

        TreeNode datagridTN; //tnode pointing to the current datagrid

        // Enable or Disable edit mode; enable & disable visibility of appropriate user screens
        // Save config file and reload the feed data if needed

        private void editModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editMode = !editMode;

            this.editModeToolStripMenuItem.Checked = editMode;
            this.editToolStripMenuItem.Visible = editMode;
            this.demoToolStripMenuItem.Visible = !editMode;
            this.timeFilterToolStripMenuItem.Visible = !editMode;

            GB_FeedInfo.Visible = false;
            GB_ChannelInfo.Visible = false;
            GB_GlobalInfo.Visible = false;
            GB_Demo.Visible = false;

            webBrowser1.Visible = !editMode;
            webBrowser1.DocumentText = "";

            dataGridView1.Visible = !editMode;
            dataGridView1.DataSource = "";

            // If editMode is turned off, save configuration changes 
            // and reload the feed data for the new configuration if needed

            if (!editMode)
            {
                if (userConfig.save())
                    userFG.load(userConfig.getFeedInfo(), userConfig.getGlobalInfo(root)); // Reload
            }

            treeView1_AfterSelect(sender, null);

        }

        // Display the appropriate user edit forms with the selected Node field entries

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode tnode = treeView1.SelectedNode;

            if (tnode != null)
            {
                if (userConfig.getNodeType(tnode) == NodeType.Feed)
                {
                    // Display feed info form with current data

                    FeedInfo fi;

                    fi = userConfig.getFeedInfo(tnode);

                    GB_FI_Name.Text = fi.name;
                    GB_FI_Link.Text = fi.link;
                    GB_FI_RT.Text = fi.refMins;
                    GB_FI_Enable.Text = fi.enable;
                    GB_CI_ErrorMsg.Text = "";

                    // Only show the FeedInfo form and not show the other forms

                    GB_FeedInfo.Visible = true;
                    GB_ChannelInfo.Visible = false;
                    GB_GlobalInfo.Visible = false;
                    webBrowser1.Visible = false;
                    splitContainer2.Panel1.Enabled = false;
                }

                else if (userConfig.getNodeType(tnode) == NodeType.Channel)
                {
                    // Display channel form with current data

                    ChannelInfo gi;

                    gi = userConfig.getChannelInfo(tnode);
                    GB_CI_Name.Text = gi.name;
                    GB_CI_Comments.Text = gi.comment;
                    GB_CI_ErrorMsg.Text = "";

                    GB_FeedInfo.Visible = false;
                    GB_ChannelInfo.Visible = true;
                    GB_GlobalInfo.Visible = false;
                    webBrowser1.Visible = false;
                    splitContainer2.Panel1.Enabled = false;
                }

                else if (userConfig.getNodeType(tnode) == NodeType.Root)
                {
                    // Display global options data
 
                    GlobalInfo ri;

                    ri = userConfig.getGlobalInfo(tnode);
                    GB_GI_Name.Text = ri.name;
                    GB_GI_nbrLines.Text = ri.nbrLines;
                    GB_GI_updatePeriod.Text = ri.updatePeriod;
                    GB_GI_ErrorMsg.Text = "";
                    GB_FeedInfo.Visible = false;
                    GB_ChannelInfo.Visible = false;
                    GB_GlobalInfo.Visible = true;
                    webBrowser1.Visible = false;
                    splitContainer2.Panel1.Enabled = false;
                }
            }
        }

        // Checks for valid string name (^[A-Za-z][a-zA-Z0-9-_]*)
        // Checks if name is not a duplicate of an existing node

        private bool validName(string name)
        {
            int i = 0;
            int j = name.Length;

            if (j == 0)
                return false;

            // Check if the first character is alphanumeric

            if (!(Char.IsLetter(name[i])))
                return false;
            i++;

            while (i < j)
            {
                if (!((Char.IsLetterOrDigit(name[i])) || (name[i] == '-') || (name[i] == '_')))
                    return false;
                i++;
            }

            // check also to see if the name is duplicate

            if (userConfig.validNodeName(name))
                return false; // name already exists

            else
                return true;
        }

        // Checks for valid number of lines
        // Valid number of lines is between 1 and MAXLINES

        private bool validNbrLines(string str)
        {
            int i;

            if (Int32.TryParse(str, out i))
            {
                if (i > 0 && i <= MAXLINES)
                    return true;
            }

            return false;
        }

        // Checks for valid update period
        // Valid update period is set between 1 and MAXUPDATEPD

        private bool validUpdatePeriod(string str)
        {
            int i;

            if (Int32.TryParse(str, out i))
            {
                if (i > 0 && i <= MAXUPDATEPD)
                    return true;
            }

            return false;
        }

        // Checks for valid link
        // Link starts with http://

        private bool validLink(string str)
        {
            // add edit code
            if (str == "")
                return false;
            else
                return true;
        }

        // User has selected OK after filling the global info form
        // Do edit validation and call setGlobalInfo to update the config file (XML and TreeNode structures)

        private void GI_OK_Click(object sender, EventArgs e)
        {
            TreeNode tnode = treeView1.SelectedNode;
  
            if (tnode != null)
            {
                GlobalInfo info;

                // add edit code here

                if ((GB_GI_Name.Modified) && (!validName(GB_GI_Name.Text)))
                {
                    GB_GI_ErrorMsg.Text = "Error: Invalid Name";
                    return;
                }

                if ((GB_GI_nbrLines.Modified) && (!validNbrLines(GB_GI_nbrLines.Text)))
                {
                    GB_GI_ErrorMsg.Text = "Error: Invalid # of lines";
                    return;
                }

                if ((GB_GI_updatePeriod.Modified) && (!validUpdatePeriod(GB_GI_updatePeriod.Text)))
                {
                    GB_GI_ErrorMsg.Text = "Error: Invalid update period";
                    return;
                }

                if ((GB_GI_Name.Modified) || (GB_GI_nbrLines.Modified) || (GB_GI_updatePeriod.Modified))
                {

                    info.nbrLines = GB_GI_nbrLines.Text;
                    info.name = GB_GI_Name.Text;
                    info.updatePeriod = GB_GI_updatePeriod.Text;
                    tnode = userConfig.setGlobalInfo(tnode, info);
                }
            }

            GB_GlobalInfo.Visible = false;
            splitContainer2.Panel1.Enabled = true;
        }

        // User presses cancel option for the global info form

        private void GI_Cancel_Click(object sender, EventArgs e)
        {
            GB_GlobalInfo.Visible = false;
            splitContainer2.Panel1.Enabled = true;
        }

        // User has selected OK after filling the channel info form
        // Do edit validation and call setChannelInfo to update the config file (XML and TreeNode structures)

        private void CI_OK_Click(object sender, EventArgs e)
        {
            TreeNode tnode = treeView1.SelectedNode;

            if (tnode != null)
            {
                ChannelInfo info;

                // add edit code here

                if ((GB_CI_Name.Modified) && (!validName(GB_CI_Name.Text)))
                {
                    GB_CI_ErrorMsg.Text = "Error: Invalid Name";
                    return;
                }

                if ((GB_CI_Name.Modified) || (GB_CI_Comments.Modified))
                {
                    info.comment = GB_CI_Comments.Text;
                    info.name = GB_CI_Name.Text;
                    tnode = userConfig.setChannelInfo(tnode, info);
                }
            }

            GB_ChannelInfo.Visible = false;
            splitContainer2.Panel1.Enabled = true;
        }

        // User presses cancel option for the channel info form

        private void CI_Cancel_Click(object sender, EventArgs e)
        {
            GB_ChannelInfo.Visible = false;
            splitContainer2.Panel1.Enabled = true;
        }

        // User has selected OK after filling the feed info form
        // Do edit validation and call setFeedInfo to update the config file (XML and TreeNode structures)

        private void FI_OK_Click(object sender, EventArgs e)
        {
            TreeNode tnode = treeView1.SelectedNode;

            if (tnode != null)
            {
                FeedInfo info;

                // add edit code here

                if ((GB_FI_Name.Modified) && (!validName(GB_FI_Name.Text)))
                {
                    GB_FI_ErrorMsg.Text = "Error: Invalid Name";
                    return;
                }

                if ((GB_FI_Link.Modified) && (!validLink(GB_FI_Link.Text)))
                {
                    GB_FI_ErrorMsg.Text = "Error: Invalid Link";
                    return;
                }

                if ((GB_FI_RT.Modified) && (!validUpdatePeriod(GB_FI_RT.Text)))
                {
                    GB_FI_ErrorMsg.Text = "Error: Invalid update period";
                    return;
                }

                if ((GB_FI_Name.Modified) || (GB_FI_Link.Modified) || (GB_FI_RT.Modified))
                {
                    info.link = GB_FI_Link.Text;
                    info.name = GB_FI_Name.Text;
                    info.refMins = GB_FI_RT.Text;
                    info.enable = GB_FI_Enable.Text;
                    tnode = userConfig.setFeedInfo(tnode, info);
                }
            }


            GB_FeedInfo.Visible = false;
            splitContainer2.Panel1.Enabled = true;
        }

        // User presses cancel option for the feed info form

        private void FI_Cancel_Click(object sender, EventArgs e)
        {
            GB_FeedInfo.Visible = false;
            splitContainer2.Panel1.Enabled = true;
        }

        // user exit option - save any changes to file and then exit

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userConfig.save();
            Application.Exit();
        }

        // Delete the node and update the config

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode tnode = treeView1.SelectedNode;

            tnode = userConfig.deleteNode(tnode);    
        }

        // Inserts child feed at the selected node
        // after passing the appropriate function using tnode

        private void insertChildFeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode tnode;
            tnode = treeView1.SelectedNode;
            if (tnode != null)
            {
                treeView1.SelectedNode = userConfig.insertChildFeed(tnode);
                modifyToolStripMenuItem_Click(sender, e);
            }
        }

        // Inserts child channel at the selected node
        // after passing the appropriate function using tnode

        private void insertChildChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode tnode;
            tnode = treeView1.SelectedNode;
            if (tnode != null)
            {
                treeView1.SelectedNode = userConfig.insertChildChannel(tnode);
                modifyToolStripMenuItem_Click(sender, e);
            }
        }

        // User has selected the new option
        // Display the file dialog form and capture the file name
        // If cancel is selected return 
        // Else 
        // Call userConfig.create to create new file and TreeNode graph
        // Map the TreeNode graph to TreeView
        // Turn on EditMode and display global info form for modification

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            
            string file = saveFileDialog1.FileName;
            root = userConfig.create (file);
            
            // Bind userConfigTN to treeView1

            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(root);
            treeView1.ExpandAll();

            this.editModeToolStripMenuItem.Visible = true;
            editMode = false;

            editModeToolStripMenuItem_Click(sender, e); // turn-on edit mode

            treeView1.SelectedNode = root;
            modifyToolStripMenuItem_Click(sender, e); // Displays the global info form
        }

        // Displays an openFileDialog form
        // User selects a valid file and file gets loaded using userConfig.load
        // TreeNode root is used as a data source for the treeView
        // Displays the TreeNode graph in treeView

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                root = userConfig.load(file);

                if (root != null)
                {
                    // Bind root to treeView1

                    treeView1.Nodes.Clear();
                    treeView1.Nodes.Add(root);
                    treeView1.ExpandAll();
 
                    this.editModeToolStripMenuItem.Visible = true;
                    userFG.load(userConfig.getFeedInfo(), userConfig.getGlobalInfo(root)); // load Feed Items for all feeds
                    this.timeFilterToolStripMenuItem.Visible = true; // enable TimeFilter

                    webBrowser1.Visible = true;
                }
            }
        }

        // Inserts channel that's adjacent to an existing channel

        private void insertNextChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode tnode;
            tnode = treeView1.SelectedNode;
            if (tnode != null)
            {
                treeView1.SelectedNode = userConfig.insertNextChannel(tnode);
                modifyToolStripMenuItem_Click(sender, e);
            }
        }

        // Grid Operations - non-editmode

        // Displays list of FeedRows from a selected feed

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tnode = treeView1.SelectedNode;
                               
            if ((tnode != null) && (!editMode))
            {
                if (userConfig.getNodeType(tnode) == NodeType.Feed)
                {
                    datagridTN = tnode;

                    if (timeFilter)
                        dataGridView1.DataSource = userFG.getFeedItems(tnode.Name, timeDelta);
                    else if (dateFilter)
                            dataGridView1.DataSource = userFG.getFeedItems(tnode.Name, dateFrom, dateTo);
                    else
                        dataGridView1.DataSource = userFG.getFeedItems(tnode.Name);

                    if (dataGridView1.DataSource != null)
                    {
                        dataGridView1.Columns["link"].Visible = false;
                        dataGridView1.Columns["description"].Visible = false;
                        dataGridView1.Columns["title"].Width = 500;
                        dataGridView1.Columns["pubDate"].Width = 200;
                        dataGridView1.Columns["pubDate"].HeaderText = "pubDate//description";
                    }
                }

                else
                {
                    treeView1.SelectedNode = datagridTN; // keep the selection to the valid Feed entry
                }  
            }


        }

        // user clicks a cell in data grid
        // takes appropriate action depending on the selected column

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            treeView1.Focus(); // need this to have the last selection high-lighted in TreeView

            if (dataGridView1.Columns[colIndex].Name == "title")
            {
                string url;
                url = dataGridView1.CurrentRow.Cells["link"].Value.ToString();
                // MessageBox.Show(dataGridView2.CurrentRow.Cells["link"].Value.ToString());

                if (url != "")
                    webBrowser1.Navigate(url);

                userFG.setReadFlg(datagridTN.Name, rowIndex);
                dataGridView1.InvalidateRow(rowIndex);
            }

            if (dataGridView1.Columns[colIndex].Name == "readFlag")
                userFG.switchReadFlg(datagridTN.Name, rowIndex);

            if (dataGridView1.Columns[colIndex].Name == "pubDate")
                webBrowser1.DocumentText = dataGridView1.CurrentRow.Cells["description"].Value.ToString();
        }

        // Called when timerFeedRefresh is enabled and the timer interval has expired
        // Calls the timer function in userFG to do the Feed Refresh and merge (if needed)

        private void timerFeedRefresh_Tick(object sender, EventArgs e)
        {
            userFG.timerTickEvent(timerFeedRefresh.Interval);
        }

        // gets called when DataChanged event gets triggered in the userFG object
        // UI changes are handled (if needed) when the underlying data is changed

        private void onFeedDataChange(object source, PropertyChangedEventArgs e)
        {
            TreeNode tnode = treeView1.SelectedNode;

            if ((tnode != null) && (!editMode) && (e.PropertyName == tnode.Name)) // current Feed has been updated; refresh the screen
            {
                dataGridView1.Visible = false;
                dataGridView1.DataSource = null;
                if (timeFilter)
                    dataGridView1.DataSource = userFG.getFeedItems(tnode.Name, timeDelta);
                else if (dateFilter)
                    dataGridView1.DataSource = userFG.getFeedItems(tnode.Name, dateFrom, dateTo);
                else
                    dataGridView1.DataSource = userFG.getFeedItems(tnode.Name);

   //             dataGridView1.DataSource = cf;
                dataGridView1.Columns["link"].Visible = false;
                dataGridView1.Columns["description"].Visible = false;
                dataGridView1.Columns["title"].Width = 500;
                dataGridView1.Columns["pubDate"].Width = 200;
                dataGridView1.Visible = true;
            }
 
  
        }

        // Series of function to handle time fitering based on the Last <n> minutes
        // handling user input & setting the global variables

        private void thirtyMinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTsmi != null)
                currentTsmi.Checked = false;
            currentTsmi = (ToolStripMenuItem)sender;
            currentTsmi.Checked = true;
            timeDelta = 30;
            repaintGrid();
        }

        private void oneHrToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (currentTsmi != null)
                currentTsmi.Checked = false;
            currentTsmi = (ToolStripMenuItem)sender;
            currentTsmi.Checked = true;
            timeDelta = 60;
            repaintGrid();
        }

        private void twoHrToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (currentTsmi != null)
                currentTsmi.Checked = false;
            currentTsmi = (ToolStripMenuItem)sender;
            currentTsmi.Checked = true;
            timeDelta = 120;
            repaintGrid();
        }

        private void fourHrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTsmi != null)
                currentTsmi.Checked = false;
            currentTsmi = (ToolStripMenuItem)sender;
            currentTsmi.Checked = true;
            timeDelta = 240;
            repaintGrid();
        }

        private void oneDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTsmi != null)
                currentTsmi.Checked = false;
            currentTsmi = (ToolStripMenuItem)sender;
            currentTsmi.Checked = true;
            timeDelta = 24 * 60;
            repaintGrid();
        }

        private void twoDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTsmi != null)
                currentTsmi.Checked = false;
            currentTsmi = (ToolStripMenuItem)sender;
            currentTsmi.Checked = true;
            timeDelta = 2 * 24 * 60;
            repaintGrid();
        }

        private void lastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timeDelta > 0)
            {
                timeFilter = !timeFilter;
                this.lastToolStripMenuItem.Checked = timeFilter;

                // repaint the current grid

                TreeNode tnode = treeView1.SelectedNode;
                repaintGrid();
            }

            if (timeFilter)
            {
                dateFilter = false;
                dateRangeToolStripMenuItem.Checked = false;

            }
        }

        // Date Range functions - handling user input & setting the global variables

  

        private void dateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GB_DateRange.Visible = true;

            dataGridView1.Enabled = false;
            splitContainer2.Panel1.Enabled = false;
            webBrowser1.Visible = false;
            menuStrip1.Enabled = false;

        }

        private void DateRangeOK_Button_Click(object sender, EventArgs e)
        {
            dateFrom = dateTimePicker1.Value;
            dateTo = dateTimePicker2.Value;


            dateRangeToolStripMenuItem.Checked = true;
            dateFilter = true;

            timeFilter = false;
            lastToolStripMenuItem.Checked = false;

            // repaint the current grid

            TreeNode tnode = treeView1.SelectedNode;
            repaintGrid();


            GB_DateRange.Visible = false;
            dataGridView1.Enabled = true;
            splitContainer2.Panel1.Enabled = true;
            webBrowser1.Visible = true;
            menuStrip1.Enabled = true;

        }

        private void DateRangeCancel_Button_Click(object sender, EventArgs e)
        {
            dateRangeToolStripMenuItem.Checked = false;
            dateFilter = false;

            // repaint the current grid

            TreeNode tnode = treeView1.SelectedNode;
            repaintGrid();

            GB_DateRange.Visible = false;
            dataGridView1.Enabled = true;
            splitContainer2.Panel1.Enabled = true;
            webBrowser1.Visible = true;
            menuStrip1.Enabled = true;
        }     

  
            
        private void repaintGrid()
        {

                TreeNode tnode = treeView1.SelectedNode;

                if ((tnode != null) && (!editMode)) // current Feed has been updated; refresh the screen
                {
                    dataGridView1.Visible = false;
                    dataGridView1.DataSource = null;
                    if (timeFilter)
                        dataGridView1.DataSource = userFG.getFeedItems(tnode.Name, timeDelta);
                    else if (dateFilter)
                        dataGridView1.DataSource = userFG.getFeedItems(tnode.Name, dateFrom, dateTo);
                    else
                        dataGridView1.DataSource = userFG.getFeedItems(tnode.Name);

//                    dataGridView1.DataSource = cf;
                    dataGridView1.Columns["link"].Visible = false;
                    dataGridView1.Columns["description"].Visible = false;
                    dataGridView1.Columns["title"].Width = 500;
                    dataGridView1.Columns["pubDate"].Width = 200;
                    dataGridView1.Visible = true;
                }

        }


        // -- Functions related to DEMO ---


        // Gets called when user clicks on Demo from the menu strip
        // displays the demo form
        // sets/resets appropriate views

        private void demoToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
            this.editToolStripMenuItem.Visible = false;
            this.fileToolStripMenuItem.Visible = false;
            this.demoToolStripMenuItem.Visible = false;
            this.timeFilterToolStripMenuItem.Visible = false;

            // Only show the FeedInfo form and not show the other forms

            GB_Demo.Visible = true;

            GB_FeedInfo.Visible = false;
            GB_ChannelInfo.Visible = false;
            GB_GlobalInfo.Visible = false;
            webBrowser1.Visible = false;
            splitContainer2.Visible = false;

 

        }



        // This method helps in the demo simulation - Gets called when user clicks on OK button of Demo Form 
        // Does basic validation on the form fields - returns with error msg if the validation fails
        // Sets up the following for demo:
        //      Creates a new config (ie root) 
        //      Inserts a Feed as child
        //      Updates the needed feed fields
        //      Loads the configuration
        //      Enables the timerDemo
        //      Sets/Resets the appropriate views
        //      initializes the current row (cr) to zero

        private void demoOkButton_Click(object sender, EventArgs e)
        {
            TreeNode  tnode;

            // add edit code here

            
            if (!validLink(DemoURL.Text))
            {
                DemoErrMsg.Text = "Error: Invalid URL";
                return;
            }

            if (DemoKeyword.Text == "")
            {
                DemoErrMsg.Text = "Error: Invalid Keyword";
                return;
            }
            

            // create the root node

            root = userConfig.create("demo.xml");

            // Bind  to treeView1

            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(root);
            treeView1.ExpandAll();
  

            // create child feed (template)

            tnode = root;

            treeView1.SelectedNode = userConfig.insertChildFeed(tnode);

            tnode = treeView1.SelectedNode;

            FeedInfo info;
         

            info.link = DemoURL.Text;
            info.name = "DemoFeed";
            info.refMins = "99999";
            info.enable = "Yes";
            tnode = userConfig.setFeedInfo(tnode, info);


            // reload the feed data for the new configuration 

            userFG.load(userConfig.getFeedInfo(), userConfig.getGlobalInfo(root));


            // simulate user selection

 
            treeView1_AfterSelect(sender, null);

            // enable timer

            timerDemo.Enabled = true;
            timerFeedRefresh.Enabled = false;

            // enable the appropriate views

            GB_Demo.Visible = false;
            webBrowser1.Visible = true;
   
            splitContainer2.Visible = true;
            cr = 0;

            
        }

        // This method helps in the demo simulation - Gets called when user clicks on Cancel button of Demo Form 
        // Also gets called by the TimerDemoClick to do the needed cleanup after the demo is done
        // sets/resets appropriate forms, timer etc to the normal state used in the view mode

        private void demoCancelButton_Click(object sender, EventArgs e)
        {

            GB_Demo.Visible = false;
            webBrowser1.Visible = true;

            splitContainer2.Visible = true;

            timerDemo.Enabled = false;
 
            cr = 0;
            timerFeedRefresh.Enabled = true;

            this.editToolStripMenuItem.Visible = false;
            this.fileToolStripMenuItem.Visible = true;
            this.demoToolStripMenuItem.Visible = true;

            timeFilter = false;
            this.lastToolStripMenuItem.Checked = false;

            treeView1.Nodes.Clear();
            dataGridView1.DataSource = null;
            webBrowser1.DocumentText = "";
            return;
 
        }

        // This method helps in the demo simulation
        //      gets called at regular intervals when the timerDemo is enabled
        //      highlights keywords (if found) in the description of the current feed row
        //      displays the description in the webbrowser area
        //      makes visual changes to the data grid to show the selected row
        //      calls the demoCancelButton if the end of Demo is reached, after resetting the timer

        private void timerDemo_Tick(object sender, EventArgs e)
        {
 
            string HTMLtext;

            
            if (cr == dataGridView1.RowCount)  // we have reached the end; enbale appropriate views/settings to return to view mode
            {
                timerDemo.Enabled = false;
                MessageBox.Show("Demo Complete - Search Failed");
                demoCancelButton_Click(sender, e);
                return;

            }
            HTMLtext = (dataGridView1.Rows[cr].Cells["description"].Value.ToString());

            webBrowser1.DocumentText = HTMLtext.Replace(DemoKeyword.Text, "<span style= 'background-color:yellow'>" + DemoKeyword.Text + "</span>");

            if (HTMLtext.Contains(DemoKeyword.Text))
            {
                 timerDemo.Enabled = false;
                 MessageBox.Show("Demo Complete - Search Successful");
                 demoCancelButton_Click(sender, e);
                 return;
            }

            if (cr > 0) // de select the last select
                dataGridView1.Rows[cr-1].Selected = false;

            dataGridView1.Rows[cr].Selected = true;

            dataGridView1.CurrentCell = dataGridView1[0, cr]; // scroll (if needed)

            cr++; // point to the next row

        }

  
    }
}
