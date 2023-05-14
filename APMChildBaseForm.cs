using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using APMPublicLib.Common;
using System.Runtime.InteropServices;
using APMPublicLib.InterfaceOutline;
using System.Reflection;

public partial class APMChildBaseForm : Form
{
        private Form form = null;

        private int topMargin = 0;
        private int yMargin = 0;
        private int gap = 0;
        private int captionSize = 0;

        public Form parentForm = null;
        private string subFormName = string.Empty;
        private string subFormTitle = string.Empty;
        private string subMarketID = string.Empty;
        private string subFormSymbol = string.Empty;
        private string serverName = string.Empty;
        private string ipAddress = string.Empty;
        private string portNo = string.Empty;
        private bool subFormSize = true;

        Color foreColor = Color.FromArgb(1, 144, 190);

        /*Redis 관련 추가*/
        private APMMultipleRedisManager apmRedis;
        private Dictionary<string, APMMultipleRedisManager> dicApmRedis;

        public APMChildBaseForm(Form parent, string subFormName, string title, bool size, string marketid, string symbol, string servername, string ipaddress, string portno, APMMultipleRedisManager apmLiteRedismanager, Dictionary<string, APMMultipleRedisManager> apmLiteRedismanagers = null )
        {
            this.parentForm = parent;
            this.subFormName = subFormName;
            this.subFormTitle = title;
            this.subMarketID = marketid;
            this.subFormSymbol = symbol;
            this.subFormSize = size;
            this.serverName = servername;
            this.ipAddress = ipaddress;
            this.portNo = portno;
            this.apmRedis = apmLiteRedismanager;
            this.dicApmRedis = apmLiteRedismanagers;

            InitializeComponent();

            topMargin = Height - ClientSize.Height - (Width - ClientSize.Width) / 2;
            captionSize = Height - ClientSize.Height - (Width - ClientSize.Width);
            yMargin = (Width - ClientSize.Width) / 2;
            gap = 2;

            try
            {
	        int x1,y1,x2,y2;

                x1 = gap + 4;
		y1 = gap;
		x2 = Width - gap - 4;
		y2 = Height - gap - 4;

		APMCommonMemory.GetInstance.____Width = x2.ToString();
		APMCommonMemory.GetInstance.____Height = y2.ToString();
		Console.WriteLine("(APMChildBaseForm)(APMChildBaseForm):" + Width + "/" + Height);
		Console.WriteLine("(APMChildBaseForm)(APMChildBaseForm):" + x1 + "/" + y1 + "/" + x2 + "/" + y2);

                Region = System.Drawing.Region.FromHrgn(APMApiPublic.CreateRectRgn(x1, y1, x2, y2));

                string dllName = subFormName.Substring(3, 3);
                string assembly = dllName + ".DLL";
                string className = dllName + "." + subFormName;

                APMPublicLib.Common.APMFileInfos fi = new APMPublicLib.Common.APMFileInfos();
                fi.form = this;
                fi.sdiCheck = false;
                fi.parentForm = parent;     // APM Main
                try
                {
                    Assembly asm = Assembly.LoadFrom(assembly);
                    object o = asm.CreateInstance(className);
                    form = (Form)o;
                    if (form == null) return;
                    form.Text = "[" + subFormName + "]" + subFormTitle;
                    form.TopLevel = false;
                    form.Parent = this;
                    form.Tag = fi;
                    //form.MaximumSize = MaximumSize;
                    form.Dock = DockStyle.Fill;

                    ClientSize = new Size(form.Width, form.Height);
                    // 초기값전달 (Parent Form, 마켓ID, 시장구분)
                    object[] ob = { parentForm, subMarketID, subFormSymbol, apmRedis, dicApmRedis };
                    Type type = form.GetType();
                    MethodInfo mi = type.GetMethod("Startup");
                    mi.Invoke(form, new object[] { ob });

                    Tag = "OPEN";
                    form.Show();

                    // 화면 Size변경 옵션이 FALSE인 경우 Size 변경을 할 수없도록 MAX Size와 Min Size를 고정한다
                    if (!subFormSize)
                    {
                        MinimumSize = MaximumSize = Size;
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(className + "Not Found!!!, Exception:" + exp.Message);
                    Tag = "OPEN";
                    Close();
                }
            }
            catch (Exception e)
            {
	        Console.WriteLine("Exception:" + e.Message);
            }
        }
}

