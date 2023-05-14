using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using APMPublicLib.Common;
using APMPublicLib.InterfaceOutline;
using System.Runtime.InteropServices;
using System.Timers;
using System.Diagnostics;
using System.Xml.XPath;
using System.Reflection;
using APMPublicLib.APMFile;
using System.Collections;
using System.Xml;
using System.IO;
using System.Net;

public partial class APMMain : APMBaseForm
{
        private Dictionary<string, APMMenuInfos> menuList = new Dictionary<string, APMMenuInfos>();
        private Dictionary<string, APMMainServerInfo> _serverAvailableList = new Dictionary<string, APMMainServerInfo>();
        private Dictionary<string, APMMultipleRedisManager> ____redis = new Dictionary<string, APMMultipleRedisManager>();

	string MarketID = "1";
	int menuIndexs = 0;

        public class APMMainServerInfo
        {
            public APMMainServerInfo(string servername, string serverIpaddress, string serverPortNo, string symbol)
            {
                this.serverName = servername;
                this.serverIpaddress = serverIpaddress;
                this.serverPortNo = serverPortNo;
                this.symbol = symbol;
            }
            public APMMainServerInfo(APMMainServerInfo serverinfo)
            {
                this.serverName = serverinfo.serverName;
                this.serverIpaddress = serverinfo.serverIpaddress;
                this.serverPortNo = serverinfo.serverPortNo;
                this.symbol = serverinfo.symbol;
            }
            public string serverName { get; set; }  // 사용될 서버명
            public string symbol { get; set; }      // 사용될 서버 Symbol 1 2 4 8 16 32 64
            public string serverIpaddress { get; set; }
            public string serverPortNo { get; set; }
        }

        public class APMLiteServerInfo
        {
            public string serverName { get; set; }  // 사용될 서버명
            public string symbol { get; set; }      // 사용될 서버 Symbol
            public string serverIpaddress { get; set; }
            public string serverPortNo { get; set; }
        }

#if(true)
        protected override bool ProcessCmdKey(ref Message m, Keys keyData)
	{
	        const int WM_KEYDOWN = 0x0100;

		if(m.Msg==WM_KEYDOWN)
		{
			switch(keyData.ToString())
			{
				case "Escape":
					Application.Exit();
					break;
			}
		}

		return base.ProcessCmdKey(ref m, keyData);
	}
#endif
#if(true)
        // <summary>
        /// 윈도우 프로시저 처리하기
        /// </summary>
        /// <param name="message">메시지</param>
        protected override void WndProc(ref Message message)
        {
            switch(message.Msg)
            {
                case APMApiPublic.WM_CREATE:

                    this.Top  = 100;
                    this.Left = 100;
		    this.Width = 1000;
		    this.Height = 500;

                    break;

                default:

                    break;

            }

            base.WndProc(ref message);
        }
#endif
        public APMMain()
        {
            InitializeComponent();
            LoadServerXML();
	    InitMenus();
        }

	private void LoadServerXML()
        {
            string xmlFileName = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\" + "ServerInfo.xml";
            XmlDocument xml = new XmlDocument();
            xml.Load(xmlFileName);
            XmlElement root = xml.DocumentElement;
            XmlNodeList nl = root.SelectNodes("/APM");
            XmlNodeList xnList = xml.SelectNodes("/APM/ServerInfo/Server");
            foreach (XmlNode server in xnList)
            {
                string ServerName = server.SelectSingleNode("Name").InnerText;
                string ServerIP = server.SelectSingleNode("Ip").InnerText;
                string ServerPort = server.SelectSingleNode("Port").InnerText;
                string ServerSymbol = server.SelectSingleNode("Symbol").InnerText;

		int kk = ServerName.IndexOf("가동");
		if(kk>=0)
		{
		    _serverAvailableList.Add(ServerSymbol, new APMMainServerInfo(ServerName, ServerIP, ServerPort, ServerSymbol));
		    APMMultipleRedisManager apmMultipleRedisManager = new APMMultipleRedisManager();
                    apmMultipleRedisManager.Init(ServerIP, ServerPort, ServerSymbol, ServerName);
                    ____redis.Add(ServerIP + ":" + ServerPort, apmMultipleRedisManager);
		}


		    

                /*
                if(ServerName.Contains(APMMemory.GetInstance.ServerCategory))
                    _serverAvailableList.Add(ServerSymbol, new APMMainServerInfo(ServerName, ServerIP, ServerPort, ServerSymbol));
		*/
            }
        }
	private void InitMenus()
        {
            XPathDocument xml = new XPathDocument("Menu.xml");
            var nav = xml.CreateNavigator();
            foreach (XPathNavigator item in nav.Select("/Menu/MenuItem"))
            {
                System.Windows.Forms.ToolStripMenuItem menu = new System.Windows.Forms.ToolStripMenuItem();
                menu.Name = item.SelectSingleNode("@header").Value;
                menu.Size = new System.Drawing.Size(77, 20);
                menu.Text = item.SelectSingleNode("@header").Value;

                if (item.SelectSingleNode("@market") != null)
                {
                    string marketLevel = item.SelectSingleNode("@market").Value;

                    string tmpLevel = Convert.ToString(Convert.ToInt32(marketLevel), 2).PadLeft(5, '0');
                    if (tmpLevel.Substring(5 - Convert.ToInt32(MarketID), 1) != "1")
                    {
                        continue;
                    }
                }

                if (item.SelectSingleNode("@id") != null)
                {
                    menu.Name = item.SelectSingleNode("@id").Value;
                    menu.Click += new System.EventHandler(menu_Click);

                    AddMenuInfo(item);
                }
                if (item.HasChildren)
                {
                    AddMenu(menu, item);
                }

                MNU_MainMenu.Items.Insert(menuIndexs++, menu);
            }
        }

        private void AddMenu(System.Windows.Forms.ToolStripMenuItem menu, XPathNavigator item)
        {
            foreach (XPathNavigator itemChild in item.Select("MenuItem"))
            {
                System.Windows.Forms.ToolStripMenuItem subMenu = new System.Windows.Forms.ToolStripMenuItem();
                subMenu.Name = itemChild.SelectSingleNode("@header").Value;
                subMenu.Size = new System.Drawing.Size(77, 20);
                subMenu.Text = itemChild.SelectSingleNode("@header").Value;

                if (itemChild.SelectSingleNode("@market") == null)
                {
                    if (subMenu.ToString() == "청산" && _serverAvailableList.Count != 7)
                    {
                        break;
                    }
                    if (itemChild.HasChildren)
                        AddMenu(subMenu, itemChild);
                    menu.DropDownItems.Add(subMenu);
                    continue;
                }
                string marketLevel = itemChild.SelectSingleNode("@market").Value;
                string tmpLevel = Convert.ToString(Convert.ToInt32(marketLevel), 2).PadLeft(5, '0');

                if (_serverAvailableList.Count >= Convert.ToString(Int32.Parse(itemChild.SelectSingleNode("@market").Value), 2).Length)
                {
                    if (itemChild.SelectSingleNode("@id") != null)
                    {
                        if (itemChild.SelectSingleNode("@symbol") == null) // symbol 없을 때
                        {
                            if (itemChild.SelectSingleNode("@market").Value != null && itemChild.SelectSingleNode("@onlymenu") == null)
                            {
                                subMenu.Tag = _serverAvailableList[itemChild.SelectSingleNode("@market").Value];
                            }
                        }
                        else // symbol 있을 때
                        {
                            APMMainServerInfo tempServerInfo = new APMMainServerInfo(_serverAvailableList[itemChild.SelectSingleNode("@market").Value]);
                            tempServerInfo.symbol = itemChild.SelectSingleNode("@symbol").Value;
                            subMenu.Tag = tempServerInfo;
                        }


                        subMenu.Name = itemChild.SelectSingleNode("@id").Value;
                        subMenu.Click += new System.EventHandler(menu_Click);
                        AddMenuInfo(itemChild);
                    }
                }
                if (_serverAvailableList.Count >= Convert.ToString(Int32.Parse(itemChild.SelectSingleNode("@market").Value), 2).Length)
                {

                    if (itemChild.HasChildren)
                    {
                        AddMenu(subMenu, itemChild);
                    }
                    menu.DropDownItems.Add(subMenu);
                }
            }
        
        }
        private APMMainServerInfo serverMapping(string symbol)
        {
            return _serverAvailableList[symbol];
        }
        private void menu_Click(object sender, EventArgs e)
        {
            string subForm = ((ToolStripMenuItem)sender).Name.ToString();
            string title = ((ToolStripMenuItem)sender).Text.ToString();
            APMMainServerInfo serverInfo = ((APMMainServerInfo)((ToolStripMenuItem)sender).Tag);

            string serverName = string.Empty;
            string ipAddress = string.Empty;
            string portNo = string.Empty;
            string symbol = string.Empty;

            if (serverInfo != null)
            {
                serverName = serverInfo.serverName;
                ipAddress = serverInfo.serverIpaddress;
                portNo = serverInfo.serverPortNo;
                symbol = serverInfo.symbol;
            }

            LoadForm(subForm, title, MarketID, symbol, serverName, ipAddress, portNo);
        }

        private void AddMenuInfo(XPathNavigator item)
        {
            if (item.SelectSingleNode("@id") == null || menuList.ContainsKey(item.SelectSingleNode("@id").Value)) return;

            APMMenuInfos menuInfo = new APMMenuInfos();
            menuInfo.id = item.SelectSingleNode("@id").Value;
            menuInfo.title = (item.SelectSingleNode("@header") != null) ? item.SelectSingleNode("@header").Value : string.Empty;
            menuInfo.marketID = (item.SelectSingleNode("@market") != null) ? item.SelectSingleNode("@market").Value : string.Empty;
            menuInfo.symbol = (item.SelectSingleNode("@symbol") != null) ? item.SelectSingleNode("@symbol").Value : string.Empty;
            menuInfo.grade = (item.SelectSingleNode("@grade") != null) ? item.SelectSingleNode("@grade").Value : string.Empty;
            menuInfo.size = (item.SelectSingleNode("@size") != null) ? (item.SelectSingleNode("@size").Value.ToUpper() == "FALSE") ? false : true : true;

            menuList.Add(item.SelectSingleNode("@id").Value, menuInfo);
        }

        private Form LoadForm(string formName, string title, string marketid, string symbol, string serverName, string ipAddress, string portNo)
        {
            title += " [ " + serverName + "/ " + ipAddress + ":" + portNo + " ]";

            bool size = true;

            string ipPort = ipAddress + ":" + portNo;

            if (!____redis.ContainsKey(ipPort))
            {
                APMMultipleRedisManager apmMultipleRedisManager = new APMMultipleRedisManager();
                apmMultipleRedisManager.Init(ipAddress, portNo, symbol, serverName);
                ____redis.Add(ipPort, apmMultipleRedisManager);
            }

            APMMultiChildBaseForm childForm = null;

            childForm = new APMMultiChildBaseForm(this, formName, title, size, marketid, symbol, serverName, ipAddress, portNo, ____redis[ipPort]);

            childForm.MdiParent = this;
            childForm.Text = title;

            int style;
            style = APMApiPublic.GetWindowLong(childForm.Handle, APMApiPublic.GWL_STYLE);

            APMApiPublic.WindowStyle myStyle = (APMApiPublic.WindowStyle)style;
            myStyle = myStyle & ~APMApiPublic.WindowStyle.WS_SYSMENU;
            style = APMApiPublic.SetWindowLong(childForm.Handle, APMApiPublic.GWL_STYLE, (int)myStyle);

	    childForm.Left = 50;
	    childForm.Top = 50;
	    childForm.Width = Convert.ToInt32(APMCommonMemory.GetInstance.Width);
	    childForm.Height = Convert.ToInt32(APMCommonMemory.GetInstance.Height);

	    Console.WriteLine("(APMMain)(LoadForm):" + childForm.Left + "/" + childForm.Left + "/" + childForm.Width + "/" + childForm.Height);

            return childForm;
        }
}
