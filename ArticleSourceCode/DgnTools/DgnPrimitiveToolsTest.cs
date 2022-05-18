using Bentley.DgnPlatformNET;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSourceCode.DgnTools
{
    class DgnPrimitiveToolsTest : DgnPrimitiveTool
    {
        private ILog _logger = log4net.LogManager.GetLogger(typeof(DgnPrimitiveToolsTest));
        public DgnPrimitiveToolsTest() : base(0, 0) {

            _logger.Info("-----------------------------dgnPrimitiveToolsTest begin--------------------------");
        }

        #region DngTool
        //public int ToolPromptResourceId { get; set; }
        //public int ToolId { get; set; }

        //public static DgnPrimitiveTool GetActivePrimitiveTool();       
        //public DgnButtonEvent GetCurrentDgnButtonEvent();
        //public void GetModifierKeyTransitionState(out int modifierKey, out bool modifierKeyWentDown, out uint currentQualifierMask);
        //public StatusInt InstallTool();
        //public void ResetCurrentQualifierMask(uint mask);
        //public void SetAdjustedDataPoint(DgnButtonEvent ev);
        //public void SetModifierKeyTransitionState(int modifierKey, bool modifierKeyWentDown, uint currentQualifierMask);

        // 用于显示拖动选择动态的十字线或其它形状
        // 只要鼠标运动，就会触发
        protected override void DecorateScreen(Viewport vp)
        {
            //_logger.InfoFormat("{0}-{1}","DgnTool", "DecorateScreen");
        }

        // 在右键重置时，触发
        // Called so tool can prevent reset pop-up menu from opening
        // 用于阻止右键菜单弹出
        // 默认为 false
        protected override bool DisableEditAction()
        {
            var result = base.DisableEditAction();
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "DisableEditAction", "baseValue", result.ToString());
            return true;
        }
        protected override void ExitTool()
        {
           _logger.InfoFormat("{0}-{1}","DgnTool", "ExitTool");
        }
        protected override string GetToolName()
        {
           _logger.InfoFormat("{0}-{1}","DgnTool", "GetToolName");
            return "DgnPrimitiveToolsTest";
        }
        protected override bool On3DInputEvent(Dgn3DInputEvent ev)
        {
            var result = base.On3DInputEvent(ev);
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "On3DInputEvent", "baseValue", result.ToString());

            return result;
        }
        protected override void OnCleanup()
        {
           _logger.InfoFormat("{0}-{1}","DgnTool", "OnCleanup");
        }
        protected override bool OnDataButton(DgnButtonEvent ev)
        {
            var result = true;
           _logger.InfoFormat("{0}-{1}-{2}","DgnTool", "OnDataButton", "抽象");

            return result;
        }
        protected override bool OnDataButtonUp(DgnButtonEvent ev)
        {
            var result = base.OnDataButtonUp(ev);
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnDataButtonUp", "baseValue", result.ToString());
            return result;
        }
        protected override bool OnFlick(DgnFlickEvent ev)
        {
            var result = base.OnFlick(ev);
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnFlick", "baseValue", result.ToString());
            return result;
        }
        protected override bool OnGesture(DgnGestureEvent ev)
        {
            var result = base.OnGesture(ev);
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnGesture", "baseValue", result.ToString());
            return result;
        }
        protected override bool OnGestureNotify(IndexedViewport A_0, long A_1)
        {
            var result = base.OnGestureNotify(A_0, A_1);
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnGestureNotify", "baseValue", result.ToString());
            return result;
        }
        protected override bool OnInstall()
        {
            var result = base.OnInstall();
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnInstall", "baseValue", result.ToString());
            return result;
        }

        // 结束拖拽
        protected override bool OnModelEndDrag(DgnButtonEvent ev)
        {
            var result = base.OnModelEndDrag(ev);
           //_logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnModelEndDrag", "baseValue", result.ToString());
            return result;
        }

        // 鼠标移动
        protected override bool OnModelMotion(DgnButtonEvent ev)
        {
            var result = base.OnModelMotion(ev);
           //_logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnModelMotion", "baseValue", result.ToString());
            return result;
        }

        // 鼠标停止移动
        protected override bool OnModelMotionStopped(DgnButtonEvent ev)
        {
            var result = base.OnModelMotionStopped(ev);
           //_logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnModelMotionStopped", "baseValue", result.ToString());
            return result;
        }


        protected override bool OnModelNoMotion(DgnButtonEvent ev)
        {
            var result = base.OnModelNoMotion(ev);
           //_logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnModelNoMotion", "baseValue", result.ToString());
            return result;
        }

        // 鼠标停止拖拽
        protected override bool OnModelStartDrag(DgnButtonEvent ev)
        {
            var result = base.OnModelStartDrag(ev);
           //_logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnModelStartDrag", "baseValue", result.ToString());
            return result;
        }

        protected override bool OnModifierKeyTransition(bool wentDown, int key)
        {
            var result = base.OnModifierKeyTransition(wentDown, key);
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnModifierKeyTransition", "baseValue", result.ToString());
            return result;
        }
        protected override bool OnMouseWheel(DgnMouseWheelEvent ev)
        {
            var result = base.OnMouseWheel(ev);
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnMouseWheel", "baseValue", result.ToString());
            return result;
        }
        protected override void OnPostInstall()
        {
           _logger.InfoFormat("{0}-{1}","DgnTool", "OnMouseWheel");
        }
        protected override bool OnPreFilterButtonEvent(Viewport __unnamed000, out bool testDefault)
        {
            var result = base.OnPreFilterButtonEvent(__unnamed000, out testDefault);
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnPreFilterButtonEvent", "baseValue", result.ToString());
            return result;
        }
        protected override void OnReinitialize()
        {
           _logger.InfoFormat("{0}-{1}","DgnTool", "OnReinitialize");
        }
        protected override bool OnResetButton(DgnButtonEvent ev)
        {
            var result = true;
           _logger.InfoFormat("{0}-{1}-{2}","DgnTool", "OnResetButton", "抽象");
            return result;
        }
        protected override bool OnResetButtonUp(DgnButtonEvent ev)
        {
            var result = base.OnResetButtonUp(ev);
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnResetButtonUp", "baseValue", result.ToString());
            return result;
        }
        protected override int OnTabletQuerySystemGestureStatus(DgnButtonEvent ev)
        {
            var result = base.OnTabletQuerySystemGestureStatus(ev);
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnTabletQuerySystemGestureStatus", "baseValue", result.ToString());
            return result;
        }
        protected override bool OnTouch(DgnTouchEvent ev)
        {
            var result = base.OnTouch(ev);
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "OnTouch", "baseValue", result.ToString());
            return result;
        }
        protected override StatusInt PerformEditAction(int index)
        {
            var result = base.PerformEditAction(index);
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "PerformEditAction", "baseValue", result.ToString());
            return result;
        }
        protected override bool PopulateToolSettings()
        {
            var result = base.PopulateToolSettings();
           _logger.InfoFormat("{0}-{1}-{2}-{3}","DgnTool", "PopulateToolSettings", "baseValue", result.ToString());
            return result;
        }
        #endregion

        #region PrimitiveTool
        //protected internal bool DynamicsStarted { get; }

        protected override void BeginDynamics() {
           _logger.InfoFormat("{0}-{1}","Primitive", "BeginDynamics");
        }
        protected override bool CheckSingleShot() {
            var result = base.CheckSingleShot();
           _logger.InfoFormat("{0}-{1}-{2}-{3}","Primitive", "CheckSingleShot", "baseValue", result.ToString());
            return result;
        }
        //protected internal void EnableUndoPreviousStep();
        protected override void EndDynamics() {
           _logger.InfoFormat("{0}-{1}","Primitive", "BeginDynamics");
        }
        //protected override void ExitTool() {}
        protected override IDrawElementAgenda GetDrawDynamicsTxnChanges() {
            var result = base.GetDrawDynamicsTxnChanges();
           _logger.InfoFormat("{0}-{1}-{2}-{3}","Primitive", "GetDrawDynamicsTxnChanges", "baseValue", result.ToString());
            return result;
        }
        protected override bool IsSingleShot() {
            var result = base.IsSingleShot();
           _logger.InfoFormat("{0}-{1}-{2}-{3}","Primitive", "IsSingleShot", "baseValue", result.ToString());
            return result;
        }
        protected override void OnDynamicFrame(DgnButtonEvent ev) {
           _logger.InfoFormat("{0}-{1}","Primitive", "OnDynamicFrame");
        }
        // protected override void OnReinitialize() { }
        protected override void OnRestartTool() {
           _logger.InfoFormat("{0}-{1}","Primitive", "OnRestartTool");
        }
        protected override void OnUndoPreviousStep() {
           _logger.InfoFormat("{0}-{1}","Primitive", "OnUndoPreviousStep");
        }
        #endregion
    }
}
