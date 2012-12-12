/* User: Erin
 * Date: 12/12/2012
 * Time: 3:43 AM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KnifeSpan {
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();

		}
		
		void MenuItemMainFileExitClick(object sender, EventArgs e) {
			Application.Exit();
		}
		
		void ButtonMainSplittingBrowseinputfileClick(object sender, EventArgs e) {
			openFileDialogMainSplittingInputfile.FileName="";
			DialogResult dr=openFileDialogMainSplittingInputfile.ShowDialog();
			if(openFileDialogMainSplittingInputfile.FileName!="")
				textBoxMainSplittingInputFile.Text=openFileDialogMainSplittingInputfile.FileName;
		}
		
		void ButtonMainSplittingBrowseoutputdirClick(object sender, EventArgs e) {
			DialogResult dr=folderBrowserDialogMainSplittingOutputdir.ShowDialog();
			if(folderBrowserDialogMainSplittingOutputdir.SelectedPath!="")
				textBoxMainSplittingOutputdir.Text=folderBrowserDialogMainSplittingOutputdir.SelectedPath;
		}
		
		void ButtonMainSplittingSplitNowClick(object sender, EventArgs e) {
			long nudVal=Convert.ToUInt32(numericUpDownMainSplittingChunksize.Value);
			long cSize=KsSplitter.GetSizeInBytes(nudVal, comboBoxMainSplittingChunksizetype.Text);
			KsSplitter.SplitFile(textBoxMainSplittingInputFile.Text, textBoxMainSplittingOutputdir.Text, cSize);
			MessageBox.Show("Splitting Done");
		}
		
		void ButtonMainJoiningModeManualBrowseinputchunkClick(object sender, EventArgs e) {
			openFileDialogMainJoiningModeManualBrowseinputchunk.FileName="";
			DialogResult dr=openFileDialogMainJoiningModeManualBrowseinputchunk.ShowDialog();
			if(dr!=DialogResult.Cancel)
				textBoxMainJoiningModeManualInputchunk.Text=openFileDialogMainJoiningModeManualBrowseinputchunk.FileName;
		}
		
		void ButtonMainJoiningModeManualBrowseoutputfileClick(object sender, EventArgs e) {
			saveFileDialogMainJoiningModeManualBrowseoutputfile.FileName="";
			DialogResult dr=saveFileDialogMainJoiningModeManualBrowseoutputfile.ShowDialog();
			if(dr!=DialogResult.Cancel)
				textBoxMainJoiningModeManualOutputfile.Text=saveFileDialogMainJoiningModeManualBrowseoutputfile.FileName;
		}
		
		void ButtonMainJoiningModeManualJoinnowClick(object sender, EventArgs e) {
			KsJoiner.JoinFile(textBoxMainJoiningModeManualInputchunk.Text, textBoxMainJoiningModeManualOutputfile.Text);
			MessageBox.Show("Joining Done");
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			tabControlMainJoiningMode.SelectedIndex=1;			
		}
	}
}
