using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSourceCode.DgnTools
{
    class Dump
    {
        public static void WriteLine(params string[] messages)
        {
            Console.WriteLine(string.Join("-",messages));
        }
    }
}
