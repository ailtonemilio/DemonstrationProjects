using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CDataHelper
    {
        public string digitToLetter(int num)
        {
            try
            {
                if (num > 0 && num < 27)
                {
                    string c;
                    c = Convert.ToString(num + 64);
                    return c.ToUpper();
                }
                else
                    return "";
            }
            catch
            {
                return "";
            }
        }
    }
}
