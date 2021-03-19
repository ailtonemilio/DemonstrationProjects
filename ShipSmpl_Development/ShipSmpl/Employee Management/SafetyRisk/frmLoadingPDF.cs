using System;
using System.IO;
using WaitLoading;

namespace ShipSmpl
{
    public partial class frmLoadingPDF
    {
        public frmLoadingPDF()
        {
            InitializeComponent();
        }

        private FTPServerManagement ftpser = new FTPServerManagement();
        private WaitLoadingRun waitForm = new WaitLoadingRun();
        public string ftpfileName;
        public string ftpDirFileName;

        private void Timer1_Tick(object sender, EventArgs e)
        {
        }

        public void LoadForm()
        {
            waitForm.Show();
            ftpser.CleanDirectory();
            if (ftpser.GetFTPFileSaveTempDir(ftpDirFileName) == false)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error", "Error opening the file! Error code: # 1321. Try again or contact the IT department.", this);
            }

            waitForm.Close();
            CloseForm();
        }

        public int GetSizeFileTemp(string NameFile)
        {
            var di = new DirectoryInfo(@"C:\temp");
            var fiArr = di.GetFiles();
            var MaxSizaFile = default(long);
            foreach (FileInfo f in fiArr)
                MaxSizaFile += f.Length;
            return Convert.ToInt32(MaxSizaFile);
        }

        public void CloseForm()
        {
            Close();
            My.MyProject.Forms.frmWebBrowserPDF.LoadPDFWebBrowser(ftpfileName);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmWebBrowserPDF, this);
            ftpser.CleanDirectory();
        }

        private void frmLoadingPDF_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}