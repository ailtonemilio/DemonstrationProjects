using BusinessLayer.WTC_Ceres;
using ModelLayer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinSCP;

namespace ShipSmpl
{
    public class MdlFtp
    {
        private FTPAccount ftpInfo = FTPAccountService.GetWTCIITAccount("WTCIT");

        public bool uploadFtpFile(string localPath, string remotePath, string ImageName)
        {
            try
            {
                var sessionOptions = InitializeFTPSession();
                using (var session = new Session())
                {
                    // Connect
                    session.Open(sessionOptions);

                    // Your code
                    var transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;
                    TransferOperationResult transferResult;
                    remotePath = remotePath + ImageName;
                    transferResult = session.PutFiles(localPath, remotePath, false, transferOptions);

                    // Throw on any error
                    transferResult.Check();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public object deleteFTPImage(string FTPFilePath)
        {
            try
            {
                var sessionOptions = InitializeFTPSession();
                using (var session = new Session())
                {
                    // Connect
                    session.Open(sessionOptions);

                    // Your code
                    session.RemoveFile(FTPFilePath);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("e: " + ex.Message);
                return false;
            }
        }

        public Bitmap GetFTPImage(string RemotePath)
        {
            try
            {
                var sessionOptions = InitializeFTPSession();
                using (var session = new Session())
                {
                    // Connect
                    session.Open(sessionOptions);

                    // Your code
                    var transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;
                    TransferOperationResult transferResult;
                    string tempPath = Path.GetTempFileName();
                    transferResult = session.GetFiles(RemotePath, tempPath, false, transferOptions);
                    var t = transferResult.Transfers[0];
                    var bitmap = ConvertToBitmap(tempPath);
                    File.Delete(tempPath);
                    return bitmap;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private SessionOptions InitializeFTPSession()
        {
            var sessionOptions = new SessionOptions();
            sessionOptions.Protocol = Protocol.Ftp;
            sessionOptions.HostName = ftpInfo.FTPHost;
            sessionOptions.UserName = ftpInfo.FTPUserId;
            sessionOptions.Password = ftpInfo.FTPPassword;
            sessionOptions.FtpSecure = FtpSecure.Implicit;
            sessionOptions.TlsHostCertificateFingerprint = ftpInfo.CertificateFingerPrint;
            return sessionOptions;
        }

        public Bitmap ConvertToBitmap(string fileName)
        {
            Bitmap bitmap;
            using (Stream bmpStream = File.Open(fileName, FileMode.Open))
            {
                var image = Image.FromStream(bmpStream);
                bitmap = new Bitmap(image);
            }

            return bitmap;
        }
    }
}