using ArticleSourceCode.DgnTools;
using MSAddinTest.MSTestInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSourceCode.AddinAndKeyIn
{
    internal class TestIndex:IMSTest_StaticMethod
    {
        /// <summary>
        /// 测试 arg
        /// </summary>
        /// <param name="arg"></param>
        [MSTest("PrimaryTool")]
        public static void TestDgnPrimaryTool(string arg)
        {
            NewToolFactory.TestDgnPrimitiveTool();            
        }

        [MSTest("ElementSetTool")]
        public static void TestDgnElemenetSetTool(string arg)
        {
            var tool = new DgnElementSetToolsTest();
            tool.InstallTool();
        }
    }
}
