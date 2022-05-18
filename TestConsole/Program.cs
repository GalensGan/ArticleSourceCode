using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = @"https://pan.baidu.com/s/1ZN16GCV4NDEp-k2Y4SRNIg?errno=0&errmsg=Auth%20Login%20Sucess&&bduss=&ssnerror=0&traceid=#list/path=%2Fsharelink3291265560-814763208020082%2F2019.03.23-24%20云南丽江&parentPath=%2Fsharelink3291265560-814763208020082/DSC_1135.jpg";//网络文件地址
            if (JudgeFileExist(url))
            { Console.WriteLine("网络文件确实存在！"); }
            else
            { Console.WriteLine("网络文件不存在！"); }
            Console.ReadKey();
        }
        private static bool JudgeFileExist(string url)
        {
            try
            {
                //创建根据网络地址的请求对象
                System.Net.HttpWebRequest httpWebRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.CreateDefault(new Uri(url));
                httpWebRequest.Method = "HEAD";
                httpWebRequest.Timeout = 1000;
                //返回响应状态是否是成功比较的布尔值
                return (((System.Net.HttpWebResponse)httpWebRequest.GetResponse()).StatusCode == System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return false;
            }
        }

    }
}
