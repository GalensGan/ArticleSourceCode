using Bentley.MstnPlatformNET;
using MSAddinTest.MSTestInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSourceCode.AddinAndKeyIn
{
    /// <summary>
    /// 此类负责在MS加载时预先加载一些内容
    /// </summary>
    
    //下面的一行为该addin的属性,在keyin窗口中可以进行查找到
    [AddIn(MdlTaskID = "ArticleSourceCode")]
    public sealed class MsAddin : MSTest_Addin
    {
        //
        public static AddIn Addin { get; private set; }
        public MsAddin(IntPtr mdlDescriptor) : base(mdlDescriptor)
        {
            // Addin = this;
        }
        protected override int Run(string[] commandLine)
        {            
            return 0;
        }

        public override void Init(AddIn addIn)
        {
            Addin = addIn;
            Run(new string[] { });
        }
    }
}
