using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bentley.DgnPlatformNET;

namespace ArticleSourceCode.MessageManager
{
    public partial class MessageHandleForm : Form
    {
        //启动窗体
        public static void InstallNewInstance()
        {
            MessageHandleForm f = new MessageHandleForm();
            f.Show();
            f.BringToFront();
        }
        private MessageHandleForm()
        {
            InitializeComponent();
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            switch (cb.SelectedIndex)
            {
                case 0:
                    NotificationManagerOpenMessageBox();
                    break;
                case 1:
                    NotificationManagerOutputMessage();
                    break;
                case 2:
                    NotificationManagerOutputPrompt();
                    break;
                default:
                    MessageCenterShowInfoMessage();
                    break;
            }
        }
        private void NotificationManagerOpenMessageBox()
        {
            NotificationManager.OpenMessageBox(NotificationManager.MessageBoxType.MediumAlert, "Medium alert",NotificationManager.MessageBoxIconType.Warning);
        }
        private void NotificationManagerOutputMessage()
        {
            OutputMessagePriority outputMessagePriority = OutputMessagePriority.Information;
            string briefMsg = "this is a brief msg";
            string detailMsg = "this is a detail msg";
            NotifyTextAttributes notifyTextAttributes = NotifyTextAttributes.AlwaysBeveled;
            NotifyMessageDetails notifyMessageDetails = new NotifyMessageDetails(outputMessagePriority,briefMsg,detailMsg,notifyTextAttributes,OutputMessageAlert.Balloon);
            NotificationManager.OutputMessage(notifyMessageDetails);            
        }
        private void NotificationManagerOutputPrompt()
        {
            NotificationManager.OutputPrompt("this is ouput prompt");
        }

        private void MessageCenterShowInfoMessage()
        {
          string str=  Bentley.MstnPlatformNET.MessageCenter.GetStringFromMessageListResource(0, 0);
        }
    }
}
