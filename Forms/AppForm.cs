using SharpSevenZip;
using SharpSevenZip.EventArguments;
using SimVault.Classes;

namespace SimVault.Forms
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();

            AppFormProgressBar.Minimum = 0;
            AppFormProgressBar.Maximum = 100;
            AppFormProgressBar.Value = 0;
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            AppFormFolderBrowser.Multiselect = false;

            var dialog = AppFormFolderBrowser.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                var fileService = new FileDirectoryService(AppFormFolderBrowser.SelectedPath);

                var nodes = fileService.GetAllFilesAndDirectoriesAsTreeView().ToArray();

                AppFormViewLabelDir.Text = nodes.Count().ToString();
                AppFormTreeView.Nodes.AddRange(nodes);

                AppFormFolderBrowser.Dispose();
            }


        }

        private void AppForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void AppFormMenuStripExitBtn_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void AppTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            AppFormTreeViewLabel.Text = AppFormTreeView.SelectedNode.FullPath;
        }

        private void AppFormTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        private void AppFormTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode item in e.Node.Nodes)
            {
                item.Checked = item.Parent.Checked;
            }
        }

        private void AppFormTreeView_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {

        }


        private async void AppFormMenuStripCompressTestBtn_Click(object sender, EventArgs e)
        {
            AppFormProgressBar.Value = 0;
            AppFormFolderBrowser.Multiselect = false;
            var dialog = AppFormFolderBrowser.ShowDialog();

            if (dialog == DialogResult.OK) {

                await Task.Run(() => CompressWithProgress(AppFormFolderBrowser.SelectedPath));
            }

        }
        private async void CompressWithProgress(string folder)
        {

            var compressor = new SharpSevenZipCompressor() { ArchiveFormat = OutArchiveFormat.SevenZip,CompressionMethod = CompressionMethod.Lzma2,CompressionLevel= CompressionLevel.Normal };

            compressor.Compressing += Compressing_CompressingProgress;

            compressor.CompressionFinished += CompressionFinished;

            var dirToCompress = new DirectoryInfo(folder);

            var archiveName = $"{dirToCompress.Parent.FullName}\\{dirToCompress.Name}_{DateTime.Now.ToString("yyyyMMdd")}.7z";

            await compressor.CompressDirectoryAsync(folder, archiveName);

        }

        private void CompressionFinished(object? sender, EventArgs e)
        {
            //AppFormProgressBar.Value = 0;
            MessageBox.Show("Compression Completed");
        }

        private void Compressing_CompressingProgress(object? sender, ProgressEventArgs e)
        {
            // ProgressEventArgs has:
            // e.PercentDone (int)
            Invoke(new Action(() =>
            {
                AppFormProgressBar.Value = e.PercentDone;
            }));
        }

        private async void AppFormMenuStripExtractTestBtn_Click(object sender, EventArgs e)
        {
            AppFormOpenFileBrowser.Multiselect = false;
            AppFormFolderBrowser.Multiselect = false;
            AppFormProgressBar.Value = 0;

            DialogResult dialogFileBrowser = AppFormOpenFileBrowser.ShowDialog();

            if(dialogFileBrowser == DialogResult.OK)
            {
                string archive = AppFormOpenFileBrowser.FileName;
                AppFormOpenFileBrowser.Dispose();

                DialogResult dialogFolder = AppFormFolderBrowser.ShowDialog();

                if(dialogFolder == DialogResult.OK)
                {
                    string output = AppFormFolderBrowser.SelectedPath;
                    AppFormFolderBrowser.Dispose();

                    await Task.Run(() => ExtractWithProgress(archive, output));

                }
            }

        }

        private async void ExtractWithProgress(string archive, string output)
        {
            using var extractor = new SharpSevenZipExtractor(archive);

            extractor.Extracting += Extractor_ExtractionProgress;

            extractor.ExtractionFinished += ExtractorFinished;

            await extractor.ExtractArchiveAsync(output);

        }

        private void Extractor_ExtractionProgress(object? sender, ProgressEventArgs e)
        {
            // ProgressEventArgs has:
            // e.PercentDone (int)

            Invoke(new Action(() =>
            {
                AppFormProgressBar.Value = e.PercentDone;
            }));
        }

        /// <summary>
        /// Shows message when extraction is finished
        ///  TODO : Reset Progress bar when extraction is finished, currently will throw and error when editing the progress bar in the main thread as is being edited on another thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtractorFinished(object? sender, EventArgs e)
        {
            //AppFormProgressBar.Value = 0;
            MessageBox.Show("Extractor Completed");
        }

    }
}
