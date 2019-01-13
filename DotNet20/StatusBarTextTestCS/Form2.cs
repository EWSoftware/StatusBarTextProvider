using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using EWSoftware.StatusBarText;

namespace StatusBarTextTest
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
        private EWSoftware.StatusBarText.StatusBarTextProvider sbMessage;
        private System.Windows.Forms.TabControl tabDemo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DomainUpDown udDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTest;
        private System.Windows.Forms.CheckedListBox lbCheckedLB;
        private System.Windows.Forms.ComboBox cboComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkLabel;
        private System.Windows.Forms.ListBox lbListBox;
        private System.Windows.Forms.ListView lvListView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TreeView tvTree;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox chkUseDialog;
        private System.Windows.Forms.StatusBar sbDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private StatusBarTextTest.DemoUserControl demoUserControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private StatusBarTextTest.UserControlWithProvider ucDemo;
        private Button btnProgress;
        private System.ComponentModel.IContainer components;

		public Form2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            ArrayList al = new ArrayList();

            al.Add(new ListItem(1, "Item #1"));
            al.Add(new ListItem(2, "Item #2"));
            al.Add(new ListItem(3, "Item #3"));
            al.Add(new ListItem(4, "Item #4"));
            dataGrid1.DataSource = al;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Item 1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Item 2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Item 3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Item 4");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.sbMessage = new EWSoftware.StatusBarText.StatusBarTextProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lvListView = new System.Windows.Forms.ListView();
            this.lbListBox = new System.Windows.Forms.ListBox();
            this.lnkLabel = new System.Windows.Forms.LinkLabel();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.cboComboBox = new System.Windows.Forms.ComboBox();
            this.lbCheckedLB = new System.Windows.Forms.CheckedListBox();
            this.chkTest = new System.Windows.Forms.CheckBox();
            this.udDomain = new System.Windows.Forms.DomainUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.chkUseDialog = new System.Windows.Forms.CheckBox();
            this.demoUserControl1 = new StatusBarTextTest.DemoUserControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tvTree = new System.Windows.Forms.TreeView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ucDemo = new StatusBarTextTest.UserControlWithProvider();
            this.label8 = new System.Windows.Forms.Label();
            this.tabDemo = new System.Windows.Forms.TabControl();
            this.btnProgress = new System.Windows.Forms.Button();
            this.sbDialog = new System.Windows.Forms.StatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabDemo.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbMessage
            // 
            this.sbMessage.InstanceDefaultText = null;
            this.sbMessage.InstanceDisplayPanel = 0;
            this.sbMessage.InstanceStatusBar = null;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 22);
            this.sbMessage.SetStatusBarText(this.textBox1, "A standard text box control");
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Standard text box";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(440, 240);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.sbMessage.SetStatusBarText(this.richTextBox1, "A rich text box control");
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "A rich text box";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(144, 56);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 22);
            this.sbMessage.SetStatusBarText(this.numericUpDown1, "A numeric up/down control");
            this.numericUpDown1.TabIndex = 5;
            // 
            // lvListView
            // 
            this.lvListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvListView.Location = new System.Drawing.Point(16, 240);
            this.lvListView.Name = "lvListView";
            this.lvListView.Size = new System.Drawing.Size(184, 80);
            this.sbMessage.SetStatusBarText(this.lvListView, "A list view control");
            this.lvListView.TabIndex = 11;
            this.lvListView.UseCompatibleStateImageBehavior = false;
            this.lvListView.View = System.Windows.Forms.View.List;
            // 
            // lbListBox
            // 
            this.lbListBox.ItemHeight = 16;
            this.lbListBox.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4"});
            this.lbListBox.Location = new System.Drawing.Point(24, 96);
            this.lbListBox.Name = "lbListBox";
            this.lbListBox.Size = new System.Drawing.Size(128, 84);
            this.sbMessage.SetStatusBarText(this.lbListBox, "A list box control");
            this.lbListBox.TabIndex = 8;
            // 
            // lnkLabel
            // 
            this.lnkLabel.Location = new System.Drawing.Point(328, 256);
            this.lnkLabel.Name = "lnkLabel";
            this.lnkLabel.Size = new System.Drawing.Size(88, 16);
            this.sbMessage.SetStatusBarText(this.lnkLabel, "A link label");
            this.lnkLabel.TabIndex = 13;
            this.lnkLabel.TabStop = true;
            this.lnkLabel.Text = "A Link Label";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTime.Location = new System.Drawing.Point(376, 56);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(104, 22);
            this.sbMessage.SetStatusBarText(this.dtpDateTime, "A date/time picker");
            this.dtpDateTime.TabIndex = 7;
            // 
            // dataGrid1
            // 
            this.dataGrid1.CaptionText = "DataGrid";
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(376, 96);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(208, 136);
            this.sbMessage.SetStatusBarText(this.dataGrid1, "A data grid control");
            this.dataGrid1.TabIndex = 10;
            // 
            // cboComboBox
            // 
            this.cboComboBox.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4"});
            this.cboComboBox.Location = new System.Drawing.Point(104, 16);
            this.cboComboBox.Name = "cboComboBox";
            this.cboComboBox.Size = new System.Drawing.Size(136, 24);
            this.sbMessage.SetStatusBarText(this.cboComboBox, "A combo box control");
            this.cboComboBox.TabIndex = 1;
            // 
            // lbCheckedLB
            // 
            this.lbCheckedLB.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4"});
            this.lbCheckedLB.Location = new System.Drawing.Point(240, 96);
            this.lbCheckedLB.Name = "lbCheckedLB";
            this.lbCheckedLB.Size = new System.Drawing.Size(120, 89);
            this.sbMessage.SetStatusBarText(this.lbCheckedLB, "A checked list box control");
            this.lbCheckedLB.TabIndex = 9;
            // 
            // chkTest
            // 
            this.chkTest.Location = new System.Drawing.Point(216, 256);
            this.chkTest.Name = "chkTest";
            this.chkTest.Size = new System.Drawing.Size(104, 24);
            this.sbMessage.SetStatusBarText(this.chkTest, "A checkbox control");
            this.chkTest.TabIndex = 12;
            this.chkTest.Text = "Checkbox";
            // 
            // udDomain
            // 
            this.udDomain.Items.Add("Item 1");
            this.udDomain.Items.Add("Item 2");
            this.udDomain.Items.Add("Item 3");
            this.udDomain.Items.Add("Item 4");
            this.udDomain.Location = new System.Drawing.Point(376, 16);
            this.udDomain.Name = "udDomain";
            this.udDomain.Size = new System.Drawing.Size(120, 22);
            this.sbMessage.SetStatusBarText(this.udDomain, "A domain up/down control");
            this.udDomain.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(528, 408);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 32);
            this.sbMessage.SetStatusBarText(this.btnClose, "Close this dialog box");
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propertyGrid1.Location = new System.Drawing.Point(20, 232);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this;
            this.propertyGrid1.Size = new System.Drawing.Size(568, 120);
            this.sbMessage.SetStatusBarText(this.propertyGrid1, "A property grid control");
            this.propertyGrid1.TabIndex = 1;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(165, 15);
            this.monthCalendar1.Name = "monthCalendar1";
            this.sbMessage.SetStatusBarText(this.monthCalendar1, "A month calendar control in a panel");
            this.monthCalendar1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(16, 56);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 24);
            this.sbMessage.SetStatusBarText(this.radioButton1, "Radio button 2 status bar text");
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Radio Button 2";
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(16, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(128, 24);
            this.sbMessage.SetStatusBarText(this.radioButton2, "Radio button 1 status bar text");
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Radio Button 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Location = new System.Drawing.Point(336, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 160);
            this.sbMessage.SetStatusBarText(this.groupBox1, "A group box control");
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A Group Box";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 64);
            this.label5.TabIndex = 2;
            this.label5.Text = "The radio buttons in this group box have no status bar text so the group box\'s st" +
                "atus bar text is shown instead.";
            // 
            // rb2
            // 
            this.rb2.Location = new System.Drawing.Point(16, 56);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(128, 24);
            this.rb2.TabIndex = 1;
            this.rb2.Text = "Radio Button 2";
            // 
            // rb1
            // 
            this.rb1.Location = new System.Drawing.Point(16, 24);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(128, 24);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Radio Button 1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(52, 16);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(256, 53);
            this.sbMessage.SetStatusBarText(this.trackBar1, "A track bar control");
            this.trackBar1.TabIndex = 0;
            // 
            // chkUseDialog
            // 
            this.chkUseDialog.Location = new System.Drawing.Point(32, 408);
            this.chkUseDialog.Name = "chkUseDialog";
            this.chkUseDialog.Size = new System.Drawing.Size(192, 24);
            this.sbMessage.SetStatusBarText(this.chkUseDialog, "Switch between the application status bar and the dialog\'s status bar");
            this.chkUseDialog.TabIndex = 1;
            this.chkUseDialog.Text = "&Use the dialog\'s status bar";
            this.chkUseDialog.CheckedChanged += new System.EventHandler(this.chkUseDialog_CheckedChanged);
            // 
            // demoUserControl1
            // 
            this.demoUserControl1.Location = new System.Drawing.Point(32, 200);
            this.demoUserControl1.Name = "demoUserControl1";
            this.demoUserControl1.Size = new System.Drawing.Size(136, 32);
            this.sbMessage.SetStatusBarText(this.demoUserControl1, "A custom user control");
            this.demoUserControl1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(24, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 120);
            this.sbMessage.SetStatusBarText(this.panel2, "A panel control");
            this.panel2.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 22);
            this.textBox2.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(24, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(392, 40);
            this.label9.TabIndex = 0;
            this.label9.Text = "Like the group box, if controls in a panel do not have status bar text, the text " +
                "for the panel is displayed.";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lvListView);
            this.tabPage1.Controls.Add(this.lbListBox);
            this.tabPage1.Controls.Add(this.lnkLabel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtpDateTime);
            this.tabPage1.Controls.Add(this.dataGrid1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cboComboBox);
            this.tabPage1.Controls.Add(this.lbCheckedLB);
            this.tabPage1.Controls.Add(this.chkTest);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.udDomain);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(608, 363);
            this.sbMessage.SetStatusBarText(this.tabPage1, "Tab page #1");
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tab 1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numeric Up/Down";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(248, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date/Time Picker";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Combo Box";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(248, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Domain Up/Down";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.propertyGrid1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(608, 363);
            this.sbMessage.SetStatusBarText(this.tabPage2, "Tab page #2");
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tab 2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(28, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 216);
            this.panel1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.tvTree);
            this.tabPage3.Controls.Add(this.trackBar1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(608, 363);
            this.sbMessage.SetStatusBarText(this.tabPage3, "Tab page #3");
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tab 3";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(52, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 56);
            this.label7.TabIndex = 1;
            this.label7.Text = "The tree view uses an AfterSelect event to update its status bar text as each nod" +
                "e is selected.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(336, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 152);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A Group Box";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 40);
            this.label6.TabIndex = 2;
            this.label6.Text = "The radio buttons in this group box do have status bar text.";
            // 
            // tvTree
            // 
            this.tvTree.Location = new System.Drawing.Point(52, 136);
            this.tvTree.Name = "tvTree";
            treeNode1.Name = "";
            treeNode1.Text = "Node2";
            treeNode2.Name = "";
            treeNode2.Text = "Node3";
            treeNode3.Name = "";
            treeNode3.Text = "Node4";
            treeNode4.Name = "";
            treeNode4.Text = "Node1";
            treeNode5.Name = "";
            treeNode5.Text = "Node5";
            treeNode6.Name = "";
            treeNode6.Text = "Node0";
            this.tvTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.tvTree.Size = new System.Drawing.Size(248, 208);
            this.tvTree.TabIndex = 2;
            this.tvTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTree_AfterSelect);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ucDemo);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.demoUserControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(608, 363);
            this.sbMessage.SetStatusBarText(this.tabPage4, "Tab page #4");
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tab 4";
            // 
            // ucDemo
            // 
            this.ucDemo.Location = new System.Drawing.Point(24, 248);
            this.ucDemo.Name = "ucDemo";
            this.ucDemo.Size = new System.Drawing.Size(336, 96);
            this.ucDemo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(32, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(360, 40);
            this.label8.TabIndex = 1;
            this.label8.Text = "This is a custom user control with status bar text defined by this form";
            // 
            // tabDemo
            // 
            this.tabDemo.Controls.Add(this.tabPage1);
            this.tabDemo.Controls.Add(this.tabPage2);
            this.tabDemo.Controls.Add(this.tabPage3);
            this.tabDemo.Controls.Add(this.tabPage4);
            this.tabDemo.Location = new System.Drawing.Point(8, 8);
            this.tabDemo.Name = "tabDemo";
            this.tabDemo.SelectedIndex = 0;
            this.sbMessage.SetShowAsBlank(this.tabDemo, true);
            this.tabDemo.Size = new System.Drawing.Size(616, 392);
            this.tabDemo.TabIndex = 0;
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(322, 408);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(96, 32);
            this.sbMessage.SetStatusBarText(this.btnProgress, "Utilize the status strip progress bar");
            this.btnProgress.TabIndex = 2;
            this.btnProgress.Text = "&Progress";
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // sbDialog
            // 
            this.sbDialog.Location = new System.Drawing.Point(0, 456);
            this.sbDialog.Name = "sbDialog";
            this.sbDialog.Size = new System.Drawing.Size(632, 22);
            this.sbDialog.SizingGrip = false;
            this.sbDialog.TabIndex = 4;
            this.sbDialog.Text = "Dialog status bar";
            // 
            // Form2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(632, 478);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.chkUseDialog);
            this.Controls.Add(this.sbDialog);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabDemo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Control Demo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabDemo.ResumeLayout(false);
            this.ResumeLayout(false);

        }
		#endregion

        /// <summary>
        /// Close the dialog box
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event arguments</param>
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Switch between the application status bar and this form's
        /// status bar for displaying the messages.
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event arguments</param>
        private void chkUseDialog_CheckedChanged(object sender, System.EventArgs e)
        {
            if(chkUseDialog.Checked)
            {
                sbMessage.InstanceStatusBar = sbDialog;
                ucDemo.StatusBarTextProvider.InstanceStatusBar = sbDialog;

                // Make the instance default text the same for any nested
                // status bar text providers.  If not, they pick up the
                // status bar text of the current control as the default.
                ucDemo.StatusBarTextProvider.InstanceDefaultText =
                    sbMessage.InstanceDefaultText;
            }
            else
            {
                sbMessage.InstanceStatusBar = null;
                ucDemo.StatusBarTextProvider.InstanceStatusBar = null;
            }
        }

        /// <summary>
        /// Change the status bar text to show info about the selected node
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event argumnents</param>
        private void tvTree_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            sbMessage.SetStatusBarText(tvTree, "Selected Node: " +
                e.Node.Text);
        }

        /// <summary>
        /// Utilize the status strip label and progress bar via the status bar
        /// text provider.
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event argumnents</param>
        private void btnProgress_Click(object sender, EventArgs e)
        {
            StatusBarTextProvider.InitializeProgressBar(100);

            for(int i = 0; i < 100; i++)
            {
                StatusBarTextProvider.UpdateProgress(i + 1,
                    String.Format("Step #{0}", i + 1));

                System.Threading.Thread.Sleep(25);
            }

            StatusBarTextProvider.ResetProgressBar();
        }
    }

    /// <summary>
    /// A simple data source for the data grid
    /// </summary>
    public class ListItem
    {
        private int index;
        private string description;

        public int Index
        {
            get { return index; }
        }

        public string Description
        {
            get { return description; }
        }

        public ListItem(int idx, string desc)
        {
            index = idx;
            description = desc;
        }
    }
}
