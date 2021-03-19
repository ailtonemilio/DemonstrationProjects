using ModelLayer;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class FTPAccountRepository : IFTPAccountRepository

    {


        public FTPAccount GetWTCIITAccount(string User)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.FTPAccount.Where(f => f.FTPUser == User).ToList()[0];
            }

        }
    }

    public interface IFTPAccountRepository
    {
        FTPAccount GetWTCIITAccount(string User);
    }
}