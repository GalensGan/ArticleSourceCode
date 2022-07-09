using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleUtils
{
    public class LogHelper
    {
        /// <summary>
        /// 输出调试信息
        /// </summary>
        /// <param name="message"></param>
        public static void Debug(string message)
        {
            Message.Console.WriteLine(message);
        }
    }
}
