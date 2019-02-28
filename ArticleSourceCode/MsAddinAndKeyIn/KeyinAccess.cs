using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticleSourceCode;

namespace ArticleSourceCode.MsAddinAndKeyIn
{
    public sealed class KeyinAccess
    {
        /// <summary>
        /// 消息通知入口
        /// </summary>
        /// <param name="unparsed"></param>
        public static void MessageManagerAccess(string unparsed)
        {
            MessageManager.MessageHandleForm.InstallNewInstance();
        }
    }
}
