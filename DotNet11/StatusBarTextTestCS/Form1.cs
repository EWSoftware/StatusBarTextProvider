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
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.StatusBar sbStatusBar;
        private System.Windows.Forms.StatusBarPanel sbTextPanel;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.StatusBarPanel gripSpacer;
        private System.Windows.Forms.StatusBarPanel statusBarPanel2;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            // Tell the StatusBarTextProvider component the status bar to use
            StatusBarTextProvider.ApplicationStatusBar = sbStatusBar;

            // You can also use any panel you like.  The default is zero
            // (the left-most panel).  For the demo, we'll use the one
            // in the middle.
            StatusBarTextProvider.ApplicationDisplayPanel = 1;
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
            this.sbMessage = new EWSoftware.StatusBarText.StatusBarTextProvider(this.components);
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.sbStatusBar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.sbTextPanel = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.gripSpacer = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTextPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gripSpacer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.sbMessage.SetStatusBarText(this.menuItem2, "Load a file of some sort");
            this.menuItem2.Text = "&Load";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.sbMessage.SetStatusBarText(this.menuItem3, "Save a file of some sort");
            this.menuItem3.Text = "&Save";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.sbMessage.SetStatusBarText(this.menuItem4, "Exit the application");
            this.menuItem4.Text = "&Exit";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.sbMessage.SetStatusBarText(this.menuItem6, "Open a new window");
            this.menuItem6.Text = "&New";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.sbMessage.SetStatusBarText(this.menuItem7, "View the window list");
            this.menuItem7.Text = "&List";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.sbMessage.SetStatusBarText(this.menuItem8, "Minimize the window");
            this.menuItem8.Text = "&Minimize";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.sbMessage.SetStatusBarText(this.menuItem9, "Maximize the window");
            this.menuItem9.Text = "M&aximize";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.sbMessage.SetStatusBarText(this.menuItem11, "View copyright and contact information");
            this.menuItem11.Text = "&About";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 2;
            this.sbMessage.SetShowAsBlank(this.menuItem13, true);
            this.menuItem13.Text = "&Blank status text on this one";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.menuItem2,
                                                                                      this.menuItem3,
                                                                                      this.menuItem4});
            this.sbMessage.SetStatusBarText(this.menuItem1, "File related commands");
            this.menuItem1.Text = "&File";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.menuItem6,
                                                                                      this.menuItem7,
                                                                                      this.menuItem8,
                                                                                      this.menuItem9});
            this.sbMessage.SetStatusBarText(this.menuItem5, "Window related commands");
            this.menuItem5.Text = "&Window";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 2;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                       this.menuItem11,
                                                                                       this.menuItem12,
                                                                                       this.menuItem13});
            this.sbMessage.SetShowAsBlank(this.menuItem10, true);
            this.menuItem10.Text = "&Help";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 1;
            this.menuItem12.Text = "-";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.menuItem1,
                                                                                      this.menuItem5,
                                                                                      this.menuItem10});
            // 
            // sbStatusBar
            // 
            this.sbStatusBar.Location = new System.Drawing.Point(0, 513);
            this.sbStatusBar.Name = "sbStatusBar";
            this.sbStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
                                                                                           this.statusBarPanel2,
                                                                                           this.sbTextPanel,
                                                                                           this.statusBarPanel1,
                                                                                           this.gripSpacer});
            this.sbStatusBar.ShowPanels = true;
            this.sbStatusBar.Size = new System.Drawing.Size(816, 22);
            this.sbStatusBar.TabIndex = 0;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanel2.Text = "Test";
            this.statusBarPanel2.Width = 41;
            // 
            // sbTextPanel
            // 
            this.sbTextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.sbTextPanel.Text = "Ready";
            this.sbTextPanel.Width = 708;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanel1.Text = "Test";
            this.statusBarPanel1.Width = 41;
            // 
            // gripSpacer
            // 
            this.gripSpacer.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.gripSpacer.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.gripSpacer.Width = 10;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(816, 535);
            this.Controls.Add(this.sbStatusBar);
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "StatusBarTextProvider Demo";
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTextPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gripSpacer)).EndInit();
            this.ResumeLayout(false);

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
