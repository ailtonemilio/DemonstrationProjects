using System;

namespace ShipSmpl
{
    public partial class pictureViwer
    {
        public pictureViwer()
        {
            InitializeComponent();
            _DirListBox1.Name = "DirListBox1";
            _FileListBox1.Name = "FileListBox1";
            _DriveListBox1.Name = "DriveListBox1";
            _saveButton.Name = "saveButton";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAddNewEmployee.employeePictureBox.BackgroundImage = PictureBox1.Image;
            Close();
        }

        private void DriveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirListBox1.Path = DriveListBox1.Drive;
        }

        private void DirListBox1_Click(object sender, EventArgs e)
        {
            {
                var withBlock = FileListBox1;
                withBlock.Path = DirListBox1.Path;
                withBlock.Pattern = "*.png;*.jpg; *.gif; *.jpeg; *.bmp";
            }
        }

        private void FileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PictureBox1.ImageLocation = DirListBox1.Path + @"\" + FileListBox1.SelectedItem.ToString();
        }
    }
}