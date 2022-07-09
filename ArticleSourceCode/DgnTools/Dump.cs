using Bentley.DgnPlatformNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticleUtils;

namespace ArticleSourceCode.DgnTools
{
    public static class Dump
    {
        public static void DgnToolDebug(this DgnTool tool, params object[] msgs)
        {
            LogHelper.Debug("DgnTool:" + string.Join("-",msgs));
        }

        public static void DgnPrimitieToolDebug(this DgnPrimitiveTool tool, params object[] msgs)
        {
            LogHelper.Debug("DgnPrimitiveTool:" + string.Join("-", msgs));
        }

        public static void DgnElemenetSetToolDebug(this DgnElementSetTool tool, params object[] msgs)
        {
            LogHelper.Debug("DgnElementSetTool:" + string.Join("-", msgs));
        }
    }
}
