﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticleSourceCode;
using ArticleSourceCode.DgnTools;
using MSAddinTest.MSTestInterface;

namespace ArticleSourceCode.AddinAndKeyIn
{
    /// <summary>
    /// 改用 TestIndex 来进行测试
    /// </summary>
    public sealed class KeyinAccess
    {
        // 消息通知入口
        public static void MessageManagerAccess(string unparsed)
        {
            MessageManager.MessageHandleForm.InstallNewInstance();
        }

        //adapter测试,unparsed参数录入的不同
        public static void ShowDifferentAdapter(string unparsed)
        {
            Adaters.AdapterTest.ShowDifferentAdapter(unparsed);
        }

        // 测试 dgnTool       
        public static void TestDgnTool(string unparsed)
        {
            NewToolFactory.TestDgnPrimitiveTool();
        }
    }
}
