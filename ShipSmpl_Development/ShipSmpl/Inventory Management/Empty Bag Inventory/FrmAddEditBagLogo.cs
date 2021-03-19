using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmAddEditBagLogo
    {
        public FrmAddEditBagLogo()
        {
            InitializeComponent();
            _closeFlatButton.Name = "closeFlatButton";
            _btnUploadLogo.Name = "btnUploadLogo";
            _cbNoBagYear.Name = "cbNoBagYear";
            _btnSave.Name = "btnSave";
        }

        public struct LogoInfo
        {
            public string Extension;
            public string Name;
            public Image Image;
            public int MbSize;
        }

        public bool isNewLogo;
        public LogoInfo SelectedLogo;
        public int bagLogoId;
        private string imagePath;
        private BagLogo SelectedLogoInfo;

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                nudBagYear.Enabled = false;
            }
            else
            {
                nudBagYear.Enabled = true;
            }
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "All|*|Bitmap|*.bmp|JPEG|*.jpg|PNG|*.png"; // If you like file type filters you can add them here
                                                                    // any other modifications to the dialog
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                var fi = new FileInfo(ofd.FileName);
                if (fi.Length / 1000d <= 2000d)
                {
                    var bmp = new Bitmap(ofd.FileName);
                    // bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    // pbBagLogo.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    SelectedLogo = new LogoInfo();
                    SelectedLogo.Image = bmp;
                    SelectedLogo.Extension = fi.Extension;
                    SelectedLogo.Name = fi.FullName;
                    SelectedLogo.MbSize = (int)Math.Round(fi.Length / 1000d);
                    pbBagLogo.Image = bmp;
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Image exceeds size limit", "The maximum image size is 2MB. Please decrease image size or resolution.", this);
                }
            }
            catch
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error:", "Not a valid image file.", this);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string bagYear = "N/A";
            var bs = new BagInventoryService();
            if (isGoodToGo())
            {
                if (SaveBagImageLogo() == true)
                {
                    if (cbNoBagYear.Checked)
                        bagYear = "N/A";
                    else
                        bagYear = nudBagYear.Value.ToString();
                    if (isNewLogo)
                    {
                        bs.InsertBagLogo(bagYear, Strings.Trim(tbLogoDescription.Text), imagePath);
                    }
                    else
                    {
                        bs.UpdateBagLogo(SelectedLogoInfo.BagLogoId, Strings.Trim(tbLogoDescription.Text), bagYear, imagePath);
                    }

                    My.MyProject.Forms.FrmEditAddBags.dgvLogos.DataSource = BagInventoryService.GetAllBagLogos().Where(b => b.LogoDescription != "N/A").ToList();
                    Close();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error uploading image:", "There was a problem uploading the image into ftp server. If the issue persists, contact the IT department", this);
                }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void LoadEditInfo(BagLogo BagInfo)
        {
            var ftp = new MdlFtp();
            tbLogoDescription.Text = BagInfo.LogoDescription;
            SelectedLogoInfo = BagInfo;
            if (BagInfo.BagYear.Equals("N/A"))
            {
                cbNoBagYear.Checked = true;
                nudBagYear.Value = 0m;
            }
            else
            {
                cbNoBagYear.Checked = false;
                nudBagYear.Value = Conversions.ToDecimal(BagInfo.BagYear);
            }

            if (!BagInfo.ImagePath.Equals("N/A"))
            {
                pbBagLogo.Image = ftp.GetFTPImage(BagInfo.ImagePath);
            }
        }

        public void LoadForm()
        {
            tbLogoDescription.Text = "";
            nudBagYear.Value = 0m;
            pbBagLogo.Image = null;
            cbNoBagYear.Checked = false;
        }

        private bool SaveBagImageLogo()
        {

            // Dim ftpPath As String = "Emilio.2020", path As String = "Operations/EmptyBags/BagPictures"
            string imageName = tbLogoDescription.Text.Replace(" ", "") + "-" + DateAndTime.Now.ToString("ddMMMyyyyHHmmss") + SelectedLogo.Extension;
            var ftpMdl = new MdlFtp();
            bool imageUploaded;
            // Dim name = pbBagLogo.Image.Tag

            if (isNewLogo == false && !SelectedLogoInfo.ImagePath.Equals("N/A"))
            {
                var isDeleted = ftpMdl.deleteFTPImage(SelectedLogoInfo.ImagePath);
            }

            if (!Information.IsNothing(pbBagLogo.Image))
            {
                string remotePath = "/Operations/EmptyBags/BagPictures/";
                imageUploaded = ftpMdl.uploadFtpFile(SelectedLogo.Name, remotePath, imageName);
                if (imageUploaded == false)
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Image not saved", @"An error occured while saving the image into FTP server.Please make sure you are connected to WTC network.
If problem persist, contact the IT department.", this);
                    imagePath = "N/A";
                }
                else
                {
                    imagePath = "Operations/EmptyBags/BagPictures/" + imageName;
                }
            }
            else
            {
                imagePath = "N/A";
                imageUploaded = true;
            }

            return imageUploaded;
        }

        private Graphics ResizeImage(Image img)
        {
            object newBitmap;
            Graphics g;
            newBitmap = new Bitmap(400, 500);
            g = Graphics.FromImage((Image)newBitmap);
            var imagehere = img;
            g.DrawImage(imagehere, 200, 200);
            return g;
        }

        private bool isGoodToGo()
        {
            if (string.IsNullOrEmpty(tbLogoDescription.Text))
            {
                lblWarning.Text = "Logo description can not be empty";
                return false;
            }

            return true;
        }

        private void cbNoBagYear_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                nudBagYear.Visible = false;
            }
            else
            {
                nudBagYear.Visible = true;
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}