namespace CS_323_Project_1
{
    partial class UserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertChildChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertChildFeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNextChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirtyMinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneHrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoHrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourHrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GB_DateRange = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DateRangeCancel_Button = new System.Windows.Forms.Button();
            this.DateRangeOK_Button = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.GB_GlobalInfo = new System.Windows.Forms.GroupBox();
            this.GB_GI_ErrorMsg = new System.Windows.Forms.TextBox();
            this.GB_GI_updatePeriod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GB_GI_nbrLines = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GB_GI_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UI_Cancel = new System.Windows.Forms.Button();
            this.UI_OK = new System.Windows.Forms.Button();
            this.GB_ChannelInfo = new System.Windows.Forms.GroupBox();
            this.GB_CI_ErrorMsg = new System.Windows.Forms.TextBox();
            this.GB_CI_Comments = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GB_CI_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GI_Cancel = new System.Windows.Forms.Button();
            this.GI_OK = new System.Windows.Forms.Button();
            this.GB_FeedInfo = new System.Windows.Forms.GroupBox();
            this.GB_FI_ErrorMsg = new System.Windows.Forms.TextBox();
            this.FI_Cancel = new System.Windows.Forms.Button();
            this.FI_OK = new System.Windows.Forms.Button();
            this.GB_FI_Enable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GB_FI_RT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GB_FI_Link = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GB_FI_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_Demo = new System.Windows.Forms.GroupBox();
            this.DemoErrMsg = new System.Windows.Forms.TextBox();
            this.demoCancelButton = new System.Windows.Forms.Button();
            this.demoOkButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.DemoURL = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DemoKeyword = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerFeedRefresh = new System.Windows.Forms.Timer(this.components);
            this.timerDemo = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GB_DateRange.SuspendLayout();
            this.GB_GlobalInfo.SuspendLayout();
            this.GB_ChannelInfo.SuspendLayout();
            this.GB_FeedInfo.SuspendLayout();
            this.GB_Demo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.timeFilterToolStripMenuItem,
            this.demoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.editModeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Visible = false;
            // 
            // editModeToolStripMenuItem
            // 
            this.editModeToolStripMenuItem.Name = "editModeToolStripMenuItem";
            this.editModeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.editModeToolStripMenuItem.Text = "EditMode";
            this.editModeToolStripMenuItem.Visible = false;
            this.editModeToolStripMenuItem.Click += new System.EventHandler(this.editModeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.insertChildChannelToolStripMenuItem,
            this.insertChildFeedToolStripMenuItem,
            this.insertNextChannelToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // insertChildChannelToolStripMenuItem
            // 
            this.insertChildChannelToolStripMenuItem.Name = "insertChildChannelToolStripMenuItem";
            this.insertChildChannelToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.insertChildChannelToolStripMenuItem.Text = "Insert Child Channel";
            this.insertChildChannelToolStripMenuItem.Click += new System.EventHandler(this.insertChildChannelToolStripMenuItem_Click);
            // 
            // insertChildFeedToolStripMenuItem
            // 
            this.insertChildFeedToolStripMenuItem.Name = "insertChildFeedToolStripMenuItem";
            this.insertChildFeedToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.insertChildFeedToolStripMenuItem.Text = "Insert Child Feed";
            this.insertChildFeedToolStripMenuItem.Click += new System.EventHandler(this.insertChildFeedToolStripMenuItem_Click);
            // 
            // insertNextChannelToolStripMenuItem
            // 
            this.insertNextChannelToolStripMenuItem.Name = "insertNextChannelToolStripMenuItem";
            this.insertNextChannelToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.insertNextChannelToolStripMenuItem.Text = "Insert Next Channel";
            this.insertNextChannelToolStripMenuItem.Click += new System.EventHandler(this.insertNextChannelToolStripMenuItem_Click);
            // 
            // timeFilterToolStripMenuItem
            // 
            this.timeFilterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastToolStripMenuItem,
            this.dateRangeToolStripMenuItem});
            this.timeFilterToolStripMenuItem.Name = "timeFilterToolStripMenuItem";
            this.timeFilterToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.timeFilterToolStripMenuItem.Text = "TimeFilter";
            // 
            // lastToolStripMenuItem
            // 
            this.lastToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thirtyMinsToolStripMenuItem,
            this.oneHrToolStripMenuItem,
            this.twoHrToolStripMenuItem,
            this.fourHrToolStripMenuItem,
            this.oneDayToolStripMenuItem,
            this.twoDayToolStripMenuItem});
            this.lastToolStripMenuItem.Name = "lastToolStripMenuItem";
            this.lastToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.lastToolStripMenuItem.Text = "Last";
            this.lastToolStripMenuItem.Click += new System.EventHandler(this.lastToolStripMenuItem_Click);
            // 
            // thirtyMinsToolStripMenuItem
            // 
            this.thirtyMinsToolStripMenuItem.CheckOnClick = true;
            this.thirtyMinsToolStripMenuItem.Name = "thirtyMinsToolStripMenuItem";
            this.thirtyMinsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.thirtyMinsToolStripMenuItem.Text = "30 mins";
            this.thirtyMinsToolStripMenuItem.Click += new System.EventHandler(this.thirtyMinsToolStripMenuItem_Click);
            // 
            // oneHrToolStripMenuItem
            // 
            this.oneHrToolStripMenuItem.CheckOnClick = true;
            this.oneHrToolStripMenuItem.Name = "oneHrToolStripMenuItem";
            this.oneHrToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.oneHrToolStripMenuItem.Text = "1 hr";
            this.oneHrToolStripMenuItem.Click += new System.EventHandler(this.oneHrToolStripMenuItem1_Click);
            // 
            // twoHrToolStripMenuItem
            // 
            this.twoHrToolStripMenuItem.Name = "twoHrToolStripMenuItem";
            this.twoHrToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.twoHrToolStripMenuItem.Text = "2 hrs";
            this.twoHrToolStripMenuItem.Click += new System.EventHandler(this.twoHrToolStripMenuItem1_Click);
            // 
            // fourHrToolStripMenuItem
            // 
            this.fourHrToolStripMenuItem.Name = "fourHrToolStripMenuItem";
            this.fourHrToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.fourHrToolStripMenuItem.Text = "4 hrs";
            this.fourHrToolStripMenuItem.Click += new System.EventHandler(this.fourHrToolStripMenuItem_Click);
            // 
            // oneDayToolStripMenuItem
            // 
            this.oneDayToolStripMenuItem.Name = "oneDayToolStripMenuItem";
            this.oneDayToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.oneDayToolStripMenuItem.Text = "24 hrs";
            this.oneDayToolStripMenuItem.Click += new System.EventHandler(this.oneDayToolStripMenuItem_Click);
            // 
            // twoDayToolStripMenuItem
            // 
            this.twoDayToolStripMenuItem.Name = "twoDayToolStripMenuItem";
            this.twoDayToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.twoDayToolStripMenuItem.Text = "48 hrs";
            this.twoDayToolStripMenuItem.Click += new System.EventHandler(this.twoDayToolStripMenuItem_Click);
            // 
            // dateRangeToolStripMenuItem
            // 
            this.dateRangeToolStripMenuItem.Name = "dateRangeToolStripMenuItem";
            this.dateRangeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dateRangeToolStripMenuItem.Text = "Date Range";
            this.dateRangeToolStripMenuItem.Click += new System.EventHandler(this.dateRangeToolStripMenuItem_Click);
            // 
            // demoToolStripMenuItem
            // 
            this.demoToolStripMenuItem.Name = "demoToolStripMenuItem";
            this.demoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.demoToolStripMenuItem.Text = "Demo";
            this.demoToolStripMenuItem.Click += new System.EventHandler(this.demoToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel2.Controls.Add(this.GB_GlobalInfo);
            this.splitContainer1.Panel2.Controls.Add(this.GB_ChannelInfo);
            this.splitContainer1.Panel2.Controls.Add(this.GB_FeedInfo);
            this.splitContainer1.Panel2.Controls.Add(this.GB_Demo);
            this.splitContainer1.Panel2.Controls.Add(this.GB_DateRange);
            this.splitContainer1.Size = new System.Drawing.Size(758, 454);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(758, 177);
            this.splitContainer2.SplitterDistance = 249;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(249, 177);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 177);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // GB_DateRange
            // 
            this.GB_DateRange.Controls.Add(this.dateTimePicker2);
            this.GB_DateRange.Controls.Add(this.dateTimePicker1);
            this.GB_DateRange.Controls.Add(this.label13);
            this.GB_DateRange.Controls.Add(this.label11);
            this.GB_DateRange.Controls.Add(this.DateRangeCancel_Button);
            this.GB_DateRange.Controls.Add(this.DateRangeOK_Button);
            this.GB_DateRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_DateRange.Location = new System.Drawing.Point(0, 0);
            this.GB_DateRange.Name = "GB_DateRange";
            this.GB_DateRange.Size = new System.Drawing.Size(758, 273);
            this.GB_DateRange.TabIndex = 5;
            this.GB_DateRange.TabStop = false;
            this.GB_DateRange.Text = "DateRange";
            this.GB_DateRange.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(285, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "To";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "From";
            // 
            // DateRangeCancel_Button
            // 
            this.DateRangeCancel_Button.Location = new System.Drawing.Point(544, 101);
            this.DateRangeCancel_Button.Name = "DateRangeCancel_Button";
            this.DateRangeCancel_Button.Size = new System.Drawing.Size(75, 23);
            this.DateRangeCancel_Button.TabIndex = 4;
            this.DateRangeCancel_Button.Text = "Cancel";
            this.DateRangeCancel_Button.UseVisualStyleBackColor = true;
            this.DateRangeCancel_Button.Click += new System.EventHandler(this.DateRangeCancel_Button_Click);
            // 
            // DateRangeOK_Button
            // 
            this.DateRangeOK_Button.Location = new System.Drawing.Point(544, 50);
            this.DateRangeOK_Button.Name = "DateRangeOK_Button";
            this.DateRangeOK_Button.Size = new System.Drawing.Size(75, 23);
            this.DateRangeOK_Button.TabIndex = 3;
            this.DateRangeOK_Button.Text = "OK";
            this.DateRangeOK_Button.UseVisualStyleBackColor = true;
            this.DateRangeOK_Button.Click += new System.EventHandler(this.DateRangeOK_Button_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(758, 273);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Visible = false;
            // 
            // GB_GlobalInfo
            // 
            this.GB_GlobalInfo.Controls.Add(this.GB_GI_ErrorMsg);
            this.GB_GlobalInfo.Controls.Add(this.GB_GI_updatePeriod);
            this.GB_GlobalInfo.Controls.Add(this.label10);
            this.GB_GlobalInfo.Controls.Add(this.GB_GI_nbrLines);
            this.GB_GlobalInfo.Controls.Add(this.label8);
            this.GB_GlobalInfo.Controls.Add(this.GB_GI_Name);
            this.GB_GlobalInfo.Controls.Add(this.label9);
            this.GB_GlobalInfo.Controls.Add(this.UI_Cancel);
            this.GB_GlobalInfo.Controls.Add(this.UI_OK);
            this.GB_GlobalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_GlobalInfo.Location = new System.Drawing.Point(0, 0);
            this.GB_GlobalInfo.Name = "GB_GlobalInfo";
            this.GB_GlobalInfo.Size = new System.Drawing.Size(758, 273);
            this.GB_GlobalInfo.TabIndex = 3;
            this.GB_GlobalInfo.TabStop = false;
            this.GB_GlobalInfo.Text = "Global Info";
            this.GB_GlobalInfo.Visible = false;
            // 
            // GB_GI_ErrorMsg
            // 
            this.GB_GI_ErrorMsg.Location = new System.Drawing.Point(22, 127);
            this.GB_GI_ErrorMsg.Name = "GB_GI_ErrorMsg";
            this.GB_GI_ErrorMsg.ReadOnly = true;
            this.GB_GI_ErrorMsg.Size = new System.Drawing.Size(229, 20);
            this.GB_GI_ErrorMsg.TabIndex = 22;
            // 
            // GB_GI_updatePeriod
            // 
            this.GB_GI_updatePeriod.Location = new System.Drawing.Point(175, 88);
            this.GB_GI_updatePeriod.Name = "GB_GI_updatePeriod";
            this.GB_GI_updatePeriod.Size = new System.Drawing.Size(36, 20);
            this.GB_GI_updatePeriod.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Feed Update Period (Mins)";
            // 
            // GB_GI_nbrLines
            // 
            this.GB_GI_nbrLines.Location = new System.Drawing.Point(175, 53);
            this.GB_GI_nbrLines.Name = "GB_GI_nbrLines";
            this.GB_GI_nbrLines.Size = new System.Drawing.Size(36, 20);
            this.GB_GI_nbrLines.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "# Lines to Display";
            // 
            // GB_GI_Name
            // 
            this.GB_GI_Name.Location = new System.Drawing.Point(175, 24);
            this.GB_GI_Name.Name = "GB_GI_Name";
            this.GB_GI_Name.ReadOnly = true;
            this.GB_GI_Name.Size = new System.Drawing.Size(100, 20);
            this.GB_GI_Name.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Name";
            // 
            // UI_Cancel
            // 
            this.UI_Cancel.Location = new System.Drawing.Point(427, 130);
            this.UI_Cancel.Name = "UI_Cancel";
            this.UI_Cancel.Size = new System.Drawing.Size(75, 23);
            this.UI_Cancel.TabIndex = 12;
            this.UI_Cancel.Text = "Cancel";
            this.UI_Cancel.UseVisualStyleBackColor = true;
            this.UI_Cancel.Click += new System.EventHandler(this.GI_Cancel_Click);
            // 
            // UI_OK
            // 
            this.UI_OK.Location = new System.Drawing.Point(311, 124);
            this.UI_OK.Name = "UI_OK";
            this.UI_OK.Size = new System.Drawing.Size(75, 29);
            this.UI_OK.TabIndex = 11;
            this.UI_OK.Text = "OK";
            this.UI_OK.UseVisualStyleBackColor = true;
            this.UI_OK.Click += new System.EventHandler(this.GI_OK_Click);
            // 
            // GB_ChannelInfo
            // 
            this.GB_ChannelInfo.Controls.Add(this.GB_CI_ErrorMsg);
            this.GB_ChannelInfo.Controls.Add(this.GB_CI_Comments);
            this.GB_ChannelInfo.Controls.Add(this.label7);
            this.GB_ChannelInfo.Controls.Add(this.GB_CI_Name);
            this.GB_ChannelInfo.Controls.Add(this.label6);
            this.GB_ChannelInfo.Controls.Add(this.GI_Cancel);
            this.GB_ChannelInfo.Controls.Add(this.GI_OK);
            this.GB_ChannelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_ChannelInfo.Location = new System.Drawing.Point(0, 0);
            this.GB_ChannelInfo.Name = "GB_ChannelInfo";
            this.GB_ChannelInfo.Size = new System.Drawing.Size(758, 273);
            this.GB_ChannelInfo.TabIndex = 2;
            this.GB_ChannelInfo.TabStop = false;
            this.GB_ChannelInfo.Text = "Channel Info";
            this.GB_ChannelInfo.Visible = false;
            // 
            // GB_CI_ErrorMsg
            // 
            this.GB_CI_ErrorMsg.Location = new System.Drawing.Point(28, 115);
            this.GB_CI_ErrorMsg.Name = "GB_CI_ErrorMsg";
            this.GB_CI_ErrorMsg.ReadOnly = true;
            this.GB_CI_ErrorMsg.Size = new System.Drawing.Size(299, 20);
            this.GB_CI_ErrorMsg.TabIndex = 16;
            // 
            // GB_CI_Comments
            // 
            this.GB_CI_Comments.Location = new System.Drawing.Point(81, 53);
            this.GB_CI_Comments.Name = "GB_CI_Comments";
            this.GB_CI_Comments.Size = new System.Drawing.Size(305, 20);
            this.GB_CI_Comments.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Comments";
            // 
            // GB_CI_Name
            // 
            this.GB_CI_Name.Location = new System.Drawing.Point(81, 22);
            this.GB_CI_Name.Name = "GB_CI_Name";
            this.GB_CI_Name.Size = new System.Drawing.Size(100, 20);
            this.GB_CI_Name.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name";
            // 
            // GI_Cancel
            // 
            this.GI_Cancel.Location = new System.Drawing.Point(556, 124);
            this.GI_Cancel.Name = "GI_Cancel";
            this.GI_Cancel.Size = new System.Drawing.Size(75, 23);
            this.GI_Cancel.TabIndex = 11;
            this.GI_Cancel.Text = "Cancel";
            this.GI_Cancel.UseVisualStyleBackColor = true;
            this.GI_Cancel.Click += new System.EventHandler(this.CI_Cancel_Click);
            // 
            // GI_OK
            // 
            this.GI_OK.Location = new System.Drawing.Point(438, 118);
            this.GI_OK.Name = "GI_OK";
            this.GI_OK.Size = new System.Drawing.Size(75, 29);
            this.GI_OK.TabIndex = 10;
            this.GI_OK.Text = "OK";
            this.GI_OK.UseVisualStyleBackColor = true;
            this.GI_OK.Click += new System.EventHandler(this.CI_OK_Click);
            // 
            // GB_FeedInfo
            // 
            this.GB_FeedInfo.Controls.Add(this.GB_FI_ErrorMsg);
            this.GB_FeedInfo.Controls.Add(this.FI_Cancel);
            this.GB_FeedInfo.Controls.Add(this.FI_OK);
            this.GB_FeedInfo.Controls.Add(this.GB_FI_Enable);
            this.GB_FeedInfo.Controls.Add(this.label5);
            this.GB_FeedInfo.Controls.Add(this.label4);
            this.GB_FeedInfo.Controls.Add(this.GB_FI_RT);
            this.GB_FeedInfo.Controls.Add(this.label3);
            this.GB_FeedInfo.Controls.Add(this.GB_FI_Link);
            this.GB_FeedInfo.Controls.Add(this.label2);
            this.GB_FeedInfo.Controls.Add(this.GB_FI_Name);
            this.GB_FeedInfo.Controls.Add(this.label1);
            this.GB_FeedInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_FeedInfo.Location = new System.Drawing.Point(0, 0);
            this.GB_FeedInfo.Name = "GB_FeedInfo";
            this.GB_FeedInfo.Size = new System.Drawing.Size(758, 273);
            this.GB_FeedInfo.TabIndex = 1;
            this.GB_FeedInfo.TabStop = false;
            this.GB_FeedInfo.Text = "Feed Info";
            this.GB_FeedInfo.Visible = false;
            // 
            // GB_FI_ErrorMsg
            // 
            this.GB_FI_ErrorMsg.Location = new System.Drawing.Point(26, 136);
            this.GB_FI_ErrorMsg.Name = "GB_FI_ErrorMsg";
            this.GB_FI_ErrorMsg.ReadOnly = true;
            this.GB_FI_ErrorMsg.Size = new System.Drawing.Size(279, 20);
            this.GB_FI_ErrorMsg.TabIndex = 11;
            // 
            // FI_Cancel
            // 
            this.FI_Cancel.Location = new System.Drawing.Point(544, 127);
            this.FI_Cancel.Name = "FI_Cancel";
            this.FI_Cancel.Size = new System.Drawing.Size(75, 23);
            this.FI_Cancel.TabIndex = 10;
            this.FI_Cancel.Text = "Cancel";
            this.FI_Cancel.UseVisualStyleBackColor = true;
            this.FI_Cancel.Click += new System.EventHandler(this.FI_Cancel_Click);
            // 
            // FI_OK
            // 
            this.FI_OK.Location = new System.Drawing.Point(410, 124);
            this.FI_OK.Name = "FI_OK";
            this.FI_OK.Size = new System.Drawing.Size(75, 29);
            this.FI_OK.TabIndex = 9;
            this.FI_OK.Text = "OK";
            this.FI_OK.UseVisualStyleBackColor = true;
            this.FI_OK.Click += new System.EventHandler(this.FI_OK_Click);
            // 
            // GB_FI_Enable
            // 
            this.GB_FI_Enable.FormattingEnabled = true;
            this.GB_FI_Enable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.GB_FI_Enable.Location = new System.Drawing.Point(158, 95);
            this.GB_FI_Enable.Name = "GB_FI_Enable";
            this.GB_FI_Enable.Size = new System.Drawing.Size(53, 21);
            this.GB_FI_Enable.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // GB_FI_RT
            // 
            this.GB_FI_RT.Location = new System.Drawing.Point(158, 69);
            this.GB_FI_RT.Name = "GB_FI_RT";
            this.GB_FI_RT.Size = new System.Drawing.Size(36, 20);
            this.GB_FI_RT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Update Period (Mins)";
            // 
            // GB_FI_Link
            // 
            this.GB_FI_Link.Location = new System.Drawing.Point(158, 45);
            this.GB_FI_Link.Name = "GB_FI_Link";
            this.GB_FI_Link.Size = new System.Drawing.Size(438, 20);
            this.GB_FI_Link.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "link";
            // 
            // GB_FI_Name
            // 
            this.GB_FI_Name.Location = new System.Drawing.Point(158, 19);
            this.GB_FI_Name.Name = "GB_FI_Name";
            this.GB_FI_Name.Size = new System.Drawing.Size(100, 20);
            this.GB_FI_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // GB_Demo
            // 
            this.GB_Demo.Controls.Add(this.DemoErrMsg);
            this.GB_Demo.Controls.Add(this.demoCancelButton);
            this.GB_Demo.Controls.Add(this.demoOkButton);
            this.GB_Demo.Controls.Add(this.label12);
            this.GB_Demo.Controls.Add(this.DemoURL);
            this.GB_Demo.Controls.Add(this.label14);
            this.GB_Demo.Controls.Add(this.DemoKeyword);
            this.GB_Demo.Controls.Add(this.label15);
            this.GB_Demo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Demo.Location = new System.Drawing.Point(0, 0);
            this.GB_Demo.Name = "GB_Demo";
            this.GB_Demo.Size = new System.Drawing.Size(758, 273);
            this.GB_Demo.TabIndex = 4;
            this.GB_Demo.TabStop = false;
            this.GB_Demo.Text = "Demo";
            this.GB_Demo.Visible = false;
            // 
            // DemoErrMsg
            // 
            this.DemoErrMsg.Location = new System.Drawing.Point(26, 136);
            this.DemoErrMsg.Name = "DemoErrMsg";
            this.DemoErrMsg.ReadOnly = true;
            this.DemoErrMsg.Size = new System.Drawing.Size(279, 20);
            this.DemoErrMsg.TabIndex = 11;
            // 
            // demoCancelButton
            // 
            this.demoCancelButton.Location = new System.Drawing.Point(544, 127);
            this.demoCancelButton.Name = "demoCancelButton";
            this.demoCancelButton.Size = new System.Drawing.Size(75, 23);
            this.demoCancelButton.TabIndex = 10;
            this.demoCancelButton.Text = "Cancel";
            this.demoCancelButton.UseVisualStyleBackColor = true;
            this.demoCancelButton.Click += new System.EventHandler(this.demoCancelButton_Click);
            // 
            // demoOkButton
            // 
            this.demoOkButton.Location = new System.Drawing.Point(410, 124);
            this.demoOkButton.Name = "demoOkButton";
            this.demoOkButton.Size = new System.Drawing.Size(75, 29);
            this.demoOkButton.TabIndex = 9;
            this.demoOkButton.Text = "OK";
            this.demoOkButton.UseVisualStyleBackColor = true;
            this.demoOkButton.Click += new System.EventHandler(this.demoOkButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 6;
            // 
            // DemoURL
            // 
            this.DemoURL.Location = new System.Drawing.Point(158, 45);
            this.DemoURL.Name = "DemoURL";
            this.DemoURL.Size = new System.Drawing.Size(438, 20);
            this.DemoURL.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "URL";
            // 
            // DemoKeyword
            // 
            this.DemoKeyword.Location = new System.Drawing.Point(158, 76);
            this.DemoKeyword.Name = "DemoKeyword";
            this.DemoKeyword.Size = new System.Drawing.Size(100, 20);
            this.DemoKeyword.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Keyword";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timerFeedRefresh
            // 
            this.timerFeedRefresh.Enabled = true;
            this.timerFeedRefresh.Interval = 30000;
            this.timerFeedRefresh.Tick += new System.EventHandler(this.timerFeedRefresh_Tick);
            // 
            // timerDemo
            // 
            this.timerDemo.Interval = 3000;
            this.timerDemo.Tick += new System.EventHandler(this.timerDemo_Tick);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 478);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserInterface";
            this.Text = "ViewRSS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GB_DateRange.ResumeLayout(false);
            this.GB_DateRange.PerformLayout();
            this.GB_GlobalInfo.ResumeLayout(false);
            this.GB_GlobalInfo.PerformLayout();
            this.GB_ChannelInfo.ResumeLayout(false);
            this.GB_ChannelInfo.PerformLayout();
            this.GB_FeedInfo.ResumeLayout(false);
            this.GB_FeedInfo.PerformLayout();
            this.GB_Demo.ResumeLayout(false);
            this.GB_Demo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox GB_GlobalInfo;
        private System.Windows.Forms.GroupBox GB_ChannelInfo;
        private System.Windows.Forms.GroupBox GB_FeedInfo;
        private System.Windows.Forms.Button FI_Cancel;
        private System.Windows.Forms.Button FI_OK;
        private System.Windows.Forms.ComboBox GB_FI_Enable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GB_FI_RT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GB_FI_Link;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GB_FI_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GB_GI_nbrLines;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GB_GI_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button UI_Cancel;
        private System.Windows.Forms.Button UI_OK;
        private System.Windows.Forms.TextBox GB_CI_Comments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GB_CI_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GI_Cancel;
        private System.Windows.Forms.Button GI_OK;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertChildChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertChildFeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertNextChannelToolStripMenuItem;
        private System.Windows.Forms.TextBox GB_GI_updatePeriod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox GB_GI_ErrorMsg;
        private System.Windows.Forms.TextBox GB_FI_ErrorMsg;
        private System.Windows.Forms.TextBox GB_CI_ErrorMsg;
        private System.Windows.Forms.Timer timerFeedRefresh;
        private System.Windows.Forms.ToolStripMenuItem timeFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thirtyMinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneHrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoHrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourHrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demoToolStripMenuItem;
        private System.Windows.Forms.GroupBox GB_Demo;
        private System.Windows.Forms.TextBox DemoErrMsg;
        private System.Windows.Forms.Button demoCancelButton;
        private System.Windows.Forms.Button demoOkButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DemoURL;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox DemoKeyword;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timerDemo;
        private System.Windows.Forms.GroupBox GB_DateRange;
        private System.Windows.Forms.Button DateRangeCancel_Button;
        private System.Windows.Forms.Button DateRangeOK_Button;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

    }
}

