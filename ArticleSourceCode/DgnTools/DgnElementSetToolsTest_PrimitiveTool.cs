using Bentley.DgnPlatformNET;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSourceCode.DgnTools
{
    partial class DgnElementSetToolsTest
    {

        public DgnElementSetToolsTest(int toolId) : base(toolId, 0)
        {            
            this.DgnPrimitieToolDebug("----------------------------- dgnPrimitiveToolsTest begin --------------------------");
        }

        #region 动态显示
        //protected internal bool DynamicsStarted
        protected override void BeginDynamics()
        {
            
            this.DgnPrimitieToolDebug("BeginDynamics");
        }

        //protected internal void EnableUndoPreviousStep();
        protected override void EndDynamics()
        {
            this.DgnPrimitieToolDebug("BeginDynamics");
        }

        // Query if the tool wants to control how to draw changes made in the nested transaction during a dynamics frame. 
        // 用于控制动态显示逻辑的，一般不使用
        protected override IDrawElementAgenda GetDrawDynamicsTxnChanges()
        {
            var result = base.GetDrawDynamicsTxnChanges();
            this.DgnPrimitieToolDebug("GetDrawDynamicsTxnChanges", result.ToString());
            return result;
        }

        // 在里面进行动态元素显示的处理
        protected override void OnDynamicFrame(DgnButtonEvent ev)
        {
            this.DgnPrimitieToolDebug("OnDynamicFrame");
        }
        #endregion

        #region 单次触发，已失效
        protected override bool CheckSingleShot()
        {
            var result = base.CheckSingleShot();
            this.DgnPrimitieToolDebug("CheckSingleShot", result.ToString());
            return true;
        }


        protected override bool IsSingleShot()
        {
            var result = base.IsSingleShot();
            this.DgnPrimitieToolDebug("IsSingleShot", result.ToString());
            return result;
        }
        #endregion

        // protected override void OnReinitialize() { }
        protected override void OnRestartTool()
        {
            this.DgnPrimitieToolDebug("OnRestartTool");
        }

        #region 回退
        protected override void OnUndoPreviousStep()
        {
            this.DgnPrimitieToolDebug("OnUndoPreviousStep");
        }
        #endregion

    }
}
