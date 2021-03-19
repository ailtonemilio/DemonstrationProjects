using System;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class frmWebBrowserPDF
    {
        public frmWebBrowserPDF()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
        }
        // Dim ftpManager As FTPServerManagement = New FTPServerManagement()
        // Dim waitForm As WaitLoadingRun = New WaitLoadingRun()


        private void frmWebBrowserPDF_Load(object sender, EventArgs e)
        {
        }

        public void LoadPDFWebBrowser(string FileName)
        {
            string tmpStr;
            WebBrowser.Visible = true;
            lblTitle.Text = FileName;
            tmpStr = "file:///C:/temp/" + FileName;
            WebBrowser.Navigate(tmpStr);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}