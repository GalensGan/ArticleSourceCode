using Bentley.MstnPlatformNET.GUI;
using Bentley.MstnPlatformNET.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticleSourceCode.Adaters
{
    public partial class AdapterTest : 
        //Form
        Adapter, IGuiDockable
    {
        public AdapterTest()
        {
            InitializeComponent();
        }

        public static void ShowDifferentAdapter(string adapterType)
        {
            //根据不同的命令进行不同的加载，同时绑定不同的卸载
            if (adapterType.Contains("tl"))
            {
                AdapterTest f = new AdapterTest();
                f.AttachTL();
                f.Show();
                f.button1.Click += f.DetachTopLevelForm;
            }
            else if (adapterType.Contains("pw"))
            {
                AdapterTest f = new AdapterTest();
                f.AttachPW();
                f.Show();
                f.button1.Click += f.DetachFromPopupWindow;
            }
            else if (adapterType.Contains("ts"))
            {
                AdapterTest f = new AdapterTest();
                f.AttachTS();
                f.Show();
                f.button1.Click += f.DetachFromToolSettings;
            }
            else if (adapterType.Contains("gd"))
            {
                AdapterTest f = new AdapterTest();
                f.AttachGD();
                f.Show();
                f.button1.Click += f.DetachGuiDockable;
            }
            else
            {
                AdapterTest f = new AdapterTest();
                f.AttachTL();
                f.Show();
                f.button1.Click += f.DetachTopLevelForm;
            }

        }
        public void AttachTL()
        {
            this.AttachAsTopLevelForm(MsAddinAndKeyIn.MsAddin.Addin, true, "AttachAsTopLevelForm");
            label1.Text = "AttachAsTopLevelForm";
        }
        public void AttachGD()
        {
            this.AttachAsGuiDockable(MsAddinAndKeyIn.MsAddin.Addin, "AttachAsGuiDockable");
            label1.Text = "AttachAsGuiDockable";
        }
        public void AttachTS()
        {
            this.AttachToToolSettings(MsAddinAndKeyIn.MsAddin.Addin);
            label1.Text = "AttachToToolSettings";
        }
        public void AttachPW()
        {
            this.AttachToPopupWindow(MsAddinAndKeyIn.MsAddin.Addin);
            label1.Text = "AttachToPopupWindow";
        }
        public bool GetDockedExtent(GuiDockPosition dockPosition, ref GuiDockExtent extentFlag, ref Size dockSize)
        {
            return true;
        }
        
        public bool WindowMoving(WindowMovingCorner corner, ref Size newSize)
        {
            newSize = this.Size;
            return true;
        }

        public void DetachFromMicroStation(object sender, EventArgs e)
        {
            this.DetachFromMicroStation();
        }
        public void DetachFromPopupWindow(object sender, EventArgs e)
        {
            this.DetachFromPopupWindow();
        }
        public void DetachFromToolSettings(object sender, EventArgs e)
        {
            this.DetachFromToolSettings();
        }
        public void DetachGuiDockable(object sender, EventArgs e)
        {
            this.DetachGuiDockable();
        }
        public void DetachTopLevelForm(object sender, EventArgs e)
        {
            this.DetachTopLevelForm();
        }

    }
}
