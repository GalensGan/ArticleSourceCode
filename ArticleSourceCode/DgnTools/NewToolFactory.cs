using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSourceCode.DgnTools
{
    class NewToolFactory
    {
        public static void TestDgnPrimitiveTool()
        {
            var tool = new DgnPrimitiveToolsTest();
            tool.InstallTool();
        }
    }
}
