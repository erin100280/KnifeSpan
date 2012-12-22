/* User: Erin
 * Date: 12/12/2012
 * Time: 3:43 AM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using KnifeSpan.forms;

namespace KnifeSpan {
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public class joinHandler : KsSplitJoinHandler {
		public MainForm mainForm=null;
		public StatusForm statusForm=null;
		public string modeStr="Joining";
		
		public joinHandler() {}
		public joinHandler(MainForm mFrm, StatusForm sFrm) {
			mainForm=mFrm;
			statusForm=sFrm;
		}
		public joinHandler(MainForm mFrm, StatusForm sFrm, string modeStr) {
			this.mainForm=mFrm;
			this.statusForm=sFrm;
			this.modeStr=modeStr;
		}
		public joinHandler(string modeStr) {
			this.modeStr=modeStr;
		}

		public override bool OnUpdate(string srcFile, string tgtFile, long curPos, long total, int chunkNum, int chunkCount) {
			bool rv=!statusForm.cancelNow;
			
			if(statusForm!=null) {
				ProgressBar pb=statusForm.progressMain;
				Label lbl=statusForm.lblMain;
				Button btn=statusForm.btnClose;
				
				string lblVal=this.modeStr+": \""+srcFile+"\" \nto: \""+tgtFile+"\".";
				if(chunkNum!=-20) lblVal=("chunk: "+chunkNum+" of "+chunkCount)+lblVal;
				if(lbl.Text!=lblVal) lbl.Text=lblVal;
				
				long ttl=total/100;
				long num=curPos/ttl;
				if(pb.Maximum!=100) pb.Maximum=100;
				pb.Value=(int) num;
			}
			Application.DoEvents();

			return rv;
		}
		public override void OnCanceled(string srcFile, string tgtFile, long curPos, long total, int chunkNum, int chunkCount) {
			if((this.modeStr=="Joining") && (new FileInfo(tgtFile).Exists)) {
				FileStream fs=new FileStream(tgtFile, FileMode.Truncate);
				fs.Close();
			}
			if(chunkNum==-20) {
				statusForm.lblMain.Text="Canceled";
				statusForm.btnClose.Text="Close";
			}
		}
		public override void OnFinished(string srcFile, string tgtFile, long curPos, long total, int chunkNum, int chunkCount) {
			if(chunkNum==-20) {
				statusForm.progressMain.Value=statusForm.progressMain.Maximum;
				statusForm.lblMain.Text="Done";
				statusForm.btnClose.Text="Close";
			}
		}
	}

	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
			this.MaximumSize=new Size(2000, this.Height);
			this.MinimumSize=new Size(120, this.Height);
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

			StatusForm statForm=new StatusForm(this);
			joinHandler sh=new joinHandler(this, statForm);
			tabControlMain.Enabled=false;
			statForm.Show(this);
			KsSplitter.SplitFile(textBoxMainSplittingInputFile.Text, textBoxMainSplittingOutputdir.Text, cSize, sh);
			//KsJoiner.JoinFile(textBoxMainJoiningModeManualInputchunk.Text, textBoxMainJoiningModeManualOutputfile.Text, jh);
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
			StatusForm statForm=new StatusForm(this);
			joinHandler jh=new joinHandler(this, statForm);
			tabControlMain.Enabled=false;
			statForm.Show(this);
			KsJoiner.JoinFile(textBoxMainJoiningModeManualInputchunk.Text, textBoxMainJoiningModeManualOutputfile.Text, jh);
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			tabControlMainJoiningMode.SelectedIndex=1;			
		}
		
		void MenuItemMainHelpAboutClick(object sender, EventArgs e)
		{
			AboutForm af=new AboutForm();
			af.ShowDialog(this);
			af.Dispose();
		}
	}
}
