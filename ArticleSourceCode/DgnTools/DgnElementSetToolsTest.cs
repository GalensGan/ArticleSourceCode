using Bentley.DgnPlatformNET;
using Bentley.DgnPlatformNET.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSourceCode.DgnTools
{
    class DgnElementSetToolsTest : DgnElementSetTool
    {
        public override StatusInt OnElementModify(Element element)
        {
            throw new NotImplementedException();
        }

        protected override void OnRestartTool()
        {
            throw new NotImplementedException();
        }
    }
}
