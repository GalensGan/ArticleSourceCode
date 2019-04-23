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
    
    //下面的一行为该addin的属性,在keyin窗口中可以进行查找到
    [Bentley.MstnPlatformNET.AddInAttribute(MdlTaskID = "ArticleSourceCode")]
    public sealed class MsAddin : Bentley.MstnPlatformNET.AddIn
    {
        //
        public static MsAddin Addin { get; private set; }
        private MsAddin(IntPtr mdlDescriptor) : base(mdlDescriptor)
        {
            Addin = this;
        }
        protected override int Run(string[] commandLine)
        {
            System.Windows.Forms.MessageBox.Show("ArticleSourceCode加载成功！");
            return 0;
        }
    }
}
