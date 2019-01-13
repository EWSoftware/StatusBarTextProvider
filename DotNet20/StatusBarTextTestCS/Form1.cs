using System;
using System.Drawing;
using System.Windows.Forms;

using EWSoftware.StatusBarText;

namespace StatusBarTextTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private EWSoftware.StatusBarText.StatusBarTextProvider sbMessage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripMenuItem maximizeToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem blankStatusTextOnThisOneToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tslStatusText;
        private ToolStripStatusLabel tslProgressNote;
        private ToolStripProgressBar tspbProgressBar;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem test1ToolStripMenuItem;
        private ToolStripMenuItem test2ToolStripMenuItem;
        private ToolStripMenuItem test3ToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem test1ToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem test2ToolStripMenuItem1;
        private ToolStripMenuItem test3ToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripTextBox toolStripTextBox1;
        private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            // Tell the StatusBarTextProvider component the component
            // to use to display the text.  When using a tool strip
            // component, the ApplicationDisplayPanel property is ignored.
            StatusBarTextProvider.ApplicationStatusBar = tslStatusText;

            // Define the status label and progress bar too.  This allows
            // easy access to those items from anywhere within the
            // application.
            StatusBarTextProvider.StatusLabel = tslProgressNote;
            StatusBarTextProvider.ProgressBar = tspbProgressBar;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sbMessage = new EWSoftware.StatusBarText.StatusBarTextProvider(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.blankStatusTextOnThisOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.test1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.test3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tslProgressNote = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.sbMessage.SetStatusBarText(this.fileToolStripMenuItem, "File related commands");
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.sbMessage.SetStatusBarText(this.loadToolStripMenuItem, "Load a file of some sort");
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.sbMessage.SetStatusBarText(this.saveToolStripMenuItem, "Save a file of some sort");
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.sbMessage.SetStatusBarText(this.exitToolStripMenuItem, "Exit the application");
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.listToolStripMenuItem,
            this.minimizeToolStripMenuItem,
            this.maximizeToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.sbMessage.SetStatusBarText(this.windowToolStripMenuItem, "Window related commands");
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sbMessage.SetStatusBarText(this.newToolStripMenuItem, "Open a new window");
            this.newToolStripMenuItem.Text = "&New";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sbMessage.SetStatusBarText(this.listToolStripMenuItem, "View the window list");
            this.listToolStripMenuItem.Text = "&List";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sbMessage.SetStatusBarText(this.minimizeToolStripMenuItem, "Minimize the window");
            this.minimizeToolStripMenuItem.Text = "&Minimize";
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sbMessage.SetStatusBarText(this.maximizeToolStripMenuItem, "Maximize the window");
            this.maximizeToolStripMenuItem.Text = "M&aximize";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.blankStatusTextOnThisOneToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.sbMessage.SetShowAsBlank(this.helpToolStripMenuItem, true);
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.sbMessage.SetStatusBarText(this.aboutToolStripMenuItem, "View copyright and contact information");
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(254, 6);
            // 
            // blankStatusTextOnThisOneToolStripMenuItem
            // 
            this.blankStatusTextOnThisOneToolStripMenuItem.Name = "blankStatusTextOnThisOneToolStripMenuItem";
            this.sbMessage.SetShowAsBlank(this.blankStatusTextOnThisOneToolStripMenuItem, true);
            this.blankStatusTextOnThisOneToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.blankStatusTextOnThisOneToolStripMenuItem.Text = "&Blank status text on this one";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.sbMessage.SetStatusBarText(this.toolStripButton1, "A toolstrip button");
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 23);
            this.sbMessage.SetStatusBarText(this.toolStripLabel1, "A toolstrip label");
            this.toolStripLabel1.Text = "Enter Text";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem,
            this.test3ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 23);
            this.sbMessage.SetStatusBarText(this.toolStripSplitButton1, "A toolstrip split button");
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sbMessage.SetStatusBarText(this.test1ToolStripMenuItem, "Split dropdown button item #1");
            this.test1ToolStripMenuItem.Text = "Test 1";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sbMessage.SetStatusBarText(this.test2ToolStripMenuItem, "Split dropdown button item #2");
            this.test2ToolStripMenuItem.Text = "Test 2";
            // 
            // test3ToolStripMenuItem
            // 
            this.test3ToolStripMenuItem.Name = "test3ToolStripMenuItem";
            this.test3ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sbMessage.SetStatusBarText(this.test3ToolStripMenuItem, "Split dropdown button item #3");
            this.test3ToolStripMenuItem.Text = "Test 3";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem1,
            this.test2ToolStripMenuItem1,
            this.test3ToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 23);
            this.sbMessage.SetStatusBarText(this.toolStripDropDownButton1, "A toolstrip dropdown button");
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // test1ToolStripMenuItem1
            // 
            this.test1ToolStripMenuItem1.Name = "test1ToolStripMenuItem1";
            this.test1ToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.sbMessage.SetStatusBarText(this.test1ToolStripMenuItem1, "Dropdown button item #1");
            this.test1ToolStripMenuItem1.Text = "Test 1";
            // 
            // test2ToolStripMenuItem1
            // 
            this.test2ToolStripMenuItem1.Name = "test2ToolStripMenuItem1";
            this.test2ToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.sbMessage.SetStatusBarText(this.test2ToolStripMenuItem1, "Dropdown button item #2");
            this.test2ToolStripMenuItem1.Text = "Test 2";
            // 
            // test3ToolStripMenuItem1
            // 
            this.test3ToolStripMenuItem1.Name = "test3ToolStripMenuItem1";
            this.test3ToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.sbMessage.SetStatusBarText(this.test3ToolStripMenuItem1, "Dropdown button item #3");
            this.test3ToolStripMenuItem1.Text = "Test 3";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Item #1",
            "Item #2",
            "Item #3",
            "Item #4"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 26);
            this.sbMessage.SetStatusBarText(this.toolStripComboBox1, "A toolstrip combo box");
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 26);
            this.sbMessage.SetStatusBarText(this.toolStripTextBox1, "A toolstrip text box");
            this.toolStripTextBox1.Text = "Toolstrip text box";
            // 
            // tslProgressNote
            // 
            this.tslProgressNote.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tslProgressNote.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tslProgressNote.Margin = new System.Windows.Forms.Padding(0);
            this.tslProgressNote.Name = "tslProgressNote";
            this.tslProgressNote.Size = new System.Drawing.Size(4, 27);
            this.sbMessage.SetStatusBarText(this.tslProgressNote, "Progress message");
            this.tslProgressNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tspbProgressBar
            // 
            this.tspbProgressBar.Name = "tspbProgressBar";
            this.tspbProgressBar.Size = new System.Drawing.Size(100, 21);
            this.sbMessage.SetStatusBarText(this.tspbProgressBar, "Progress bar");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslStatusText,
            this.tslProgressNote,
            this.tspbProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(816, 27);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(40, 27);
            this.toolStripStatusLabel1.Text = "Test";
            // 
            // tslStatusText
            // 
            this.tslStatusText.Name = "tslStatusText";
            this.tslStatusText.Size = new System.Drawing.Size(655, 22);
            this.tslStatusText.Spring = true;
            this.tslStatusText.Text = "Ready";
            this.tslStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripSplitButton1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripComboBox1,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(816, 26);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(816, 566);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "StatusBarTextProvider Demo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

        /// <summary>
        /// Show the test forms with a bunch of controls as an MDI child
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event arguments</param>
        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            Form2 mdiForm = new Form2();
            mdiForm.MdiParent = this;
            mdiForm.Show();
        }

        /// <summary>
        /// Show the test forms with a bunch of controls as a modal dialog
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event arguments</param>
        private void menuItem11_Click(object sender, System.EventArgs e)
        {
            using(Form2 dlg = new Form2())
            {
                dlg.ShowDialog();
            }
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event arguments</param>
        private void menuItem4_Click(object sender, System.EventArgs e)
        {
            this.Close();        
        }
	}
}
