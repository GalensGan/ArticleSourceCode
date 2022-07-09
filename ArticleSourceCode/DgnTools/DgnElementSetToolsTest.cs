using Bentley.DgnPlatformNET;
using Bentley.DgnPlatformNET.Elements;
using Bentley.GeometryNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSourceCode.DgnTools
{
    partial class DgnElementSetToolsTest : DgnElementSetTool
    {
        public DgnElementSetToolsTest()
        {
            this.DgnElemenetSetToolDebug("----------------------------- DgnElementSetToolsTest begin --------------------------");
        }

        public override StatusInt OnElementModify(Element element)
        {
            return StatusInt.Success;
        }

        #region 动态显示-新增
        // 是否想要动态显示
        protected override bool WantDynamics()
        {
            var result = base.WantDynamics();
            this.DgnElemenetSetToolDebug("WantDynamics", result);
            return result;
        }
        #endregion

        #region 重绘
        // 重绘初始化：访问元素之前调用，用来设置哪些 Elements 可以被绘制
        public override void OnRedrawInit(ViewContext context)
        {
            base.OnRedrawInit(context);
            this.DgnElemenetSetToolDebug("OnRedrawInit");
        }

        // 可以修改每个元素的显示
        public override StatusInt OnRedrawOperation(Element el, ViewContext context, out bool canUseCached)
        {
            var result = base.OnRedrawOperation(el, context, out canUseCached);
            this.DgnElemenetSetToolDebug("OnRedrawOperation", canUseCached, result);
            return result;
        }

        // 
        public override void OnResymbolize(ViewContext context)
        {
            base.OnResymbolize(context);
            this.DgnElemenetSetToolDebug("OnResymbolize");
        }

        public override StatusInt OnRedrawComplete(ViewContext context)
        {
            var result = base.OnRedrawComplete(context);
            this.DgnElemenetSetToolDebug("OnRedrawComplete", result);
            return result;
        }
        #endregion
    }
}
