namespace SimVault.Forms
{
    partial class AppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            AppFormMenuStrip = new MenuStrip();
            AppFormMenuStripFile = new ToolStripMenuItem();
            AppFormMenuStripSetFolderBtn = new ToolStripMenuItem();
            AppFormMenuStripSettingsBtn = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            AppFormMenuStripExitBtn = new ToolStripMenuItem();
            AppFormMenuStripExtractTestBtn = new ToolStripMenuItem();
            AppFormMenuStripCompressTestBtn = new ToolStripMenuItem();
            AppFormTreeView = new TreeView();
            AppFormImageList = new ImageList(components);
            AppFormTreeViewLabel = new Label();
            AppFormViewLabelDir = new Label();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            AppFormProgressBar = new ProgressBar();
            AppFormLabelProgress = new Label();
            AppFormFolderBrowser = new FolderBrowserDialog();
            AppFormOpenFileBrowser = new OpenFileDialog();
            AppFormMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // AppFormMenuStrip
            // 
            AppFormMenuStrip.Items.AddRange(new ToolStripItem[] { AppFormMenuStripFile });
            AppFormMenuStrip.Location = new Point(0, 0);
            AppFormMenuStrip.Name = "AppFormMenuStrip";
            AppFormMenuStrip.Size = new Size(1372, 24);
            AppFormMenuStrip.TabIndex = 0;
            AppFormMenuStrip.Text = "menuStrip1";
            // 
            // AppFormMenuStripFile
            // 
            AppFormMenuStripFile.DropDownItems.AddRange(new ToolStripItem[] { AppFormMenuStripSetFolderBtn, AppFormMenuStripSettingsBtn, toolStripSeparator1, AppFormMenuStripExitBtn, AppFormMenuStripExtractTestBtn, AppFormMenuStripCompressTestBtn });
            AppFormMenuStripFile.Name = "AppFormMenuStripFile";
            AppFormMenuStripFile.Size = new Size(37, 20);
            AppFormMenuStripFile.Text = "File";
            // 
            // AppFormMenuStripSetFolderBtn
            // 
            AppFormMenuStripSetFolderBtn.Name = "AppFormMenuStripSetFolderBtn";
            AppFormMenuStripSetFolderBtn.Size = new Size(159, 22);
            AppFormMenuStripSetFolderBtn.Text = "Set Folder";
            // 
            // AppFormMenuStripSettingsBtn
            // 
            AppFormMenuStripSettingsBtn.Name = "AppFormMenuStripSettingsBtn";
            AppFormMenuStripSettingsBtn.Size = new Size(159, 22);
            AppFormMenuStripSettingsBtn.Text = "Settings";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(156, 6);
            // 
            // AppFormMenuStripExitBtn
            // 
            AppFormMenuStripExitBtn.Name = "AppFormMenuStripExitBtn";
            AppFormMenuStripExitBtn.Size = new Size(159, 22);
            AppFormMenuStripExitBtn.Text = "Exit";
            AppFormMenuStripExitBtn.Click += AppFormMenuStripExitBtn_Click;
            // 
            // AppFormMenuStripExtractTestBtn
            // 
            AppFormMenuStripExtractTestBtn.Name = "AppFormMenuStripExtractTestBtn";
            AppFormMenuStripExtractTestBtn.Size = new Size(159, 22);
            AppFormMenuStripExtractTestBtn.Text = "Extract (Test)";
            AppFormMenuStripExtractTestBtn.Click += AppFormMenuStripExtractTestBtn_Click;
            // 
            // AppFormMenuStripCompressTestBtn
            // 
            AppFormMenuStripCompressTestBtn.Name = "AppFormMenuStripCompressTestBtn";
            AppFormMenuStripCompressTestBtn.Size = new Size(159, 22);
            AppFormMenuStripCompressTestBtn.Text = "Compress (Test)";
            AppFormMenuStripCompressTestBtn.Click += AppFormMenuStripCompressTestBtn_Click;
            // 
            // AppFormTreeView
            // 
            AppFormTreeView.CheckBoxes = true;
            AppFormTreeView.FullRowSelect = true;
            AppFormTreeView.ImageIndex = 0;
            AppFormTreeView.ImageList = AppFormImageList;
            AppFormTreeView.Location = new Point(12, 83);
            AppFormTreeView.Name = "AppFormTreeView";
            AppFormTreeView.SelectedImageIndex = 0;
            AppFormTreeView.ShowNodeToolTips = true;
            AppFormTreeView.Size = new Size(1348, 601);
            AppFormTreeView.TabIndex = 1;
            AppFormTreeView.BeforeCheck += AppFormTreeView_BeforeCheck;
            AppFormTreeView.AfterCheck += AppFormTreeView_AfterCheck;
            AppFormTreeView.AfterSelect += AppTreeView_AfterSelect;
            AppFormTreeView.NodeMouseClick += AppFormTreeView_NodeMouseClick;
            // 
            // AppFormImageList
            // 
            AppFormImageList.ColorDepth = ColorDepth.Depth32Bit;
            AppFormImageList.ImageStream = (ImageListStreamer)resources.GetObject("AppFormImageList.ImageStream");
            AppFormImageList.TransparentColor = Color.Transparent;
            AppFormImageList.Images.SetKeyName(0, "icons8-folder-48.png");
            AppFormImageList.Images.SetKeyName(1, "icons8-file-48.png");
            // 
            // AppFormTreeViewLabel
            // 
            AppFormTreeViewLabel.AutoSize = true;
            AppFormTreeViewLabel.Location = new Point(12, 33);
            AppFormTreeViewLabel.Name = "AppFormTreeViewLabel";
            AppFormTreeViewLabel.Size = new Size(132, 15);
            AppFormTreeViewLabel.TabIndex = 2;
            AppFormTreeViewLabel.Text = "AppFormTreeViewLabel";
            // 
            // AppFormViewLabelDir
            // 
            AppFormViewLabelDir.AutoSize = true;
            AppFormViewLabelDir.Location = new Point(1235, 33);
            AppFormViewLabelDir.Name = "AppFormViewLabelDir";
            AppFormViewLabelDir.Size = new Size(125, 15);
            AppFormViewLabelDir.TabIndex = 3;
            AppFormViewLabelDir.Text = "AppFormViewLabelDir";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(93, 54);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1267, 23);
            progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // AppFormProgressBar
            // 
            AppFormProgressBar.Location = new Point(93, 54);
            AppFormProgressBar.Name = "AppFormProgressBar";
            AppFormProgressBar.Size = new Size(1267, 23);
            AppFormProgressBar.TabIndex = 4;
            // 
            // AppFormLabelProgress
            // 
            AppFormLabelProgress.AutoSize = true;
            AppFormLabelProgress.Location = new Point(12, 58);
            AppFormLabelProgress.Name = "AppFormLabelProgress";
            AppFormLabelProgress.Size = new Size(55, 15);
            AppFormLabelProgress.TabIndex = 5;
            AppFormLabelProgress.Text = "Progress:";
            AppFormLabelProgress.TextAlign = ContentAlignment.TopCenter;
            // 
            // AppFormOpenFileBrowser
            // 
            AppFormOpenFileBrowser.FileName = "openFileDialog1";
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 696);
            Controls.Add(AppFormLabelProgress);
            Controls.Add(AppFormProgressBar);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(AppFormViewLabelDir);
            Controls.Add(AppFormTreeViewLabel);
            Controls.Add(AppFormTreeView);
            Controls.Add(AppFormMenuStrip);
            MainMenuStrip = AppFormMenuStrip;
            Name = "AppForm";
            Text = "SimVault";
            Load += AppForm_Load;
            AppFormMenuStrip.ResumeLayout(false);
            AppFormMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip AppFormMenuStrip;
        private ToolStripMenuItem AppFormMenuStripFile;
        private ToolStripMenuItem AppFormMenuStripSetFolderBtn;
        private ToolStripMenuItem AppFormMenuStripSettingsBtn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem AppFormMenuStripExitBtn;
        private TreeView AppFormTreeView;
        private Label AppFormTreeViewLabel;
        private Label AppFormViewLabelDir;
        private ImageList AppFormImageList;
        private ProgressBar progressBar1;
        private Label label1;
        private ProgressBar AppFormProgressBar;
        private Label AppFormLabelProgress;
        private ToolStripMenuItem AppFormMenuStripExtractTestBtn;
        private ToolStripMenuItem AppFormMenuStripCompressTestBtn;
        private FolderBrowserDialog AppFormFolderBrowser;
        private OpenFileDialog AppFormOpenFileBrowser;
    }
}