using System.Text;
using System.Runtime.InteropServices;

namespace Utils.Message
{
    /// <summary>
    /// MS 中的输出窗体
    /// </summary>
    public class Console
    {
        [DllImport("ustation.dll")]
        public static extern void mdlDialog_dmsgsPrint(byte[] wMsg);

        public static void WriteLine(string message)
        {
            mdlDialog_dmsgsPrint(Encoding.Unicode.GetBytes(message));
        }
    }
}
