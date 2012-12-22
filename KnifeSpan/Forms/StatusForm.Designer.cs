/* User: Erin
 * Date: 12/14/2012
 * Time: 9:25 AM
 */
namespace KnifeSpan.forms
{
	partial class StatusForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblMain = new System.Windows.Forms.Label();
			this.progressMain = new System.Windows.Forms.ProgressBar();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblMain
			// 
			this.lblMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblMain.Location = new System.Drawing.Point(12, 9);
			this.lblMain.Name = "lblMain";
			this.lblMain.Size = new System.Drawing.Size(494, 64);
			this.lblMain.TabIndex = 0;
			this.lblMain.Text = "Status";
			// 
			// progressMain
			// 
			this.progressMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.progressMain.Location = new System.Drawing.Point(12, 82);
			this.progressMain.Name = "progressMain";
			this.progressMain.Size = new System.Drawing.Size(418, 26);
			this.progressMain.Step = 1;
			this.progressMain.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(436, 82);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(70, 26);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Cancel";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// StatusForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 120);
			this.ControlBox = false;
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.progressMain);
			this.Controls.Add(this.lblMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "StatusForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Status....";
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.Button btnClose;
		public System.Windows.Forms.ProgressBar progressMain;
		public System.Windows.Forms.Label lblMain;
	}
}
