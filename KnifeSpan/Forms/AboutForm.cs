/* User: Erin
 * Date: 12/14/2012
 * Time: 9:24 AM
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KnifeSpan.forms {
	/// <summary>
	/// Description of About.
	/// </summary>
	public partial class AboutForm : Form {
		public AboutForm() {
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
