using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using EWSoftware.StatusBarText;

namespace StatusBarTextTest
{
	/// <summary>
	/// Summary description for UserControlWithProvider.
	/// </summary>
	public class UserControlWithProvider : System.Windows.Forms.UserControl
	{
        private EWSoftware.StatusBarText.StatusBarTextProvider sbMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.IContainer components;

		public UserControlWithProvider()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.sbMessage = new EWSoftware.StatusBarText.StatusBarTextProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "User controls can contain their own status bar text provider as well.";
            // 
            // button1
            // 
            this.sbMessage.SetStatusBarText(this.button1, "Button in a user control");
            this.button1.Location = new System.Drawing.Point(212, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            // 
            // textBox1
            // 
            this.sbMessage.SetStatusBarText(this.textBox1, "Text box in a user control");
            this.textBox1.Location = new System.Drawing.Point(108, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "";
            // 
            // UserControlWithProvider
            // 
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserControlWithProvider";
            this.Size = new System.Drawing.Size(344, 96);
            this.ResumeLayout(false);

        }
		#endregion

        /// <summary>
        /// The status bar text provider is exposed so that the parent can
        /// make adjustments to it.
        /// </summary>
        public StatusBarTextProvider StatusBarTextProvider
        {
            get { return sbMessage; }
        }
	}
}
