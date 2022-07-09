using Bentley.DgnPlatformNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSourceCode.DgnTools
{
    partial class DgnElementSetToolsTest
    {
        #region 修饰器
        // 用于显示拖动选择动态的十字线或其它形状
        // 只要鼠标运动，就会触发
        protected override void DecorateScreen(Viewport vp)
        {
            // this.DgnToolDebug("DgnTool:DecorateScreen");
        }
        #endregion

        #region 初始化
        // 开始初始化
        protected override bool OnInstall()
        {
            var result = base.OnInstall();
            this.DgnToolDebug("OnInstall", result.ToString());

            return result;
        }

        // 设置工具名称
        protected override string GetToolName()
        {
            this.DgnToolDebug("GetToolName");
            return "DgnPrimitiveToolsTest";
        }

        // 是否生成设置窗体
        // true 代表不生成，由工具本身来生成
        protected override bool PopulateToolSettings()
        {
            var result = base.PopulateToolSettings();
            this.DgnToolDebug("PopulateToolSettings", result.ToString());
            return true;
        }

        // 初始化完成后
        protected override void OnPostInstall()
        {            
            this.DgnToolDebug("OnPostInstall");

            AccuSnap.SnapEnabled = true;
            AccuDraw.Active = true;

            EnableUndoPreviousStep();
        }
        #endregion

        #region 资源释放
        // 调用后，退出当前工具
        protected override void ExitTool()
        {
            this.DgnToolDebug("ExitTool");
        }

        // 当前工具结束时调用，不论什么原因结束，最后都会调用
        protected override void OnCleanup()
        {
            this.DgnToolDebug("OnCleanup");
        }

        // 重置工具到初始化状态，是为了方便操作，仅在 DgnElementSetTool 中可以使用。
        protected override void OnReinitialize()
        {
            this.DgnToolDebug("OnReinitialize");
        }
        #endregion

        #region 鼠标事件
        // 重置键(一般是右键)触发
        protected override bool OnResetButton(DgnButtonEvent ev)
        {
            var result = true;
            this.DgnToolDebug("OnResetButton", "抽象");
            return result;
        }

        // 重置键(一般是右键)弹起后触发
        protected override bool OnResetButtonUp(DgnButtonEvent ev)
        {
            var result = base.OnResetButtonUp(ev);
            this.DgnToolDebug("OnResetButtonUp", result.ToString());
            return result;
        }

        // 数据键(一般是左键)按下时触发
        protected override bool OnDataButton(DgnButtonEvent ev)
        {
            var result = true;
            this.DgnToolDebug("OnDataButton" + "抽象");

            return result;
        }

        // 数据键(一般是左键)弹起时触发
        protected override bool OnDataButtonUp(DgnButtonEvent ev)
        {
            var result = base.OnDataButtonUp(ev);
            this.DgnToolDebug("OnDataButtonUp" + result.ToString());
            return result;
        }

        // 当鼠标在视图中移动时触发，默认返回 false，移动时，会不断触发
        protected override bool OnModelMotion(DgnButtonEvent ev)
        {
            var result = base.OnModelMotion(ev);
            //this.DgnToolDebug("OnModelMotion", result.ToString());
            return result;
        }

        // 当鼠标在视图中停止移动后触发，默认返回 false，只在停止时触发一次
        // stop 之后会频繁触发 OnModelNoMotion
        protected override bool OnModelMotionStopped(DgnButtonEvent ev)
        {
            var result = base.OnModelMotionStopped(ev);
            //this.DgnToolDebug("OnModelMotionStopped", result.ToString());
            return result;
        }

        // 当鼠标在视图中静止时触发，默认返回 false，静止后，会不断触发
        protected override bool OnModelNoMotion(DgnButtonEvent ev)
        {
            var result = base.OnModelNoMotion(ev);
            //this.DgnToolDebug("OnModelNoMotion", result.ToString());
            return result;
        }      

        // 鼠鼠标开始拖拽
        protected override bool OnModelStartDrag(DgnButtonEvent ev)
        {
            var result = base.OnModelStartDrag(ev);
            this.DgnToolDebug("OnModelStartDrag", result.ToString());
            return result;
        }

        // 鼠标结束拖拽
        protected override bool OnModelEndDrag(DgnButtonEvent ev)
        {
            var result = base.OnModelEndDrag(ev);
            this.DgnToolDebug("OnModelEndDrag", result.ToString());
            return result;
        }
        #endregion

        #region 鼠标滚动和键盘事件
        // 鼠标滚动时触发，默认返回 false
        protected override bool OnMouseWheel(DgnMouseWheelEvent ev)
        {
            var result = base.OnMouseWheel(ev);
            this.DgnToolDebug("OnMouseWheel", result.ToString());
            return result;
        }

        // 当 Control，Shift 或 Alt 键被按下和释放时触发。返回 true 来更新视图
        // key 分别代表 SHIFTKEY，CTRLKEY 和 ALTKEY，它们的值分别是 4，8，16
        protected override bool OnModifierKeyTransition(bool wentDown, int key)
        {
            var result = base.OnModifierKeyTransition(wentDown, key);
            this.DgnToolDebug("OnModifierKeyTransition", result.ToString(),wentDown,key);

            GetModifierKeyTransitionState(out var modifierKey, out var modifierKeyWentDown, out var mask);
            this.DgnToolDebug("GetModifierKeyTransitionState", modifierKey, modifierKeyWentDown, mask);

            return result;
        }

        #endregion

        #region 弹出菜单
        // 在右键重置时，触发
        // Called so tool can prevent reset pop-up menu from opening
        // 用于阻止右键菜单弹出
        // 默认为 false
        protected override bool DisableEditAction()
        {
            var result = base.DisableEditAction();
            result = true;
            this.DgnToolDebug("DisableEditAction",result);
            return result;
        }

        // 重写右键弹出菜单，index 代表菜单编号，-1代表不显示。当成功设置后，应返回 `StatusInt.Success`
        protected override StatusInt PerformEditAction(int index)
        {
            var result = base.PerformEditAction(index);
            this.DgnToolDebug("PerformEditAction", result.ToString());
            return result;
        }
        #endregion

        #region 手势相关
        protected override bool OnFlick(DgnFlickEvent ev)
        {
            var result = base.OnFlick(ev);
            this.DgnToolDebug("OnFlick" + result.ToString());
            return result;
        }
        protected override bool OnGesture(DgnGestureEvent ev)
        {
            var result = base.OnGesture(ev);
            this.DgnToolDebug("OnGesture" + result.ToString());
            return result;
        }
        protected override bool OnGestureNotify(IndexedViewport A_0, long A_1)
        {
            var result = base.OnGestureNotify(A_0, A_1);
            this.DgnToolDebug("OnGestureNotify", result.ToString());
            return result;
        }

        protected override int OnTabletQuerySystemGestureStatus(DgnButtonEvent ev)
        {
            var result = base.OnTabletQuerySystemGestureStatus(ev);
            this.DgnToolDebug("OnTabletQuerySystemGestureStatus", result.ToString());
            return result;
        }
        protected override bool OnTouch(DgnTouchEvent ev)
        {
            var result = base.OnTouch(ev);
            this.DgnToolDebug("OnTouch", result.ToString());
            return result;
        }
        #endregion

        #region 未知功能
        protected override bool On3DInputEvent(Dgn3DInputEvent ev)
        {
            var result = base.On3DInputEvent(ev);

            this.DgnToolDebug("On3DInputEvent");

            return result;
        }

        protected override bool OnPreFilterButtonEvent(Viewport __unnamed000, out bool testDefault)
        {
            var result = base.OnPreFilterButtonEvent(__unnamed000, out testDefault);
            this.DgnToolDebug("OnPreFilterButtonEvent", result.ToString());
            return result;
        }
        #endregion
    }
}
