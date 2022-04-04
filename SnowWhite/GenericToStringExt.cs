using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowWhite
{
    public static class GenericToStringExts
    {
        public static string PrettyPrint<T>(this List<T> list) => "[" + string.Join(", ", list) + "]";
    }
}
