using DataLayer.WTC_Ceres;
using ModelLayer;

namespace BusinessLayer.WTC_Ceres
{
    public class FTPAccountService
    {
        private static IFTPAccountRepository repository;

        static FTPAccountService()
        {
            repository = new FTPAccountRepository();
        }

        public static FTPAccount GetWTCIITAccount(string User)
        {
            return repository.GetWTCIITAccount(User);
        }
    }
}