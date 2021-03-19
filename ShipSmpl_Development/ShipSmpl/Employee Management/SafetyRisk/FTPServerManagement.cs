using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using ModelLayer;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinSCP;

namespace ShipSmpl
{
    public class FTPServerManagement
    {

        // 'New Version
        private FTPAccount ftpInfo = FTPAccountService.GetWTCIITAccount("emilio");

        // New Code
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

        public bool CreateFolder(string Folder)
        {
            try
            {
                var sessionOptions = InitializeFTPSession();
                using (var session = new Session())
                {
                    // Connect
                    session.Open(sessionOptions);

                    // Your code
                    session.CreateDirectory("/documentstorage/" + Folder);

                    // Close session
                    session.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CreateSubFolder(string Folder, string SubFolder)
        {
            try
            {
                var sessionOptions = InitializeFTPSession();
                using (var session = new Session())
                {
                    // Connect
                    session.Open(sessionOptions);

                    // Your code
                    session.CreateDirectory("/documentstorage/" + Folder + "/" + SubFolder);

                    // Close session
                    session.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool uploadSFTPFile(string localPath, string remotePath, string File)
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
                    transferOptions.TransferMode = TransferMode.Automatic;
                    TransferOperationResult transferResult;
                    remotePath += File;
                    transferResult = session.PutFiles(localPath, remotePath, false, transferOptions);

                    // Throw on any error
                    transferResult.Check();

                    // Connect
                    // session.Open(sessionOptions)

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool GetFTPFileSaveTempDir(string RemotePath)
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
                    if (Directory.Exists(@"C:\temp") == false)
                    {
                        FileSystem.MkDir(@"C:\temp");
                    }

                    TransferOperationResult transferResult;
                    transferResult = session.GetFiles("/" + RemotePath, @"C:\temp\", false, transferOptions);

                    // Throw on any error
                    transferResult.Check();

                    // Dim t = transferResult.Transfers(0)

                    // File.Delete(tempPath)

                    return true;
                }
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
                return false;
            }
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
        /// <summary>
        /// Clears the C: / temp directory on the client computer
        /// </summary>
        public void CleanDirectory()
        {
            try
            {
                var arrStr = Array.Empty<string>();
                arrStr = Directory.GetFiles(@"C:\temp", "*.*");
                for (int i = 0, loopTo = arrStr.Length - 1; i <= loopTo; i++)
                {
                    try
                    {
                        File.Delete(arrStr[i]);
                    }
                    catch (Exception ExIO)
                    {
                        Debug.Print(ExIO.Message);
                    }
                }
            }
            catch (IOException ExIO)
            {
                Interaction.MsgBox(ExIO.Message);
            }
        }
        /// <summary>
        /// Delete the file from the FTP server.
        /// </summary>
        /// <param name="FTPFilePath">Pass the full address of the directory where the file is located: Example: /pasta/subpasta/arquivo.pdf</param>
        /// <returns>Returns true if deleted.</returns>
        public bool DeleteSFTPFile(string FTPFilePath)
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
        /// <summary>
        /// Delete the directory from the FTP server.
        /// </summary>
        /// <param name="FTPFilePath">Pass the full address of the directory to be excluded: Example: / folder / subfolder</param>
        /// <returns>Returns true if deleted.</returns>
        public bool DeleteSFTPFolder(string FTPFilePath)
        {
            try
            {
                var sessionOptions = InitializeFTPSession();
                using (var session = new Session())
                {
                    // Connect
                    session.Open(sessionOptions);

                    // Your code
                    session.RemoveFiles(RemotePath.EscapeFileMask(FTPFilePath));
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("e: " + ex.Message);
                return false;
            }
        }
    }
}