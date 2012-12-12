/* User: Erin
 * Date: 12/12/2012
 * Time: 3:43 AM
 */
namespace KnifeSpan
{
	partial class MainForm
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
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.menuItemMainFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemMainFileOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSeparatorMainFile01 = new System.Windows.Forms.ToolStripSeparator();
			this.menuItemMainFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemMainHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemMainHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageMainSplitting = new System.Windows.Forms.TabPage();
			this.numericUpDownMainSplittingChunksize = new System.Windows.Forms.NumericUpDown();
			this.buttonMainSplittingSplitNow = new System.Windows.Forms.Button();
			this.buttonMainSplittingBrowseoutputdir = new System.Windows.Forms.Button();
			this.comboBoxMainSplittingChunksizetype = new System.Windows.Forms.ComboBox();
			this.labelMainSplittingChunksize = new System.Windows.Forms.Label();
			this.textBoxMainSplittingOutputdir = new System.Windows.Forms.TextBox();
			this.buttonMainSplittingBrowseinputfile = new System.Windows.Forms.Button();
			this.textBoxMainSplittingInputFile = new System.Windows.Forms.TextBox();
			this.labelMainSplittingOutputDir = new System.Windows.Forms.Label();
			this.labelMainSplittingInputfile = new System.Windows.Forms.Label();
			this.tabPageMainJoining = new System.Windows.Forms.TabPage();
			this.tabControlMainJoiningMode = new System.Windows.Forms.TabControl();
			this.tabPageMainJoiningModeAuto = new System.Windows.Forms.TabPage();
			this.tabPageMainJoiningModeManual = new System.Windows.Forms.TabPage();
			this.buttonMainJoiningModeManualJoinnow = new System.Windows.Forms.Button();
			this.buttonMainJoiningModeManualBrowseoutputfile = new System.Windows.Forms.Button();
			this.textBoxMainJoiningModeManualOutputfile = new System.Windows.Forms.TextBox();
			this.labelMainJoiningModeManualOutputfile = new System.Windows.Forms.Label();
			this.buttonMainJoiningModeManualBrowseinputchunk = new System.Windows.Forms.Button();
			this.textBoxMainJoiningModeManualInputchunk = new System.Windows.Forms.TextBox();
			this.labelMainJoiningModeManualInputchunk = new System.Windows.Forms.Label();
			this.openFileDialogMainSplittingInputfile = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialogMainSplittingOutputdir = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialogMainJoiningModeManualBrowseinputchunk = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialogMainJoiningModeManualBrowseoutputfile = new System.Windows.Forms.SaveFileDialog();
			this.menuStripMain.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabPageMainSplitting.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMainSplittingChunksize)).BeginInit();
			this.tabPageMainJoining.SuspendLayout();
			this.tabControlMainJoiningMode.SuspendLayout();
			this.tabPageMainJoiningModeManual.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.menuItemMainFile,
									this.menuItemMainHelp});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(738, 24);
			this.menuStripMain.TabIndex = 0;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// menuItemMainFile
			// 
			this.menuItemMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.menuItemMainFileOptions,
									this.menuSeparatorMainFile01,
									this.menuItemMainFileExit});
			this.menuItemMainFile.Name = "menuItemMainFile";
			this.menuItemMainFile.Size = new System.Drawing.Size(35, 20);
			this.menuItemMainFile.Text = "&File";
			// 
			// menuItemMainFileOptions
			// 
			this.menuItemMainFileOptions.Name = "menuItemMainFileOptions";
			this.menuItemMainFileOptions.Size = new System.Drawing.Size(122, 22);
			this.menuItemMainFileOptions.Text = "&Options";
			// 
			// menuSeparatorMainFile01
			// 
			this.menuSeparatorMainFile01.Name = "menuSeparatorMainFile01";
			this.menuSeparatorMainFile01.Size = new System.Drawing.Size(119, 6);
			// 
			// menuItemMainFileExit
			// 
			this.menuItemMainFileExit.Name = "menuItemMainFileExit";
			this.menuItemMainFileExit.Size = new System.Drawing.Size(122, 22);
			this.menuItemMainFileExit.Text = "E&xit";
			this.menuItemMainFileExit.Click += new System.EventHandler(this.MenuItemMainFileExitClick);
			// 
			// menuItemMainHelp
			// 
			this.menuItemMainHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.menuItemMainHelpAbout});
			this.menuItemMainHelp.Name = "menuItemMainHelp";
			this.menuItemMainHelp.Size = new System.Drawing.Size(40, 20);
			this.menuItemMainHelp.Text = "&Help";
			// 
			// menuItemMainHelpAbout
			// 
			this.menuItemMainHelpAbout.Name = "menuItemMainHelpAbout";
			this.menuItemMainHelpAbout.Size = new System.Drawing.Size(114, 22);
			this.menuItemMainHelpAbout.Text = "&About";
			// 
			// tabControlMain
			// 
			this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlMain.Controls.Add(this.tabPageMainSplitting);
			this.tabControlMain.Controls.Add(this.tabPageMainJoining);
			this.tabControlMain.Location = new System.Drawing.Point(12, 38);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(714, 203);
			this.tabControlMain.TabIndex = 1;
			// 
			// tabPageMainSplitting
			// 
			this.tabPageMainSplitting.BackColor = System.Drawing.Color.Transparent;
			this.tabPageMainSplitting.Controls.Add(this.numericUpDownMainSplittingChunksize);
			this.tabPageMainSplitting.Controls.Add(this.buttonMainSplittingSplitNow);
			this.tabPageMainSplitting.Controls.Add(this.buttonMainSplittingBrowseoutputdir);
			this.tabPageMainSplitting.Controls.Add(this.comboBoxMainSplittingChunksizetype);
			this.tabPageMainSplitting.Controls.Add(this.labelMainSplittingChunksize);
			this.tabPageMainSplitting.Controls.Add(this.textBoxMainSplittingOutputdir);
			this.tabPageMainSplitting.Controls.Add(this.buttonMainSplittingBrowseinputfile);
			this.tabPageMainSplitting.Controls.Add(this.textBoxMainSplittingInputFile);
			this.tabPageMainSplitting.Controls.Add(this.labelMainSplittingOutputDir);
			this.tabPageMainSplitting.Controls.Add(this.labelMainSplittingInputfile);
			this.tabPageMainSplitting.Location = new System.Drawing.Point(4, 22);
			this.tabPageMainSplitting.Name = "tabPageMainSplitting";
			this.tabPageMainSplitting.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMainSplitting.Size = new System.Drawing.Size(706, 177);
			this.tabPageMainSplitting.TabIndex = 0;
			this.tabPageMainSplitting.Text = "Splitting";
			// 
			// numericUpDownMainSplittingChunksize
			// 
			this.numericUpDownMainSplittingChunksize.Location = new System.Drawing.Point(112, 76);
			this.numericUpDownMainSplittingChunksize.Maximum = new decimal(new int[] {
									1000000,
									0,
									0,
									0});
			this.numericUpDownMainSplittingChunksize.Name = "numericUpDownMainSplittingChunksize";
			this.numericUpDownMainSplittingChunksize.Size = new System.Drawing.Size(57, 20);
			this.numericUpDownMainSplittingChunksize.TabIndex = 11;
			this.numericUpDownMainSplittingChunksize.Value = new decimal(new int[] {
									200,
									0,
									0,
									0});
			// 
			// buttonMainSplittingSplitNow
			// 
			this.buttonMainSplittingSplitNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMainSplittingSplitNow.Location = new System.Drawing.Point(624, 145);
			this.buttonMainSplittingSplitNow.Name = "buttonMainSplittingSplitNow";
			this.buttonMainSplittingSplitNow.Size = new System.Drawing.Size(76, 26);
			this.buttonMainSplittingSplitNow.TabIndex = 10;
			this.buttonMainSplittingSplitNow.Text = "Split Now";
			this.buttonMainSplittingSplitNow.UseVisualStyleBackColor = true;
			this.buttonMainSplittingSplitNow.Click += new System.EventHandler(this.ButtonMainSplittingSplitNowClick);
			// 
			// buttonMainSplittingBrowseoutputdir
			// 
			this.buttonMainSplittingBrowseoutputdir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMainSplittingBrowseoutputdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMainSplittingBrowseoutputdir.Location = new System.Drawing.Point(662, 50);
			this.buttonMainSplittingBrowseoutputdir.Name = "buttonMainSplittingBrowseoutputdir";
			this.buttonMainSplittingBrowseoutputdir.Size = new System.Drawing.Size(38, 20);
			this.buttonMainSplittingBrowseoutputdir.TabIndex = 9;
			this.buttonMainSplittingBrowseoutputdir.Text = "....";
			this.buttonMainSplittingBrowseoutputdir.UseVisualStyleBackColor = true;
			this.buttonMainSplittingBrowseoutputdir.Click += new System.EventHandler(this.ButtonMainSplittingBrowseoutputdirClick);
			// 
			// comboBoxMainSplittingChunksizetype
			// 
			this.comboBoxMainSplittingChunksizetype.FormattingEnabled = true;
			this.comboBoxMainSplittingChunksizetype.Items.AddRange(new object[] {
									"bytes",
									"kb",
									"mb",
									"gb"});
			this.comboBoxMainSplittingChunksizetype.Location = new System.Drawing.Point(175, 76);
			this.comboBoxMainSplittingChunksizetype.Name = "comboBoxMainSplittingChunksizetype";
			this.comboBoxMainSplittingChunksizetype.Size = new System.Drawing.Size(60, 21);
			this.comboBoxMainSplittingChunksizetype.TabIndex = 8;
			this.comboBoxMainSplittingChunksizetype.Text = "mb";
			// 
			// labelMainSplittingChunksize
			// 
			this.labelMainSplittingChunksize.AutoSize = true;
			this.labelMainSplittingChunksize.Location = new System.Drawing.Point(42, 79);
			this.labelMainSplittingChunksize.Name = "labelMainSplittingChunksize";
			this.labelMainSplittingChunksize.Size = new System.Drawing.Size(64, 13);
			this.labelMainSplittingChunksize.TabIndex = 6;
			this.labelMainSplittingChunksize.Text = "Chunk Size:";
			// 
			// textBoxMainSplittingOutputdir
			// 
			this.textBoxMainSplittingOutputdir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxMainSplittingOutputdir.Location = new System.Drawing.Point(112, 50);
			this.textBoxMainSplittingOutputdir.Name = "textBoxMainSplittingOutputdir";
			this.textBoxMainSplittingOutputdir.Size = new System.Drawing.Size(544, 20);
			this.textBoxMainSplittingOutputdir.TabIndex = 4;
			// 
			// buttonMainSplittingBrowseinputfile
			// 
			this.buttonMainSplittingBrowseinputfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMainSplittingBrowseinputfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMainSplittingBrowseinputfile.Location = new System.Drawing.Point(662, 24);
			this.buttonMainSplittingBrowseinputfile.Name = "buttonMainSplittingBrowseinputfile";
			this.buttonMainSplittingBrowseinputfile.Size = new System.Drawing.Size(38, 20);
			this.buttonMainSplittingBrowseinputfile.TabIndex = 3;
			this.buttonMainSplittingBrowseinputfile.Text = "....";
			this.buttonMainSplittingBrowseinputfile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonMainSplittingBrowseinputfile.UseVisualStyleBackColor = true;
			this.buttonMainSplittingBrowseinputfile.Click += new System.EventHandler(this.ButtonMainSplittingBrowseinputfileClick);
			// 
			// textBoxMainSplittingInputFile
			// 
			this.textBoxMainSplittingInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxMainSplittingInputFile.Location = new System.Drawing.Point(112, 24);
			this.textBoxMainSplittingInputFile.Name = "textBoxMainSplittingInputFile";
			this.textBoxMainSplittingInputFile.Size = new System.Drawing.Size(544, 20);
			this.textBoxMainSplittingInputFile.TabIndex = 2;
			// 
			// labelMainSplittingOutputDir
			// 
			this.labelMainSplittingOutputDir.AutoSize = true;
			this.labelMainSplittingOutputDir.Location = new System.Drawing.Point(19, 53);
			this.labelMainSplittingOutputDir.Name = "labelMainSplittingOutputDir";
			this.labelMainSplittingOutputDir.Size = new System.Drawing.Size(87, 13);
			this.labelMainSplittingOutputDir.TabIndex = 1;
			this.labelMainSplittingOutputDir.Text = "Output Directory:";
			// 
			// labelMainSplittingInputfile
			// 
			this.labelMainSplittingInputfile.AutoSize = true;
			this.labelMainSplittingInputfile.Location = new System.Drawing.Point(53, 28);
			this.labelMainSplittingInputfile.Name = "labelMainSplittingInputfile";
			this.labelMainSplittingInputfile.Size = new System.Drawing.Size(53, 13);
			this.labelMainSplittingInputfile.TabIndex = 0;
			this.labelMainSplittingInputfile.Text = "Input File:";
			// 
			// tabPageMainJoining
			// 
			this.tabPageMainJoining.BackColor = System.Drawing.Color.Transparent;
			this.tabPageMainJoining.Controls.Add(this.tabControlMainJoiningMode);
			this.tabPageMainJoining.Location = new System.Drawing.Point(4, 22);
			this.tabPageMainJoining.Name = "tabPageMainJoining";
			this.tabPageMainJoining.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMainJoining.Size = new System.Drawing.Size(706, 177);
			this.tabPageMainJoining.TabIndex = 1;
			this.tabPageMainJoining.Text = "Joining";
			// 
			// tabControlMainJoiningMode
			// 
			this.tabControlMainJoiningMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlMainJoiningMode.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControlMainJoiningMode.Controls.Add(this.tabPageMainJoiningModeAuto);
			this.tabControlMainJoiningMode.Controls.Add(this.tabPageMainJoiningModeManual);
			this.tabControlMainJoiningMode.Location = new System.Drawing.Point(6, 6);
			this.tabControlMainJoiningMode.Name = "tabControlMainJoiningMode";
			this.tabControlMainJoiningMode.SelectedIndex = 0;
			this.tabControlMainJoiningMode.Size = new System.Drawing.Size(694, 165);
			this.tabControlMainJoiningMode.TabIndex = 1;
			// 
			// tabPageMainJoiningModeAuto
			// 
			this.tabPageMainJoiningModeAuto.BackColor = System.Drawing.Color.Transparent;
			this.tabPageMainJoiningModeAuto.Location = new System.Drawing.Point(4, 25);
			this.tabPageMainJoiningModeAuto.Name = "tabPageMainJoiningModeAuto";
			this.tabPageMainJoiningModeAuto.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMainJoiningModeAuto.Size = new System.Drawing.Size(686, 136);
			this.tabPageMainJoiningModeAuto.TabIndex = 0;
			this.tabPageMainJoiningModeAuto.Text = "Auto";
			// 
			// tabPageMainJoiningModeManual
			// 
			this.tabPageMainJoiningModeManual.BackColor = System.Drawing.Color.Transparent;
			this.tabPageMainJoiningModeManual.Controls.Add(this.buttonMainJoiningModeManualJoinnow);
			this.tabPageMainJoiningModeManual.Controls.Add(this.buttonMainJoiningModeManualBrowseoutputfile);
			this.tabPageMainJoiningModeManual.Controls.Add(this.textBoxMainJoiningModeManualOutputfile);
			this.tabPageMainJoiningModeManual.Controls.Add(this.labelMainJoiningModeManualOutputfile);
			this.tabPageMainJoiningModeManual.Controls.Add(this.buttonMainJoiningModeManualBrowseinputchunk);
			this.tabPageMainJoiningModeManual.Controls.Add(this.textBoxMainJoiningModeManualInputchunk);
			this.tabPageMainJoiningModeManual.Controls.Add(this.labelMainJoiningModeManualInputchunk);
			this.tabPageMainJoiningModeManual.Location = new System.Drawing.Point(4, 25);
			this.tabPageMainJoiningModeManual.Name = "tabPageMainJoiningModeManual";
			this.tabPageMainJoiningModeManual.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMainJoiningModeManual.Size = new System.Drawing.Size(541, 136);
			this.tabPageMainJoiningModeManual.TabIndex = 1;
			this.tabPageMainJoiningModeManual.Text = "Manual";
			// 
			// buttonMainJoiningModeManualJoinnow
			// 
			this.buttonMainJoiningModeManualJoinnow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMainJoiningModeManualJoinnow.Location = new System.Drawing.Point(459, 104);
			this.buttonMainJoiningModeManualJoinnow.Name = "buttonMainJoiningModeManualJoinnow";
			this.buttonMainJoiningModeManualJoinnow.Size = new System.Drawing.Size(76, 26);
			this.buttonMainJoiningModeManualJoinnow.TabIndex = 6;
			this.buttonMainJoiningModeManualJoinnow.Text = "Join Now";
			this.buttonMainJoiningModeManualJoinnow.UseVisualStyleBackColor = true;
			this.buttonMainJoiningModeManualJoinnow.Click += new System.EventHandler(this.ButtonMainJoiningModeManualJoinnowClick);
			// 
			// buttonMainJoiningModeManualBrowseoutputfile
			// 
			this.buttonMainJoiningModeManualBrowseoutputfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMainJoiningModeManualBrowseoutputfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMainJoiningModeManualBrowseoutputfile.Location = new System.Drawing.Point(497, 50);
			this.buttonMainJoiningModeManualBrowseoutputfile.Name = "buttonMainJoiningModeManualBrowseoutputfile";
			this.buttonMainJoiningModeManualBrowseoutputfile.Size = new System.Drawing.Size(38, 20);
			this.buttonMainJoiningModeManualBrowseoutputfile.TabIndex = 5;
			this.buttonMainJoiningModeManualBrowseoutputfile.Text = "....";
			this.buttonMainJoiningModeManualBrowseoutputfile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonMainJoiningModeManualBrowseoutputfile.UseVisualStyleBackColor = true;
			this.buttonMainJoiningModeManualBrowseoutputfile.Click += new System.EventHandler(this.ButtonMainJoiningModeManualBrowseoutputfileClick);
			// 
			// textBoxMainJoiningModeManualOutputfile
			// 
			this.textBoxMainJoiningModeManualOutputfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxMainJoiningModeManualOutputfile.Location = new System.Drawing.Point(112, 50);
			this.textBoxMainJoiningModeManualOutputfile.Name = "textBoxMainJoiningModeManualOutputfile";
			this.textBoxMainJoiningModeManualOutputfile.Size = new System.Drawing.Size(379, 20);
			this.textBoxMainJoiningModeManualOutputfile.TabIndex = 4;
			// 
			// labelMainJoiningModeManualOutputfile
			// 
			this.labelMainJoiningModeManualOutputfile.AutoSize = true;
			this.labelMainJoiningModeManualOutputfile.Location = new System.Drawing.Point(45, 53);
			this.labelMainJoiningModeManualOutputfile.Name = "labelMainJoiningModeManualOutputfile";
			this.labelMainJoiningModeManualOutputfile.Size = new System.Drawing.Size(61, 13);
			this.labelMainJoiningModeManualOutputfile.TabIndex = 3;
			this.labelMainJoiningModeManualOutputfile.Text = "Output File:";
			// 
			// buttonMainJoiningModeManualBrowseinputchunk
			// 
			this.buttonMainJoiningModeManualBrowseinputchunk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMainJoiningModeManualBrowseinputchunk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMainJoiningModeManualBrowseinputchunk.Location = new System.Drawing.Point(497, 24);
			this.buttonMainJoiningModeManualBrowseinputchunk.Name = "buttonMainJoiningModeManualBrowseinputchunk";
			this.buttonMainJoiningModeManualBrowseinputchunk.Size = new System.Drawing.Size(38, 20);
			this.buttonMainJoiningModeManualBrowseinputchunk.TabIndex = 2;
			this.buttonMainJoiningModeManualBrowseinputchunk.Text = "....";
			this.buttonMainJoiningModeManualBrowseinputchunk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonMainJoiningModeManualBrowseinputchunk.UseVisualStyleBackColor = true;
			this.buttonMainJoiningModeManualBrowseinputchunk.Click += new System.EventHandler(this.ButtonMainJoiningModeManualBrowseinputchunkClick);
			// 
			// textBoxMainJoiningModeManualInputchunk
			// 
			this.textBoxMainJoiningModeManualInputchunk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxMainJoiningModeManualInputchunk.Location = new System.Drawing.Point(112, 24);
			this.textBoxMainJoiningModeManualInputchunk.Name = "textBoxMainJoiningModeManualInputchunk";
			this.textBoxMainJoiningModeManualInputchunk.Size = new System.Drawing.Size(379, 20);
			this.textBoxMainJoiningModeManualInputchunk.TabIndex = 1;
			// 
			// labelMainJoiningModeManualInputchunk
			// 
			this.labelMainJoiningModeManualInputchunk.AutoSize = true;
			this.labelMainJoiningModeManualInputchunk.Location = new System.Drawing.Point(38, 27);
			this.labelMainJoiningModeManualInputchunk.Name = "labelMainJoiningModeManualInputchunk";
			this.labelMainJoiningModeManualInputchunk.Size = new System.Drawing.Size(68, 13);
			this.labelMainJoiningModeManualInputchunk.TabIndex = 0;
			this.labelMainJoiningModeManualInputchunk.Text = "Input Chunk:";
			// 
			// openFileDialogMainSplittingInputfile
			// 
			this.openFileDialogMainSplittingInputfile.FileName = "openFileDialog1";
			this.openFileDialogMainSplittingInputfile.Filter = "All Files|*.*";
			// 
			// openFileDialogMainJoiningModeManualBrowseinputchunk
			// 
			this.openFileDialogMainJoiningModeManualBrowseinputchunk.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(738, 253);
			this.Controls.Add(this.tabControlMain);
			this.Controls.Add(this.menuStripMain);
			this.MainMenuStrip = this.menuStripMain;
			this.Name = "MainForm";
			this.Text = "KnifeSpan";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.tabControlMain.ResumeLayout(false);
			this.tabPageMainSplitting.ResumeLayout(false);
			this.tabPageMainSplitting.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMainSplittingChunksize)).EndInit();
			this.tabPageMainJoining.ResumeLayout(false);
			this.tabControlMainJoiningMode.ResumeLayout(false);
			this.tabPageMainJoiningModeManual.ResumeLayout(false);
			this.tabPageMainJoiningModeManual.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.NumericUpDown numericUpDownMainSplittingChunksize;
		private System.Windows.Forms.SaveFileDialog saveFileDialogMainJoiningModeManualBrowseoutputfile;
		private System.Windows.Forms.OpenFileDialog openFileDialogMainJoiningModeManualBrowseinputchunk;
		private System.Windows.Forms.Label labelMainJoiningModeManualInputchunk;
		private System.Windows.Forms.TextBox textBoxMainJoiningModeManualInputchunk;
		private System.Windows.Forms.Button buttonMainJoiningModeManualBrowseinputchunk;
		private System.Windows.Forms.Label labelMainJoiningModeManualOutputfile;
		private System.Windows.Forms.TextBox textBoxMainJoiningModeManualOutputfile;
		private System.Windows.Forms.Button buttonMainJoiningModeManualBrowseoutputfile;
		private System.Windows.Forms.Button buttonMainJoiningModeManualJoinnow;
		private System.Windows.Forms.TabPage tabPageMainJoiningModeManual;
		private System.Windows.Forms.TabPage tabPageMainJoiningModeAuto;
		private System.Windows.Forms.TabControl tabControlMainJoiningMode;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMainSplittingOutputdir;
		private System.Windows.Forms.OpenFileDialog openFileDialogMainSplittingInputfile;
		private System.Windows.Forms.TabPage tabPageMainJoining;
		private System.Windows.Forms.Label labelMainSplittingInputfile;
		private System.Windows.Forms.Label labelMainSplittingOutputDir;
		private System.Windows.Forms.TextBox textBoxMainSplittingInputFile;
		private System.Windows.Forms.Button buttonMainSplittingBrowseinputfile;
		private System.Windows.Forms.TextBox textBoxMainSplittingOutputdir;
		private System.Windows.Forms.Label labelMainSplittingChunksize;
		private System.Windows.Forms.ComboBox comboBoxMainSplittingChunksizetype;
		private System.Windows.Forms.Button buttonMainSplittingBrowseoutputdir;
		private System.Windows.Forms.Button buttonMainSplittingSplitNow;
		private System.Windows.Forms.TabPage tabPageMainSplitting;
		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.ToolStripMenuItem menuItemMainHelpAbout;
		private System.Windows.Forms.ToolStripMenuItem menuItemMainFileExit;
		private System.Windows.Forms.ToolStripSeparator menuSeparatorMainFile01;
		private System.Windows.Forms.ToolStripMenuItem menuItemMainFileOptions;
		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.ToolStripMenuItem menuItemMainHelp;
		private System.Windows.Forms.ToolStripMenuItem menuItemMainFile;
		
	}
}
