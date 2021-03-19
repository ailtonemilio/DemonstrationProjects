using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ShipSmpl
{
    static class MdlUnits
    {
        public static string ReformatCarNumber(string CarNumber)
        {
            short x = 0;
            string AlphaPart = "";
            string NumPart = "";
            var loopTo = (short)Strings.Len(CarNumber);
            for (x = 1; x <= loopTo; x++)
            {
                if (Operators.CompareString(Strings.Mid(CarNumber, x, 1), '0'.ToString(), false) >= 0 & Operators.CompareString(Strings.Mid(CarNumber, x, 1), '9'.ToString(), false) <= 0)
                {
                    NumPart += Strings.Mid(CarNumber, x, 1);
                }
                else
                {
                    AlphaPart += Strings.Mid(CarNumber, x, 1);
                }
            }

            if (Strings.Len(NumPart) < 6)
            {
                return AlphaPart + Strings.Format(Conversion.Val(NumPart), "#000000");
            }
            else
            {
                return CarNumber;
            }
        }

        public static bool UnitAlreadyExist(string unit, List<UnitSource> AllUnitsList, ref UnitSource unitFound)
        {
            var list = AllUnitsList.Where(u => (u.UnitNumber ?? "") == (unit ?? "")).ToList();
            bool isFound = list.Count > 0;
            if (isFound)
            {
                unitFound = list[0];
            }

            return isFound;
        }
    }
}