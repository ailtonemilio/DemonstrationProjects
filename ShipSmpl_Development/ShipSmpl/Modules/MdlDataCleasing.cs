using Microsoft.VisualBasic;

namespace ShipSmpl
{
    static class MdlDataCleasing
    {
        public static string TrimAll(string word)
        {
            word = word.Replace(Constants.vbTab, "");
            word = Strings.Trim(word);
            return word;
        }
    }
}