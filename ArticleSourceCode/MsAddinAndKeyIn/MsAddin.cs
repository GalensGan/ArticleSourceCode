using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSourceCode.MsAddinAndKeyIn
{
    /// <summary>
    /// 此类负责在MS加载时预先加载一些内容
    /// </summary>
    [Bentley.MstnPlatformNET.AddInAttribute(MdlTaskID = "MsAddin")]
    public sealed class MsAddin : Bentley.MstnPlatformNET.AddIn
    {
        private MsAddin(IntPtr mdlDescriptor) : base(mdlDescriptor)
        {

        }
        protected override int Run(string[] commandLine)
        {
            System.Windows.Forms.MessageBox.Show("ArticleSourceCode加载成功！");
            return 0;
        }
    }
}
