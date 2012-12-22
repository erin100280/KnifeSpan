/* User: Erin
 * Date: 12/14/2012
 * Time: 9:25 AM
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KnifeSpan.forms {
	/// <summary>
	/// Description of StatusForm.
	/// </summary>
	public partial class StatusForm : Form {
		public bool cancelNow=false;
		public MainForm mainForm;
		
		public StatusForm() { Init(null); }
		public StatusForm(MainForm mainForm) { Init(mainForm); }
		private void Init(MainForm mainForm) {
			InitializeComponent();
			this.mainForm=mainForm;
			this.KeyDown += new KeyEventHandler(formKeyDown);
			this.btnClose.KeyDown += new KeyEventHandler(formKeyDown);
		}

		void formKeyDown(object sender, KeyEventArgs e) {
			//this.Text=("e.KeyCode="+e.KeyCode+" - e.KeyValue="+e.KeyValue+" - e.KeyData="+e.KeyData);
			BtnCloseClick(this, new EventArgs());
		}
		void BtnCloseClick(object sender, EventArgs e) {
			if(this.btnClose.Text=="Close") {
				mainForm.tabControlMain.Enabled=true;
				mainForm.Show();
				this.Dispose();
			}
			else {
				this.cancelNow=true;
			}
		}

	}
}
