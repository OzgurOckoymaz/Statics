using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    static class ExtensionMethod
    {
        public static string clearTurkishLetter(string stmt)
        {
            string new_stmt = stmt.Replace("ç", "c").Replace("ğ", "g").Replace("ı", "i").Replace("ö", "o").Replace("ş", "s").Replace("ü", "u");
            return new_stmt;
        }
    }
}
