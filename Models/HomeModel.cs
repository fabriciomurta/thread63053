using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtMVC1.Models
{
    public class HomeModel
    {
        public static bool IAmSpecial = false;

        public static string SpecialButtonLabel
        {
            get => "Make me " + (IAmSpecial ? "not" : "now") + " special";
        }
    }
}
