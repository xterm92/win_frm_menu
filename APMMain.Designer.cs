partial class APMMain
{
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
	private void InitializeComponent()
        {
	    this.IsMdiContainer = true;

	    this.MNU_MainMenu = new System.Windows.Forms.MenuStrip();
            this.MNU_MainMenu.SuspendLayout();
       
            // MNU_MainMenu
            this.MNU_MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MNU_MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MNU_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MNU_MainMenu.Name = "MNU_MainMenu";
            this.MNU_MainMenu.Size = new System.Drawing.Size(63, 24);
            this.MNU_MainMenu.TabIndex = 2;
            this.MNU_MainMenu.ResumeLayout(false);
            this.MNU_MainMenu.PerformLayout();

	    this.Controls.Add(this.MNU_MainMenu);
	    this.ResumeLayout(false);
	}
        private System.Windows.Forms.MenuStrip MNU_MainMenu;

#if(false)
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APMMain));
            this.mainToolbarPanel = new System.Windows.Forms.Panel();
            this.mainToolbarOpenWindowPanel = new APMPublicLib.Common.APMOpenWndToolbarPanel(this.components);
            this.mainToolbarPanelTop = new System.Windows.Forms.Panel();
            this.toolbatSetupBtn = new APMPublicLib.Common.APMPictureButton(this.components);
            this.mainTopPanel = new System.Windows.Forms.Panel();
            this.mainSystemButtonPanel = new System.Windows.Forms.Panel();
            this.mainCloseBtn = new APMPublicLib.Common.APMPictureButton(this.components);
            this.mainMaxBtn = new APMPublicLib.Common.APMPictureButton(this.components);
            this.mainMinBtn = new APMPublicLib.Common.APMPictureButton(this.components);
            this.mainCaptionRightPanel = new System.Windows.Forms.Panel();
            this.mainIconPictureBox = new System.Windows.Forms.PictureBox();
            this.mainCaptionLeftPanel = new System.Windows.Forms.Panel();
            this.MNU_MainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPasswordChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertPopupViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPMInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바둑판정렬ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.serverInfoComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.AlertMsgInfoPanel = new System.Windows.Forms.PictureBox();
            this.ProcessMsgInfoPanel = new System.Windows.Forms.PictureBox();
            this.LogMsgInfoPanel = new System.Windows.Forms.PictureBox();
            this.EventMsgInfoPanel = new System.Windows.Forms.PictureBox();
            this.sendInfoPanel = new System.Windows.Forms.PictureBox();
            this.recvInfoPanel = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.LSV_Pms1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_Pms2 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_Pms3 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_Pms4 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_Pms5 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_Pms6 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_Pms7 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel9 = new System.Windows.Forms.Panel();
            this.LSV_MSG_Message1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Message2 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Message3 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Message4 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Message5 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Message6 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Message7 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.alertTopPanel = new System.Windows.Forms.Panel();
            this.alertTitlePicture = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.LSV_MSG_Event1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Event2 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Event3 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Event4 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Event5 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Event6 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Event7 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.eventTopPanel = new System.Windows.Forms.Panel();
            this.eventTitlePicture = new System.Windows.Forms.PictureBox();
            this.eventLeftPicture = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LSV_MSG_Log1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Log2 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Log3 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Log4 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Log5 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Log6 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Log7 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.logTopPanel = new System.Windows.Forms.Panel();
            this.logTitlePicture = new System.Windows.Forms.PictureBox();
            this.logLeftPicture = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LSV_MSG_Process1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Process2 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Process3 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Process4 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Process5 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Process6 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.LSV_MSG_Process7 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.processTopPanel = new System.Windows.Forms.Panel();
            this.processTitlePicture = new System.Windows.Forms.PictureBox();
            this.processLeftPicture = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.alertPopupPanel = new System.Windows.Forms.Panel();
            this.alertPopupPanelCloseBtn = new APMPublicLib.Common.APMPictureButton(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeMainView1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.treeMainView2 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.treeMainView3 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.treeMainView4 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.treeMainView5 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.treeMainView6 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.treeMainView7 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel10 = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.mainToolbarPanel.SuspendLayout();
            this.mainToolbarPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolbatSetupBtn)).BeginInit();
            this.mainTopPanel.SuspendLayout();
            this.mainSystemButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMaxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMinBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIconPictureBox)).BeginInit();
            this.MNU_MainMenu.SuspendLayout();
            this.mainStatusPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlertMsgInfoPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessMsgInfoPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogMsgInfoPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventMsgInfoPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendInfoPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recvInfoPanel)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms7)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message7)).BeginInit();
            this.alertTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertTitlePicture)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event7)).BeginInit();
            this.eventTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventTitlePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLeftPicture)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log7)).BeginInit();
            this.logTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logTitlePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLeftPicture)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process7)).BeginInit();
            this.processTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processTitlePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processLeftPicture)).BeginInit();
            this.alertPopupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertPopupPanelCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView7)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolbarPanel
            // 
            this.mainToolbarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainToolbarPanel.Controls.Add(this.mainToolbarOpenWindowPanel);
            this.mainToolbarPanel.Controls.Add(this.mainToolbarPanelTop);
            this.mainToolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainToolbarPanel.Location = new System.Drawing.Point(0, 28);
            this.mainToolbarPanel.Name = "mainToolbarPanel";
            this.mainToolbarPanel.Size = new System.Drawing.Size(1264, 51);
            this.mainToolbarPanel.TabIndex = 7;
            // 
            // mainToolbarOpenWindowPanel
            // 
            this.mainToolbarOpenWindowPanel.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.mainToolbarOpenWindowPanel.ButtonDisableImage = null;
            this.mainToolbarOpenWindowPanel.ButtonDownImage = null;
            this.mainToolbarOpenWindowPanel.ButtonForeColor = System.Drawing.Color.Black;
            this.mainToolbarOpenWindowPanel.ButtonOverForeColor = System.Drawing.Color.Black;
            this.mainToolbarOpenWindowPanel.ButtonOverImage = null;
            this.mainToolbarOpenWindowPanel.ButtonText = "";
            this.mainToolbarOpenWindowPanel.ButtonToolTipText = "";
            this.mainToolbarOpenWindowPanel.ButtonUpImage = null;
            this.mainToolbarOpenWindowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainToolbarOpenWindowPanel.Font = new System.Drawing.Font("굴림체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.mainToolbarOpenWindowPanel.Location = new System.Drawing.Point(0, 25);
            this.mainToolbarOpenWindowPanel.MenuButtonDisableImage = null;
            this.mainToolbarOpenWindowPanel.MenuButtonDownImage = null;
            this.mainToolbarOpenWindowPanel.MenuButtonOverImage = null;
            this.mainToolbarOpenWindowPanel.MenuButtonUpImage = null;
            this.mainToolbarOpenWindowPanel.Name = "mainToolbarOpenWindowPanel";
            this.mainToolbarOpenWindowPanel.Size = new System.Drawing.Size(1264, 26);
            this.mainToolbarOpenWindowPanel.TabIndex = 2;
            // 
            // mainToolbarPanelTop
            // 
            this.mainToolbarPanelTop.Controls.Add(this.toolbatSetupBtn);
            this.mainToolbarPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainToolbarPanelTop.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.mainToolbarPanelTop.Location = new System.Drawing.Point(0, 0);
            this.mainToolbarPanelTop.Name = "mainToolbarPanelTop";
            this.mainToolbarPanelTop.Size = new System.Drawing.Size(1264, 25);
            this.mainToolbarPanelTop.TabIndex = 1;
            // 
            // toolbatSetupBtn
            // 
            this.toolbatSetupBtn.BackColor = System.Drawing.Color.Transparent;
            this.toolbatSetupBtn.BorderColor = System.Drawing.Color.Transparent;
            this.toolbatSetupBtn.DisableImage = null;
            this.toolbatSetupBtn.DownImage = null;
            this.toolbatSetupBtn.DrawTextMode = false;
            this.toolbatSetupBtn.Location = new System.Drawing.Point(3, 3);
            this.toolbatSetupBtn.Name = "toolbatSetupBtn";
            this.toolbatSetupBtn.OverForeColor = System.Drawing.Color.Black;
            this.toolbatSetupBtn.OverImage = null;
            this.toolbatSetupBtn.Size = new System.Drawing.Size(21, 19);
            this.toolbatSetupBtn.TabIndex = 1;
            this.toolbatSetupBtn.TabStop = false;
            this.toolbatSetupBtn.ToolTipText = "사용자버튼설정";
            this.toolbatSetupBtn.UpImage = null;
            this.toolbatSetupBtn.Click += new System.EventHandler(this.toolbatSetupBtn_Click);
            // 
            // mainTopPanel
            // 
            this.mainTopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainTopPanel.Controls.Add(this.mainSystemButtonPanel);
            this.mainTopPanel.Controls.Add(this.mainCaptionRightPanel);
            this.mainTopPanel.Controls.Add(this.mainIconPictureBox);
            this.mainTopPanel.Controls.Add(this.mainCaptionLeftPanel);
            this.mainTopPanel.Controls.Add(this.MNU_MainMenu);
            this.mainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTopPanel.Name = "mainTopPanel";
            this.mainTopPanel.Size = new System.Drawing.Size(1264, 28);
            this.mainTopPanel.TabIndex = 6;
            this.mainTopPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.mainTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.mainTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainTopPanel_MouseMove);
            // 
            // mainSystemButtonPanel
            // 
            this.mainSystemButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainSystemButtonPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainSystemButtonPanel.Controls.Add(this.mainCloseBtn);
            this.mainSystemButtonPanel.Controls.Add(this.mainMaxBtn);
            this.mainSystemButtonPanel.Controls.Add(this.mainMinBtn);
            this.mainSystemButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainSystemButtonPanel.Location = new System.Drawing.Point(1169, 0);
            this.mainSystemButtonPanel.Name = "mainSystemButtonPanel";
            this.mainSystemButtonPanel.Size = new System.Drawing.Size(85, 28);
            this.mainSystemButtonPanel.TabIndex = 5;
            this.mainSystemButtonPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // mainCloseBtn
            // 
            this.mainCloseBtn.BorderColor = System.Drawing.Color.Transparent;
            this.mainCloseBtn.DisableImage = null;
            this.mainCloseBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainCloseBtn.DownImage = null;
            this.mainCloseBtn.DrawTextMode = false;
            this.mainCloseBtn.Location = new System.Drawing.Point(56, 0);
            this.mainCloseBtn.Name = "mainCloseBtn";
            this.mainCloseBtn.OverForeColor = System.Drawing.Color.Black;
            this.mainCloseBtn.OverImage = null;
            this.mainCloseBtn.Size = new System.Drawing.Size(29, 28);
            this.mainCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainCloseBtn.TabIndex = 2;
            this.mainCloseBtn.TabStop = false;
            this.mainCloseBtn.ToolTipText = "";
            this.mainCloseBtn.UpImage = null;
            this.mainCloseBtn.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // mainMaxBtn
            // 
            this.mainMaxBtn.BorderColor = System.Drawing.Color.Transparent;
            this.mainMaxBtn.DisableImage = null;
            this.mainMaxBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMaxBtn.DownImage = null;
            this.mainMaxBtn.DrawTextMode = false;
            this.mainMaxBtn.Location = new System.Drawing.Point(28, 0);
            this.mainMaxBtn.Name = "mainMaxBtn";
            this.mainMaxBtn.OverForeColor = System.Drawing.Color.Black;
            this.mainMaxBtn.OverImage = null;
            this.mainMaxBtn.Size = new System.Drawing.Size(28, 28);
            this.mainMaxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainMaxBtn.TabIndex = 1;
            this.mainMaxBtn.TabStop = false;
            this.mainMaxBtn.ToolTipText = "";
            this.mainMaxBtn.UpImage = null;
            this.mainMaxBtn.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // mainMinBtn
            // 
            this.mainMinBtn.BorderColor = System.Drawing.Color.Transparent;
            this.mainMinBtn.DisableImage = null;
            this.mainMinBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMinBtn.DownImage = null;
            this.mainMinBtn.DrawTextMode = false;
            this.mainMinBtn.Location = new System.Drawing.Point(0, 0);
            this.mainMinBtn.Name = "mainMinBtn";
            this.mainMinBtn.OverForeColor = System.Drawing.Color.Black;
            this.mainMinBtn.OverImage = null;
            this.mainMinBtn.Size = new System.Drawing.Size(28, 28);
            this.mainMinBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainMinBtn.TabIndex = 0;
            this.mainMinBtn.TabStop = false;
            this.mainMinBtn.ToolTipText = "";
            this.mainMinBtn.UpImage = null;
            this.mainMinBtn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // mainCaptionRightPanel
            // 
            this.mainCaptionRightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainCaptionRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainCaptionRightPanel.Location = new System.Drawing.Point(1254, 0);
            this.mainCaptionRightPanel.Name = "mainCaptionRightPanel";
            this.mainCaptionRightPanel.Size = new System.Drawing.Size(10, 28);
            this.mainCaptionRightPanel.TabIndex = 0;
            this.mainCaptionRightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // mainIconPictureBox
            // 
            this.mainIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainIconPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainIconPictureBox.Location = new System.Drawing.Point(2, 0);
            this.mainIconPictureBox.Name = "mainIconPictureBox";
            this.mainIconPictureBox.Size = new System.Drawing.Size(120, 28);
            this.mainIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainIconPictureBox.TabIndex = 4;
            this.mainIconPictureBox.TabStop = false;
            this.mainIconPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.mainIconPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.mainIconPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainTopPanel_MouseMove);
            // 
            // mainCaptionLeftPanel
            // 
            this.mainCaptionLeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainCaptionLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainCaptionLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.mainCaptionLeftPanel.Name = "mainCaptionLeftPanel";
            this.mainCaptionLeftPanel.Size = new System.Drawing.Size(2, 28);
            this.mainCaptionLeftPanel.TabIndex = 3;
            this.mainCaptionLeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // MNU_MainMenu
            // 
            this.MNU_MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MNU_MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MNU_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.MNU_MainMenu.Location = new System.Drawing.Point(184, 0);
            this.MNU_MainMenu.Name = "MNU_MainMenu";
            this.MNU_MainMenu.Size = new System.Drawing.Size(63, 24);
            this.MNU_MainMenu.TabIndex = 2;
            this.MNU_MainMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.userPasswordChangeToolStripMenuItem,
            this.soundOffToolStripMenuItem,
            this.panel4ToolStripMenuItem,
            this.treeToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.openWindowToolStripMenuItem,
            this.alertPopupViewMenuItem,
            this.aPMInfoToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem1.Text = "도움말";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.setupToolStripMenuItem.Text = "환경설정";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // userPasswordChangeToolStripMenuItem
            // 
            this.userPasswordChangeToolStripMenuItem.Name = "userPasswordChangeToolStripMenuItem";
            this.userPasswordChangeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.userPasswordChangeToolStripMenuItem.Text = "사용자비밀번호변경";
            this.userPasswordChangeToolStripMenuItem.Click += new System.EventHandler(this.userPasswordChangeToolStripMenuItem_Click);
            // 
            // soundOffToolStripMenuItem
            // 
            this.soundOffToolStripMenuItem.Checked = true;
            this.soundOffToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soundOffToolStripMenuItem.Name = "soundOffToolStripMenuItem";
            this.soundOffToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.soundOffToolStripMenuItem.Text = "Sound Off";
            this.soundOffToolStripMenuItem.Click += new System.EventHandler(this.soundOffToolStripMenuItem_Click);
            // 
            // panel4ToolStripMenuItem
            // 
            this.panel4ToolStripMenuItem.Checked = true;
            this.panel4ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.panel4ToolStripMenuItem.Name = "panel4ToolStripMenuItem";
            this.panel4ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.panel4ToolStripMenuItem.Text = "알림창 보기";
            this.panel4ToolStripMenuItem.Click += new System.EventHandler(this.panel4ToolStripMenuItem_Click);
            // 
            // treeToolStripMenuItem
            // 
            this.treeToolStripMenuItem.Checked = true;
            this.treeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.treeToolStripMenuItem.Name = "treeToolStripMenuItem";
            this.treeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.treeToolStripMenuItem.Text = "시스템상태Tree창보기";
            this.treeToolStripMenuItem.Click += new System.EventHandler(this.treeToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Checked = true;
            this.menuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.menuToolStripMenuItem.Text = " 메뉴툴바보기";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // openWindowToolStripMenuItem
            // 
            this.openWindowToolStripMenuItem.Checked = true;
            this.openWindowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openWindowToolStripMenuItem.Name = "openWindowToolStripMenuItem";
            this.openWindowToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.openWindowToolStripMenuItem.Text = "열린화면보기";
            this.openWindowToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // alertPopupViewMenuItem
            // 
            this.alertPopupViewMenuItem.Name = "alertPopupViewMenuItem";
            this.alertPopupViewMenuItem.Size = new System.Drawing.Size(192, 22);
            this.alertPopupViewMenuItem.Text = "경고알림팝업보기";
            this.alertPopupViewMenuItem.Click += new System.EventHandler(this.alertPopupViewMenuItem_Click);
            // 
            // aPMInfoToolStripMenuItem
            // 
            this.aPMInfoToolStripMenuItem.Name = "aPMInfoToolStripMenuItem";
            this.aPMInfoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.aPMInfoToolStripMenuItem.Text = "APM Information";
            this.aPMInfoToolStripMenuItem.Click += new System.EventHandler(this.aPMInfoToolStripMenuItem_Click);
            // 
            // WindowToolStripMenuItem
            // 
            this.WindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.바둑판정렬ToolStripMenuItem});
            this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            this.WindowToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.WindowToolStripMenuItem.Text = "창";
            this.WindowToolStripMenuItem.Visible = false;
            // 
            // 바둑판정렬ToolStripMenuItem
            // 
            this.바둑판정렬ToolStripMenuItem.Name = "바둑판정렬ToolStripMenuItem";
            this.바둑판정렬ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.바둑판정렬ToolStripMenuItem.Text = "바둑판정렬";
            // 
            // mainStatusPanel
            // 
            this.mainStatusPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainStatusPanel.Controls.Add(this.InfoPanel);
            this.mainStatusPanel.Controls.Add(this.serverInfoComboBox);
            this.mainStatusPanel.Controls.Add(this.label16);
            this.mainStatusPanel.Controls.Add(this.sendInfoPanel);
            this.mainStatusPanel.Controls.Add(this.recvInfoPanel);
            this.mainStatusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainStatusPanel.Location = new System.Drawing.Point(0, 820);
            this.mainStatusPanel.Name = "mainStatusPanel";
            this.mainStatusPanel.Size = new System.Drawing.Size(1264, 24);
            this.mainStatusPanel.TabIndex = 15;
            this.mainStatusPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainStatusPanel_Paint);
            // 
            // serverInfoComboBox
            // 
            this.serverInfoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverInfoComboBox.FormattingEnabled = true;
            this.serverInfoComboBox.Location = new System.Drawing.Point(80, 2);
            this.serverInfoComboBox.Name = "serverInfoComboBox";
            this.serverInfoComboBox.Size = new System.Drawing.Size(113, 20);
            this.serverInfoComboBox.TabIndex = 8;
            //this.serverInfoComboBox.SelectedIndexChanged += new System.EventHandler(this.serverInfoComboBox_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(0, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "시장선택";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoPanel.Controls.Add(this.AlertMsgInfoPanel);
            this.InfoPanel.Controls.Add(this.ProcessMsgInfoPanel);
            this.InfoPanel.Controls.Add(this.LogMsgInfoPanel);
            this.InfoPanel.Controls.Add(this.EventMsgInfoPanel);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InfoPanel.Location = new System.Drawing.Point(1126, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(76, 24);
            this.InfoPanel.TabIndex = 9;
            // 
            // AlertMsgInfoPanel
            // 
            this.AlertMsgInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.AlertMsgInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.AlertMsgInfoPanel.Name = "AlertMsgInfoPanel";
            this.AlertMsgInfoPanel.Size = new System.Drawing.Size(19, 24);
            this.AlertMsgInfoPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AlertMsgInfoPanel.TabIndex = 59;
            this.AlertMsgInfoPanel.TabStop = false;
            this.AlertMsgInfoPanel.DoubleClick += new System.EventHandler(this.alertTitlePicture_DoubleClick);
            this.AlertMsgInfoPanel.MouseHover += new System.EventHandler(this.AlertMsgInfoPanel_MouseHover);
            // 
            // ProcessMsgInfoPanel
            // 
            this.ProcessMsgInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProcessMsgInfoPanel.Location = new System.Drawing.Point(19, 0);
            this.ProcessMsgInfoPanel.Name = "ProcessMsgInfoPanel";
            this.ProcessMsgInfoPanel.Size = new System.Drawing.Size(19, 24);
            this.ProcessMsgInfoPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ProcessMsgInfoPanel.TabIndex = 4;
            this.ProcessMsgInfoPanel.TabStop = false;
            this.ProcessMsgInfoPanel.DoubleClick += new System.EventHandler(this.processTitlePicture_DoubleClick);
            this.ProcessMsgInfoPanel.MouseHover += new System.EventHandler(this.ProcessMsgInfoPanel_MouseHover);
            // 
            // LogMsgInfoPanel
            // 
            this.LogMsgInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.LogMsgInfoPanel.Location = new System.Drawing.Point(38, 0);
            this.LogMsgInfoPanel.Name = "LogMsgInfoPanel";
            this.LogMsgInfoPanel.Size = new System.Drawing.Size(19, 24);
            this.LogMsgInfoPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogMsgInfoPanel.TabIndex = 3;
            this.LogMsgInfoPanel.TabStop = false;
            this.LogMsgInfoPanel.DoubleClick += new System.EventHandler(this.logTitlePicture_DoubleClick);
            this.LogMsgInfoPanel.MouseHover += new System.EventHandler(this.LogMsgInfoPanel_MouseHover);
            // 
            // EventMsgInfoPanel
            // 
            this.EventMsgInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.EventMsgInfoPanel.Location = new System.Drawing.Point(57, 0);
            this.EventMsgInfoPanel.Name = "EventMsgInfoPanel";
            this.EventMsgInfoPanel.Size = new System.Drawing.Size(19, 24);
            this.EventMsgInfoPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EventMsgInfoPanel.TabIndex = 2;
            this.EventMsgInfoPanel.TabStop = false;
            this.EventMsgInfoPanel.DoubleClick += new System.EventHandler(this.eventTitlePicture_DoubleClick);
            this.EventMsgInfoPanel.MouseHover += new System.EventHandler(this.EventMsgInfoPanel_MouseHover);
            // 
            // sendInfoPanel
            // 
            this.sendInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendInfoPanel.Location = new System.Drawing.Point(1216, 0);
            this.sendInfoPanel.Name = "sendInfoPanel";
            this.sendInfoPanel.Size = new System.Drawing.Size(24, 24);
            this.sendInfoPanel.TabIndex = 1;
            this.sendInfoPanel.TabStop = false;
            // 
            // recvInfoPanel
            // 
            this.recvInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recvInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recvInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.recvInfoPanel.Location = new System.Drawing.Point(1240, 0);
            this.recvInfoPanel.Name = "recvInfoPanel";
            this.recvInfoPanel.Size = new System.Drawing.Size(24, 24);
            this.recvInfoPanel.TabIndex = 0;
            this.recvInfoPanel.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 606);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1264, 214);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel13);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1264, 214);
            this.panel5.TabIndex = 7;
            this.panel5.Resize += new System.EventHandler(this.panel4_Resize);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.LSV_Pms1);
            this.panel13.Controls.Add(this.LSV_Pms2);
            this.panel13.Controls.Add(this.LSV_Pms3);
            this.panel13.Controls.Add(this.LSV_Pms4);
            this.panel13.Controls.Add(this.LSV_Pms5);
            this.panel13.Controls.Add(this.LSV_Pms6);
            this.panel13.Controls.Add(this.LSV_Pms7);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(214, 214);
            this.panel13.TabIndex = 11;
            // 
            // LSV_Pms1
            // 
            this.LSV_Pms1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_Pms1.AllowEditing = false;
            this.LSV_Pms1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_Pms1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.LSV_Pms1.ColumnInfo = resources.GetString("LSV_Pms1.ColumnInfo");
            this.LSV_Pms1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_Pms1.Location = new System.Drawing.Point(0, 0);
            this.LSV_Pms1.Name = "LSV_Pms1";
            this.LSV_Pms1.Rows.Count = 1;
            this.LSV_Pms1.Rows.DefaultSize = 20;
            this.LSV_Pms1.Rows.MaxSize = 16;
            this.LSV_Pms1.Size = new System.Drawing.Size(214, 214);
            this.LSV_Pms1.StyleInfo = resources.GetString("LSV_Pms1.StyleInfo");
            this.LSV_Pms1.TabIndex = 0;
            this.LSV_Pms1.DoubleClick += new System.EventHandler(this.LSV_Pms_DoubleClick);
            // 
            // LSV_Pms2
            // 
            this.LSV_Pms2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_Pms2.AllowEditing = false;
            this.LSV_Pms2.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_Pms2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.LSV_Pms2.ColumnInfo = resources.GetString("LSV_Pms2.ColumnInfo");
            this.LSV_Pms2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_Pms2.Location = new System.Drawing.Point(0, 0);
            this.LSV_Pms2.Name = "LSV_Pms2";
            this.LSV_Pms2.Rows.Count = 1;
            this.LSV_Pms2.Rows.DefaultSize = 20;
            this.LSV_Pms2.Rows.MaxSize = 16;
            this.LSV_Pms2.Size = new System.Drawing.Size(214, 214);
            this.LSV_Pms2.StyleInfo = resources.GetString("LSV_Pms2.StyleInfo");
            this.LSV_Pms2.TabIndex = 0;
            this.LSV_Pms2.DoubleClick += new System.EventHandler(this.LSV_Pms_DoubleClick);
            // 
            // LSV_Pms3
            // 
            this.LSV_Pms3.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_Pms3.AllowEditing = false;
            this.LSV_Pms3.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_Pms3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.LSV_Pms3.ColumnInfo = resources.GetString("LSV_Pms3.ColumnInfo");
            this.LSV_Pms3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_Pms3.Location = new System.Drawing.Point(0, 0);
            this.LSV_Pms3.Name = "LSV_Pms3";
            this.LSV_Pms3.Rows.Count = 1;
            this.LSV_Pms3.Rows.DefaultSize = 20;
            this.LSV_Pms3.Rows.MaxSize = 16;
            this.LSV_Pms3.Size = new System.Drawing.Size(214, 214);
            this.LSV_Pms3.StyleInfo = resources.GetString("LSV_Pms3.StyleInfo");
            this.LSV_Pms3.TabIndex = 0;
            this.LSV_Pms3.DoubleClick += new System.EventHandler(this.LSV_Pms_DoubleClick);
            // 
            // LSV_Pms4
            // 
            this.LSV_Pms4.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_Pms4.AllowEditing = false;
            this.LSV_Pms4.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_Pms4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.LSV_Pms4.ColumnInfo = resources.GetString("LSV_Pms4.ColumnInfo");
            this.LSV_Pms4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_Pms4.Location = new System.Drawing.Point(0, 0);
            this.LSV_Pms4.Name = "LSV_Pms4";
            this.LSV_Pms4.Rows.Count = 1;
            this.LSV_Pms4.Rows.DefaultSize = 20;
            this.LSV_Pms4.Rows.MaxSize = 16;
            this.LSV_Pms4.Size = new System.Drawing.Size(214, 214);
            this.LSV_Pms4.StyleInfo = resources.GetString("LSV_Pms4.StyleInfo");
            this.LSV_Pms4.TabIndex = 0;
            this.LSV_Pms4.DoubleClick += new System.EventHandler(this.LSV_Pms_DoubleClick);
            // 
            // LSV_Pms5
            // 
            this.LSV_Pms5.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_Pms5.AllowEditing = false;
            this.LSV_Pms5.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_Pms5.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.LSV_Pms5.ColumnInfo = resources.GetString("LSV_Pms5.ColumnInfo");
            this.LSV_Pms5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_Pms5.Location = new System.Drawing.Point(0, 0);
            this.LSV_Pms5.Name = "LSV_Pms5";
            this.LSV_Pms5.Rows.Count = 1;
            this.LSV_Pms5.Rows.DefaultSize = 20;
            this.LSV_Pms5.Rows.MaxSize = 16;
            this.LSV_Pms5.Size = new System.Drawing.Size(214, 214);
            this.LSV_Pms5.StyleInfo = resources.GetString("LSV_Pms5.StyleInfo");
            this.LSV_Pms5.TabIndex = 0;
            this.LSV_Pms5.DoubleClick += new System.EventHandler(this.LSV_Pms_DoubleClick);
            // 
            // LSV_Pms6
            // 
            this.LSV_Pms6.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_Pms6.AllowEditing = false;
            this.LSV_Pms6.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_Pms6.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.LSV_Pms6.ColumnInfo = resources.GetString("LSV_Pms6.ColumnInfo");
            this.LSV_Pms6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_Pms6.Location = new System.Drawing.Point(0, 0);
            this.LSV_Pms6.Name = "LSV_Pms6";
            this.LSV_Pms6.Rows.Count = 1;
            this.LSV_Pms6.Rows.DefaultSize = 20;
            this.LSV_Pms6.Rows.MaxSize = 16;
            this.LSV_Pms6.Size = new System.Drawing.Size(214, 214);
            this.LSV_Pms6.StyleInfo = resources.GetString("LSV_Pms6.StyleInfo");
            this.LSV_Pms6.TabIndex = 0;
            this.LSV_Pms6.DoubleClick += new System.EventHandler(this.LSV_Pms_DoubleClick);
            // 
            // LSV_Pms7
            // 
            this.LSV_Pms7.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_Pms7.AllowEditing = false;
            this.LSV_Pms7.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_Pms7.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.LSV_Pms7.ColumnInfo = resources.GetString("LSV_Pms7.ColumnInfo");
            this.LSV_Pms7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_Pms7.Location = new System.Drawing.Point(0, 0);
            this.LSV_Pms7.Name = "LSV_Pms7";
            this.LSV_Pms7.Rows.Count = 1;
            this.LSV_Pms7.Rows.DefaultSize = 20;
            this.LSV_Pms7.Rows.MaxSize = 16;
            this.LSV_Pms7.Size = new System.Drawing.Size(214, 214);
            this.LSV_Pms7.StyleInfo = resources.GetString("LSV_Pms7.StyleInfo");
            this.LSV_Pms7.TabIndex = 0;
            this.LSV_Pms7.DoubleClick += new System.EventHandler(this.LSV_Pms_DoubleClick);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.LSV_MSG_Message1);
            this.panel9.Controls.Add(this.LSV_MSG_Message2);
            this.panel9.Controls.Add(this.LSV_MSG_Message3);
            this.panel9.Controls.Add(this.LSV_MSG_Message4);
            this.panel9.Controls.Add(this.LSV_MSG_Message5);
            this.panel9.Controls.Add(this.LSV_MSG_Message6);
            this.panel9.Controls.Add(this.LSV_MSG_Message7);
            this.panel9.Controls.Add(this.alertTopPanel);
            this.panel9.Location = new System.Drawing.Point(231, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(206, 106);
            this.panel9.TabIndex = 7;
            // 
            // LSV_MSG_Message1
            // 
            this.LSV_MSG_Message1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Message1.AllowEditing = false;
            this.LSV_MSG_Message1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Message1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Message1.ColumnInfo = resources.GetString("LSV_MSG_Message1.ColumnInfo");
            this.LSV_MSG_Message1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Message1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Message1.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Message1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Message1.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Message1.Name = "LSV_MSG_Message1";
            this.LSV_MSG_Message1.Rows.Count = 1;
            this.LSV_MSG_Message1.Rows.DefaultSize = 20;
            this.LSV_MSG_Message1.Rows.MaxSize = 15;
            this.LSV_MSG_Message1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Message1.Size = new System.Drawing.Size(206, 84);
            this.LSV_MSG_Message1.StyleInfo = resources.GetString("LSV_MSG_Message1.StyleInfo");
            this.LSV_MSG_Message1.TabIndex = 12;
            this.LSV_MSG_Message1.DoubleClick += new System.EventHandler(this.LSV_MSG_Message_DoubleClick);
            // 
            // LSV_MSG_Message2
            // 
            this.LSV_MSG_Message2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Message2.AllowEditing = false;
            this.LSV_MSG_Message2.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Message2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Message2.ColumnInfo = resources.GetString("LSV_MSG_Message2.ColumnInfo");
            this.LSV_MSG_Message2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Message2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Message2.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Message2.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Message2.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Message2.Name = "LSV_MSG_Message2";
            this.LSV_MSG_Message2.Rows.Count = 1;
            this.LSV_MSG_Message2.Rows.DefaultSize = 20;
            this.LSV_MSG_Message2.Rows.MaxSize = 15;
            this.LSV_MSG_Message2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Message2.Size = new System.Drawing.Size(206, 84);
            this.LSV_MSG_Message2.StyleInfo = resources.GetString("LSV_MSG_Message2.StyleInfo");
            this.LSV_MSG_Message2.TabIndex = 12;
            this.LSV_MSG_Message2.DoubleClick += new System.EventHandler(this.LSV_MSG_Message_DoubleClick);
            // 
            // LSV_MSG_Message3
            // 
            this.LSV_MSG_Message3.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Message3.AllowEditing = false;
            this.LSV_MSG_Message3.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Message3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Message3.ColumnInfo = resources.GetString("LSV_MSG_Message3.ColumnInfo");
            this.LSV_MSG_Message3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Message3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Message3.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Message3.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Message3.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Message3.Name = "LSV_MSG_Message3";
            this.LSV_MSG_Message3.Rows.Count = 1;
            this.LSV_MSG_Message3.Rows.DefaultSize = 20;
            this.LSV_MSG_Message3.Rows.MaxSize = 15;
            this.LSV_MSG_Message3.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Message3.Size = new System.Drawing.Size(206, 84);
            this.LSV_MSG_Message3.StyleInfo = resources.GetString("LSV_MSG_Message3.StyleInfo");
            this.LSV_MSG_Message3.TabIndex = 12;
            this.LSV_MSG_Message3.DoubleClick += new System.EventHandler(this.LSV_MSG_Message_DoubleClick);
            // 
            // LSV_MSG_Message4
            // 
            this.LSV_MSG_Message4.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Message4.AllowEditing = false;
            this.LSV_MSG_Message4.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Message4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Message4.ColumnInfo = resources.GetString("LSV_MSG_Message4.ColumnInfo");
            this.LSV_MSG_Message4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Message4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Message4.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Message4.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Message4.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Message4.Name = "LSV_MSG_Message4";
            this.LSV_MSG_Message4.Rows.Count = 1;
            this.LSV_MSG_Message4.Rows.DefaultSize = 20;
            this.LSV_MSG_Message4.Rows.MaxSize = 15;
            this.LSV_MSG_Message4.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Message4.Size = new System.Drawing.Size(206, 84);
            this.LSV_MSG_Message4.StyleInfo = resources.GetString("LSV_MSG_Message4.StyleInfo");
            this.LSV_MSG_Message4.TabIndex = 12;
            this.LSV_MSG_Message4.DoubleClick += new System.EventHandler(this.LSV_MSG_Message_DoubleClick);
            // 
            // LSV_MSG_Message5
            // 
            this.LSV_MSG_Message5.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Message5.AllowEditing = false;
            this.LSV_MSG_Message5.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Message5.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Message5.ColumnInfo = resources.GetString("LSV_MSG_Message5.ColumnInfo");
            this.LSV_MSG_Message5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Message5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Message5.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Message5.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Message5.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Message5.Name = "LSV_MSG_Message5";
            this.LSV_MSG_Message5.Rows.Count = 1;
            this.LSV_MSG_Message5.Rows.DefaultSize = 20;
            this.LSV_MSG_Message5.Rows.MaxSize = 15;
            this.LSV_MSG_Message5.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Message5.Size = new System.Drawing.Size(206, 84);
            this.LSV_MSG_Message5.StyleInfo = resources.GetString("LSV_MSG_Message5.StyleInfo");
            this.LSV_MSG_Message5.TabIndex = 12;
            this.LSV_MSG_Message5.DoubleClick += new System.EventHandler(this.LSV_MSG_Message_DoubleClick);
            // 
            // LSV_MSG_Message6
            // 
            this.LSV_MSG_Message6.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Message6.AllowEditing = false;
            this.LSV_MSG_Message6.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Message6.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Message6.ColumnInfo = resources.GetString("LSV_MSG_Message6.ColumnInfo");
            this.LSV_MSG_Message6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Message6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Message6.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Message6.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Message6.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Message6.Name = "LSV_MSG_Message6";
            this.LSV_MSG_Message6.Rows.Count = 1;
            this.LSV_MSG_Message6.Rows.DefaultSize = 20;
            this.LSV_MSG_Message6.Rows.MaxSize = 15;
            this.LSV_MSG_Message6.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Message6.Size = new System.Drawing.Size(206, 84);
            this.LSV_MSG_Message6.StyleInfo = resources.GetString("LSV_MSG_Message6.StyleInfo");
            this.LSV_MSG_Message6.TabIndex = 12;
            this.LSV_MSG_Message6.DoubleClick += new System.EventHandler(this.LSV_MSG_Message_DoubleClick);
            // 
            // LSV_MSG_Message7
            // 
            this.LSV_MSG_Message7.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Message7.AllowEditing = false;
            this.LSV_MSG_Message7.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Message7.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Message7.ColumnInfo = resources.GetString("LSV_MSG_Message7.ColumnInfo");
            this.LSV_MSG_Message7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Message7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Message7.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Message7.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Message7.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Message7.Name = "LSV_MSG_Message7";
            this.LSV_MSG_Message7.Rows.Count = 1;
            this.LSV_MSG_Message7.Rows.DefaultSize = 20;
            this.LSV_MSG_Message7.Rows.MaxSize = 15;
            this.LSV_MSG_Message7.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Message7.Size = new System.Drawing.Size(206, 84);
            this.LSV_MSG_Message7.StyleInfo = resources.GetString("LSV_MSG_Message7.StyleInfo");
            this.LSV_MSG_Message7.TabIndex = 12;
            this.LSV_MSG_Message7.DoubleClick += new System.EventHandler(this.LSV_MSG_Message_DoubleClick);
            // 
            // alertTopPanel
            // 
            this.alertTopPanel.Controls.Add(this.alertTitlePicture);
            this.alertTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.alertTopPanel.Location = new System.Drawing.Point(0, 0);
            this.alertTopPanel.Name = "alertTopPanel";
            this.alertTopPanel.Size = new System.Drawing.Size(206, 22);
            this.alertTopPanel.TabIndex = 4;
            // 
            // alertTitlePicture
            // 
            this.alertTitlePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alertTitlePicture.Location = new System.Drawing.Point(0, 0);
            this.alertTitlePicture.Name = "alertTitlePicture";
            this.alertTitlePicture.Size = new System.Drawing.Size(206, 22);
            this.alertTitlePicture.TabIndex = 4;
            this.alertTitlePicture.TabStop = false;
            this.alertTitlePicture.Paint += new System.Windows.Forms.PaintEventHandler(this.alertTitlePicture_Paint);
            this.alertTitlePicture.DoubleClick += new System.EventHandler(this.alertTitlePicture_DoubleClick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.LSV_MSG_Event1);
            this.panel8.Controls.Add(this.LSV_MSG_Event2);
            this.panel8.Controls.Add(this.LSV_MSG_Event3);
            this.panel8.Controls.Add(this.LSV_MSG_Event4);
            this.panel8.Controls.Add(this.LSV_MSG_Event5);
            this.panel8.Controls.Add(this.LSV_MSG_Event6);
            this.panel8.Controls.Add(this.LSV_MSG_Event7);
            this.panel8.Controls.Add(this.eventTopPanel);
            this.panel8.Location = new System.Drawing.Point(840, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(182, 106);
            this.panel8.TabIndex = 10;
            // 
            // LSV_MSG_Event1
            // 
            this.LSV_MSG_Event1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Event1.AllowEditing = false;
            this.LSV_MSG_Event1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Event1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Event1.ColumnInfo = resources.GetString("LSV_MSG_Event1.ColumnInfo");
            this.LSV_MSG_Event1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Event1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Event1.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Event1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Event1.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Event1.Name = "LSV_MSG_Event1";
            this.LSV_MSG_Event1.Rows.Count = 1;
            this.LSV_MSG_Event1.Rows.DefaultSize = 20;
            this.LSV_MSG_Event1.Rows.MaxSize = 15;
            this.LSV_MSG_Event1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Event1.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Event1.StyleInfo = resources.GetString("LSV_MSG_Event1.StyleInfo");
            this.LSV_MSG_Event1.TabIndex = 14;
            this.LSV_MSG_Event1.DoubleClick += new System.EventHandler(this.LSV_MSG_Event_DoubleClick);
            // 
            // LSV_MSG_Event2
            // 
            this.LSV_MSG_Event2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Event2.AllowEditing = false;
            this.LSV_MSG_Event2.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Event2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Event2.ColumnInfo = resources.GetString("LSV_MSG_Event2.ColumnInfo");
            this.LSV_MSG_Event2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Event2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Event2.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Event2.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Event2.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Event2.Name = "LSV_MSG_Event2";
            this.LSV_MSG_Event2.Rows.Count = 1;
            this.LSV_MSG_Event2.Rows.DefaultSize = 20;
            this.LSV_MSG_Event2.Rows.MaxSize = 15;
            this.LSV_MSG_Event2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Event2.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Event2.StyleInfo = resources.GetString("LSV_MSG_Event2.StyleInfo");
            this.LSV_MSG_Event2.TabIndex = 14;
            this.LSV_MSG_Event2.DoubleClick += new System.EventHandler(this.LSV_MSG_Event_DoubleClick);
            // 
            // LSV_MSG_Event3
            // 
            this.LSV_MSG_Event3.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Event3.AllowEditing = false;
            this.LSV_MSG_Event3.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Event3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Event3.ColumnInfo = resources.GetString("LSV_MSG_Event3.ColumnInfo");
            this.LSV_MSG_Event3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Event3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Event3.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Event3.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Event3.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Event3.Name = "LSV_MSG_Event3";
            this.LSV_MSG_Event3.Rows.Count = 1;
            this.LSV_MSG_Event3.Rows.DefaultSize = 20;
            this.LSV_MSG_Event3.Rows.MaxSize = 15;
            this.LSV_MSG_Event3.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Event3.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Event3.StyleInfo = resources.GetString("LSV_MSG_Event3.StyleInfo");
            this.LSV_MSG_Event3.TabIndex = 14;
            this.LSV_MSG_Event3.DoubleClick += new System.EventHandler(this.LSV_MSG_Event_DoubleClick);
            // 
            // LSV_MSG_Event4
            // 
            this.LSV_MSG_Event4.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Event4.AllowEditing = false;
            this.LSV_MSG_Event4.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Event4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Event4.ColumnInfo = resources.GetString("LSV_MSG_Event4.ColumnInfo");
            this.LSV_MSG_Event4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Event4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Event4.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Event4.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Event4.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Event4.Name = "LSV_MSG_Event4";
            this.LSV_MSG_Event4.Rows.Count = 1;
            this.LSV_MSG_Event4.Rows.DefaultSize = 20;
            this.LSV_MSG_Event4.Rows.MaxSize = 15;
            this.LSV_MSG_Event4.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Event4.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Event4.StyleInfo = resources.GetString("LSV_MSG_Event4.StyleInfo");
            this.LSV_MSG_Event4.TabIndex = 14;
            this.LSV_MSG_Event4.DoubleClick += new System.EventHandler(this.LSV_MSG_Event_DoubleClick);
            // 
            // LSV_MSG_Event5
            // 
            this.LSV_MSG_Event5.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Event5.AllowEditing = false;
            this.LSV_MSG_Event5.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Event5.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Event5.ColumnInfo = resources.GetString("LSV_MSG_Event5.ColumnInfo");
            this.LSV_MSG_Event5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Event5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Event5.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Event5.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Event5.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Event5.Name = "LSV_MSG_Event5";
            this.LSV_MSG_Event5.Rows.Count = 1;
            this.LSV_MSG_Event5.Rows.DefaultSize = 20;
            this.LSV_MSG_Event5.Rows.MaxSize = 15;
            this.LSV_MSG_Event5.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Event5.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Event5.StyleInfo = resources.GetString("LSV_MSG_Event5.StyleInfo");
            this.LSV_MSG_Event5.TabIndex = 14;
            this.LSV_MSG_Event5.DoubleClick += new System.EventHandler(this.LSV_MSG_Event_DoubleClick);
            // 
            // LSV_MSG_Event6
            // 
            this.LSV_MSG_Event6.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Event6.AllowEditing = false;
            this.LSV_MSG_Event6.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Event6.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Event6.ColumnInfo = resources.GetString("LSV_MSG_Event6.ColumnInfo");
            this.LSV_MSG_Event6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Event6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Event6.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Event6.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Event6.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Event6.Name = "LSV_MSG_Event6";
            this.LSV_MSG_Event6.Rows.Count = 1;
            this.LSV_MSG_Event6.Rows.DefaultSize = 20;
            this.LSV_MSG_Event6.Rows.MaxSize = 15;
            this.LSV_MSG_Event6.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Event6.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Event6.StyleInfo = resources.GetString("LSV_MSG_Event6.StyleInfo");
            this.LSV_MSG_Event6.TabIndex = 14;
            this.LSV_MSG_Event6.DoubleClick += new System.EventHandler(this.LSV_MSG_Event_DoubleClick);
            // 
            // LSV_MSG_Event7
            // 
            this.LSV_MSG_Event7.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Event7.AllowEditing = false;
            this.LSV_MSG_Event7.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Event7.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Event7.ColumnInfo = resources.GetString("LSV_MSG_Event7.ColumnInfo");
            this.LSV_MSG_Event7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Event7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Event7.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Event7.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Event7.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Event7.Name = "LSV_MSG_Event7";
            this.LSV_MSG_Event7.Rows.Count = 1;
            this.LSV_MSG_Event7.Rows.DefaultSize = 20;
            this.LSV_MSG_Event7.Rows.MaxSize = 15;
            this.LSV_MSG_Event7.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Event7.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Event7.StyleInfo = resources.GetString("LSV_MSG_Event7.StyleInfo");
            this.LSV_MSG_Event7.TabIndex = 14;
            this.LSV_MSG_Event7.DoubleClick += new System.EventHandler(this.LSV_MSG_Event_DoubleClick);
            // 
            // eventTopPanel
            // 
            this.eventTopPanel.Controls.Add(this.eventTitlePicture);
            this.eventTopPanel.Controls.Add(this.eventLeftPicture);
            this.eventTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventTopPanel.Location = new System.Drawing.Point(0, 0);
            this.eventTopPanel.Name = "eventTopPanel";
            this.eventTopPanel.Size = new System.Drawing.Size(182, 22);
            this.eventTopPanel.TabIndex = 5;
            // 
            // eventTitlePicture
            // 
            this.eventTitlePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventTitlePicture.Location = new System.Drawing.Point(2, 0);
            this.eventTitlePicture.Name = "eventTitlePicture";
            this.eventTitlePicture.Size = new System.Drawing.Size(180, 22);
            this.eventTitlePicture.TabIndex = 4;
            this.eventTitlePicture.TabStop = false;
            this.eventTitlePicture.Paint += new System.Windows.Forms.PaintEventHandler(this.eventTitlePicture_Paint);
            this.eventTitlePicture.DoubleClick += new System.EventHandler(this.eventTitlePicture_DoubleClick);
            // 
            // eventLeftPicture
            // 
            this.eventLeftPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.eventLeftPicture.Location = new System.Drawing.Point(0, 0);
            this.eventLeftPicture.Name = "eventLeftPicture";
            this.eventLeftPicture.Size = new System.Drawing.Size(2, 22);
            this.eventLeftPicture.TabIndex = 2;
            this.eventLeftPicture.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.LSV_MSG_Log1);
            this.panel7.Controls.Add(this.LSV_MSG_Log2);
            this.panel7.Controls.Add(this.LSV_MSG_Log3);
            this.panel7.Controls.Add(this.LSV_MSG_Log4);
            this.panel7.Controls.Add(this.LSV_MSG_Log5);
            this.panel7.Controls.Add(this.LSV_MSG_Log6);
            this.panel7.Controls.Add(this.LSV_MSG_Log7);
            this.panel7.Controls.Add(this.logTopPanel);
            this.panel7.Location = new System.Drawing.Point(652, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(182, 106);
            this.panel7.TabIndex = 9;
            // 
            // LSV_MSG_Log1
            // 
            this.LSV_MSG_Log1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Log1.AllowEditing = false;
            this.LSV_MSG_Log1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Log1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Log1.ColumnInfo = resources.GetString("LSV_MSG_Log1.ColumnInfo");
            this.LSV_MSG_Log1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Log1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Log1.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Log1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Log1.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Log1.Name = "LSV_MSG_Log1";
            this.LSV_MSG_Log1.Rows.Count = 1;
            this.LSV_MSG_Log1.Rows.DefaultSize = 20;
            this.LSV_MSG_Log1.Rows.MaxSize = 15;
            this.LSV_MSG_Log1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Log1.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Log1.StyleInfo = resources.GetString("LSV_MSG_Log1.StyleInfo");
            this.LSV_MSG_Log1.TabIndex = 15;
            this.LSV_MSG_Log1.DoubleClick += new System.EventHandler(this.LSV_MSG_Log_DoubleClick);
            // 
            // LSV_MSG_Log2
            // 
            this.LSV_MSG_Log2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Log2.AllowEditing = false;
            this.LSV_MSG_Log2.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Log2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Log2.ColumnInfo = resources.GetString("LSV_MSG_Log2.ColumnInfo");
            this.LSV_MSG_Log2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Log2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Log2.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Log2.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Log2.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Log2.Name = "LSV_MSG_Log2";
            this.LSV_MSG_Log2.Rows.Count = 1;
            this.LSV_MSG_Log2.Rows.DefaultSize = 20;
            this.LSV_MSG_Log2.Rows.MaxSize = 15;
            this.LSV_MSG_Log2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Log2.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Log2.StyleInfo = resources.GetString("LSV_MSG_Log2.StyleInfo");
            this.LSV_MSG_Log2.TabIndex = 15;
            this.LSV_MSG_Log2.DoubleClick += new System.EventHandler(this.LSV_MSG_Log_DoubleClick);
            // 
            // LSV_MSG_Log3
            // 
            this.LSV_MSG_Log3.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Log3.AllowEditing = false;
            this.LSV_MSG_Log3.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Log3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Log3.ColumnInfo = resources.GetString("LSV_MSG_Log3.ColumnInfo");
            this.LSV_MSG_Log3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Log3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Log3.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Log3.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Log3.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Log3.Name = "LSV_MSG_Log3";
            this.LSV_MSG_Log3.Rows.Count = 1;
            this.LSV_MSG_Log3.Rows.DefaultSize = 20;
            this.LSV_MSG_Log3.Rows.MaxSize = 15;
            this.LSV_MSG_Log3.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Log3.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Log3.StyleInfo = resources.GetString("LSV_MSG_Log3.StyleInfo");
            this.LSV_MSG_Log3.TabIndex = 15;
            this.LSV_MSG_Log3.DoubleClick += new System.EventHandler(this.LSV_MSG_Log_DoubleClick);
            // 
            // LSV_MSG_Log4
            // 
            this.LSV_MSG_Log4.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Log4.AllowEditing = false;
            this.LSV_MSG_Log4.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Log4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Log4.ColumnInfo = resources.GetString("LSV_MSG_Log4.ColumnInfo");
            this.LSV_MSG_Log4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Log4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Log4.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Log4.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Log4.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Log4.Name = "LSV_MSG_Log4";
            this.LSV_MSG_Log4.Rows.Count = 1;
            this.LSV_MSG_Log4.Rows.DefaultSize = 20;
            this.LSV_MSG_Log4.Rows.MaxSize = 15;
            this.LSV_MSG_Log4.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Log4.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Log4.StyleInfo = resources.GetString("LSV_MSG_Log4.StyleInfo");
            this.LSV_MSG_Log4.TabIndex = 15;
            this.LSV_MSG_Log4.DoubleClick += new System.EventHandler(this.LSV_MSG_Log_DoubleClick);
            // 
            // LSV_MSG_Log5
            // 
            this.LSV_MSG_Log5.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Log5.AllowEditing = false;
            this.LSV_MSG_Log5.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Log5.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Log5.ColumnInfo = resources.GetString("LSV_MSG_Log5.ColumnInfo");
            this.LSV_MSG_Log5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Log5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Log5.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Log5.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Log5.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Log5.Name = "LSV_MSG_Log5";
            this.LSV_MSG_Log5.Rows.Count = 1;
            this.LSV_MSG_Log5.Rows.DefaultSize = 20;
            this.LSV_MSG_Log5.Rows.MaxSize = 15;
            this.LSV_MSG_Log5.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Log5.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Log5.StyleInfo = resources.GetString("LSV_MSG_Log5.StyleInfo");
            this.LSV_MSG_Log5.TabIndex = 15;
            this.LSV_MSG_Log5.DoubleClick += new System.EventHandler(this.LSV_MSG_Log_DoubleClick);
            // 
            // LSV_MSG_Log6
            // 
            this.LSV_MSG_Log6.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Log6.AllowEditing = false;
            this.LSV_MSG_Log6.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Log6.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Log6.ColumnInfo = resources.GetString("LSV_MSG_Log6.ColumnInfo");
            this.LSV_MSG_Log6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Log6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Log6.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Log6.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Log6.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Log6.Name = "LSV_MSG_Log6";
            this.LSV_MSG_Log6.Rows.Count = 1;
            this.LSV_MSG_Log6.Rows.DefaultSize = 20;
            this.LSV_MSG_Log6.Rows.MaxSize = 15;
            this.LSV_MSG_Log6.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Log6.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Log6.StyleInfo = resources.GetString("LSV_MSG_Log6.StyleInfo");
            this.LSV_MSG_Log6.TabIndex = 15;
            this.LSV_MSG_Log6.DoubleClick += new System.EventHandler(this.LSV_MSG_Log_DoubleClick);
            // 
            // LSV_MSG_Log7
            // 
            this.LSV_MSG_Log7.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Log7.AllowEditing = false;
            this.LSV_MSG_Log7.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Log7.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Log7.ColumnInfo = resources.GetString("LSV_MSG_Log7.ColumnInfo");
            this.LSV_MSG_Log7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Log7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Log7.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Log7.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Log7.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Log7.Name = "LSV_MSG_Log7";
            this.LSV_MSG_Log7.Rows.Count = 1;
            this.LSV_MSG_Log7.Rows.DefaultSize = 20;
            this.LSV_MSG_Log7.Rows.MaxSize = 15;
            this.LSV_MSG_Log7.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Log7.Size = new System.Drawing.Size(182, 84);
            this.LSV_MSG_Log7.StyleInfo = resources.GetString("LSV_MSG_Log7.StyleInfo");
            this.LSV_MSG_Log7.TabIndex = 15;
            this.LSV_MSG_Log7.DoubleClick += new System.EventHandler(this.LSV_MSG_Log_DoubleClick);
            // 
            // logTopPanel
            // 
            this.logTopPanel.Controls.Add(this.logTitlePicture);
            this.logTopPanel.Controls.Add(this.logLeftPicture);
            this.logTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logTopPanel.Location = new System.Drawing.Point(0, 0);
            this.logTopPanel.Name = "logTopPanel";
            this.logTopPanel.Size = new System.Drawing.Size(182, 22);
            this.logTopPanel.TabIndex = 5;
            // 
            // logTitlePicture
            // 
            this.logTitlePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTitlePicture.Location = new System.Drawing.Point(2, 0);
            this.logTitlePicture.Name = "logTitlePicture";
            this.logTitlePicture.Size = new System.Drawing.Size(180, 22);
            this.logTitlePicture.TabIndex = 4;
            this.logTitlePicture.TabStop = false;
            this.logTitlePicture.Paint += new System.Windows.Forms.PaintEventHandler(this.logTitlePicture_Paint);
            this.logTitlePicture.DoubleClick += new System.EventHandler(this.logTitlePicture_DoubleClick);
            // 
            // logLeftPicture
            // 
            this.logLeftPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.logLeftPicture.Location = new System.Drawing.Point(0, 0);
            this.logLeftPicture.Name = "logLeftPicture";
            this.logLeftPicture.Size = new System.Drawing.Size(2, 22);
            this.logLeftPicture.TabIndex = 1;
            this.logLeftPicture.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LSV_MSG_Process1);
            this.panel6.Controls.Add(this.LSV_MSG_Process2);
            this.panel6.Controls.Add(this.LSV_MSG_Process3);
            this.panel6.Controls.Add(this.LSV_MSG_Process4);
            this.panel6.Controls.Add(this.LSV_MSG_Process5);
            this.panel6.Controls.Add(this.LSV_MSG_Process6);
            this.panel6.Controls.Add(this.LSV_MSG_Process7);
            this.panel6.Controls.Add(this.processTopPanel);
            this.panel6.Location = new System.Drawing.Point(443, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 106);
            this.panel6.TabIndex = 8;
            // 
            // LSV_MSG_Process1
            // 
            this.LSV_MSG_Process1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Process1.AllowEditing = false;
            this.LSV_MSG_Process1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Process1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Process1.ColumnInfo = resources.GetString("LSV_MSG_Process1.ColumnInfo");
            this.LSV_MSG_Process1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Process1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Process1.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Process1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Process1.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Process1.Name = "LSV_MSG_Process1";
            this.LSV_MSG_Process1.Rows.Count = 1;
            this.LSV_MSG_Process1.Rows.DefaultSize = 20;
            this.LSV_MSG_Process1.Rows.MaxSize = 15;
            this.LSV_MSG_Process1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Process1.Size = new System.Drawing.Size(203, 84);
            this.LSV_MSG_Process1.StyleInfo = resources.GetString("LSV_MSG_Process1.StyleInfo");
            this.LSV_MSG_Process1.TabIndex = 13;
            this.LSV_MSG_Process1.DoubleClick += new System.EventHandler(this.LSV_MSG_Process_DoubleClick);
            // 
            // LSV_MSG_Process2
            // 
            this.LSV_MSG_Process2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Process2.AllowEditing = false;
            this.LSV_MSG_Process2.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Process2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Process2.ColumnInfo = resources.GetString("LSV_MSG_Process2.ColumnInfo");
            this.LSV_MSG_Process2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Process2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Process2.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Process2.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Process2.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Process2.Name = "LSV_MSG_Process2";
            this.LSV_MSG_Process2.Rows.Count = 1;
            this.LSV_MSG_Process2.Rows.DefaultSize = 20;
            this.LSV_MSG_Process2.Rows.MaxSize = 15;
            this.LSV_MSG_Process2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Process2.Size = new System.Drawing.Size(203, 84);
            this.LSV_MSG_Process2.StyleInfo = resources.GetString("LSV_MSG_Process2.StyleInfo");
            this.LSV_MSG_Process2.TabIndex = 13;
            this.LSV_MSG_Process2.DoubleClick += new System.EventHandler(this.LSV_MSG_Process_DoubleClick);
            // 
            // LSV_MSG_Process3
            // 
            this.LSV_MSG_Process3.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Process3.AllowEditing = false;
            this.LSV_MSG_Process3.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Process3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Process3.ColumnInfo = resources.GetString("LSV_MSG_Process3.ColumnInfo");
            this.LSV_MSG_Process3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Process3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Process3.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Process3.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Process3.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Process3.Name = "LSV_MSG_Process3";
            this.LSV_MSG_Process3.Rows.Count = 1;
            this.LSV_MSG_Process3.Rows.DefaultSize = 20;
            this.LSV_MSG_Process3.Rows.MaxSize = 15;
            this.LSV_MSG_Process3.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Process3.Size = new System.Drawing.Size(203, 84);
            this.LSV_MSG_Process3.StyleInfo = resources.GetString("LSV_MSG_Process3.StyleInfo");
            this.LSV_MSG_Process3.TabIndex = 13;
            this.LSV_MSG_Process3.DoubleClick += new System.EventHandler(this.LSV_MSG_Process_DoubleClick);
            // 
            // LSV_MSG_Process4
            // 
            this.LSV_MSG_Process4.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Process4.AllowEditing = false;
            this.LSV_MSG_Process4.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Process4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Process4.ColumnInfo = resources.GetString("LSV_MSG_Process4.ColumnInfo");
            this.LSV_MSG_Process4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Process4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Process4.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Process4.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Process4.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Process4.Name = "LSV_MSG_Process4";
            this.LSV_MSG_Process4.Rows.Count = 1;
            this.LSV_MSG_Process4.Rows.DefaultSize = 20;
            this.LSV_MSG_Process4.Rows.MaxSize = 15;
            this.LSV_MSG_Process4.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Process4.Size = new System.Drawing.Size(203, 84);
            this.LSV_MSG_Process4.StyleInfo = resources.GetString("LSV_MSG_Process4.StyleInfo");
            this.LSV_MSG_Process4.TabIndex = 13;
            this.LSV_MSG_Process4.DoubleClick += new System.EventHandler(this.LSV_MSG_Process_DoubleClick);
            // 
            // LSV_MSG_Process5
            // 
            this.LSV_MSG_Process5.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Process5.AllowEditing = false;
            this.LSV_MSG_Process5.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Process5.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Process5.ColumnInfo = resources.GetString("LSV_MSG_Process5.ColumnInfo");
            this.LSV_MSG_Process5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Process5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Process5.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Process5.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Process5.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Process5.Name = "LSV_MSG_Process5";
            this.LSV_MSG_Process5.Rows.Count = 1;
            this.LSV_MSG_Process5.Rows.DefaultSize = 20;
            this.LSV_MSG_Process5.Rows.MaxSize = 15;
            this.LSV_MSG_Process5.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Process5.Size = new System.Drawing.Size(203, 84);
            this.LSV_MSG_Process5.StyleInfo = resources.GetString("LSV_MSG_Process5.StyleInfo");
            this.LSV_MSG_Process5.TabIndex = 13;
            this.LSV_MSG_Process5.DoubleClick += new System.EventHandler(this.LSV_MSG_Process_DoubleClick);
            // 
            // LSV_MSG_Process6
            // 
            this.LSV_MSG_Process6.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Process6.AllowEditing = false;
            this.LSV_MSG_Process6.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Process6.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Process6.ColumnInfo = resources.GetString("LSV_MSG_Process6.ColumnInfo");
            this.LSV_MSG_Process6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Process6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Process6.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Process6.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Process6.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Process6.Name = "LSV_MSG_Process6";
            this.LSV_MSG_Process6.Rows.Count = 1;
            this.LSV_MSG_Process6.Rows.DefaultSize = 20;
            this.LSV_MSG_Process6.Rows.MaxSize = 15;
            this.LSV_MSG_Process6.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Process6.Size = new System.Drawing.Size(203, 84);
            this.LSV_MSG_Process6.StyleInfo = resources.GetString("LSV_MSG_Process6.StyleInfo");
            this.LSV_MSG_Process6.TabIndex = 13;
            this.LSV_MSG_Process6.DoubleClick += new System.EventHandler(this.LSV_MSG_Process_DoubleClick);
            // 
            // LSV_MSG_Process7
            // 
            this.LSV_MSG_Process7.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.LSV_MSG_Process7.AllowEditing = false;
            this.LSV_MSG_Process7.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.LSV_MSG_Process7.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.LSV_MSG_Process7.ColumnInfo = resources.GetString("LSV_MSG_Process7.ColumnInfo");
            this.LSV_MSG_Process7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSV_MSG_Process7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.LSV_MSG_Process7.ForeColor = System.Drawing.Color.White;
            this.LSV_MSG_Process7.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never;
            this.LSV_MSG_Process7.Location = new System.Drawing.Point(0, 22);
            this.LSV_MSG_Process7.Name = "LSV_MSG_Process7";
            this.LSV_MSG_Process7.Rows.Count = 1;
            this.LSV_MSG_Process7.Rows.DefaultSize = 20;
            this.LSV_MSG_Process7.Rows.MaxSize = 15;
            this.LSV_MSG_Process7.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.LSV_MSG_Process7.Size = new System.Drawing.Size(203, 84);
            this.LSV_MSG_Process7.StyleInfo = resources.GetString("LSV_MSG_Process7.StyleInfo");
            this.LSV_MSG_Process7.TabIndex = 13;
            this.LSV_MSG_Process7.DoubleClick += new System.EventHandler(this.LSV_MSG_Process_DoubleClick);
            // 
            // processTopPanel
            // 
            this.processTopPanel.Controls.Add(this.processTitlePicture);
            this.processTopPanel.Controls.Add(this.processLeftPicture);
            this.processTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.processTopPanel.Location = new System.Drawing.Point(0, 0);
            this.processTopPanel.Name = "processTopPanel";
            this.processTopPanel.Size = new System.Drawing.Size(203, 22);
            this.processTopPanel.TabIndex = 5;
            // 
            // processTitlePicture
            // 
            this.processTitlePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processTitlePicture.Location = new System.Drawing.Point(2, 0);
            this.processTitlePicture.Name = "processTitlePicture";
            this.processTitlePicture.Size = new System.Drawing.Size(201, 22);
            this.processTitlePicture.TabIndex = 4;
            this.processTitlePicture.TabStop = false;
            this.processTitlePicture.Paint += new System.Windows.Forms.PaintEventHandler(this.processTitlePicture_Paint);
            this.processTitlePicture.DoubleClick += new System.EventHandler(this.processTitlePicture_DoubleClick);
            // 
            // processLeftPicture
            // 
            this.processLeftPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.processLeftPicture.Location = new System.Drawing.Point(0, 0);
            this.processLeftPicture.Name = "processLeftPicture";
            this.processLeftPicture.Size = new System.Drawing.Size(2, 22);
            this.processLeftPicture.TabIndex = 0;
            this.processLeftPicture.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 604);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1264, 2);
            this.splitter1.TabIndex = 31;
            this.splitter1.TabStop = false;
            // 
            // alertPopupPanel
            // 
            this.alertPopupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertPopupPanel.Controls.Add(this.alertPopupPanelCloseBtn);
            this.alertPopupPanel.Controls.Add(this.richTextBox1);
            this.alertPopupPanel.Controls.Add(this.label15);
            this.alertPopupPanel.Controls.Add(this.label14);
            this.alertPopupPanel.Controls.Add(this.label13);
            this.alertPopupPanel.Controls.Add(this.label12);
            this.alertPopupPanel.Controls.Add(this.label11);
            this.alertPopupPanel.Controls.Add(this.label10);
            this.alertPopupPanel.Controls.Add(this.label9);
            this.alertPopupPanel.Controls.Add(this.label8);
            this.alertPopupPanel.Controls.Add(this.label7);
            this.alertPopupPanel.Controls.Add(this.label6);
            this.alertPopupPanel.Controls.Add(this.label5);
            this.alertPopupPanel.Controls.Add(this.label4);
            this.alertPopupPanel.Controls.Add(this.label3);
            this.alertPopupPanel.Controls.Add(this.label2);
            this.alertPopupPanel.Controls.Add(this.label1);
            this.alertPopupPanel.Location = new System.Drawing.Point(722, 181);
            this.alertPopupPanel.Name = "alertPopupPanel";
            this.alertPopupPanel.Size = new System.Drawing.Size(233, 274);
            this.alertPopupPanel.TabIndex = 33;
            this.alertPopupPanel.Visible = false;
            // 
            // alertPopupPanelCloseBtn
            // 
            this.alertPopupPanelCloseBtn.BorderColor = System.Drawing.Color.Transparent;
            this.alertPopupPanelCloseBtn.DisableImage = null;
            this.alertPopupPanelCloseBtn.DownImage = null;
            this.alertPopupPanelCloseBtn.DrawTextMode = false;
            this.alertPopupPanelCloseBtn.Location = new System.Drawing.Point(209, 4);
            this.alertPopupPanelCloseBtn.Name = "alertPopupPanelCloseBtn";
            this.alertPopupPanelCloseBtn.OverForeColor = System.Drawing.Color.Black;
            this.alertPopupPanelCloseBtn.OverImage = null;
            this.alertPopupPanelCloseBtn.Size = new System.Drawing.Size(20, 22);
            this.alertPopupPanelCloseBtn.TabIndex = 47;
            this.alertPopupPanelCloseBtn.TabStop = false;
            this.alertPopupPanelCloseBtn.ToolTipText = "";
            this.alertPopupPanelCloseBtn.UpImage = null;
            this.alertPopupPanelCloseBtn.Click += new System.EventHandler(this.alertPopupPanelCloseBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(58, 169);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(169, 100);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = "";
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(56, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 12);
            this.label15.TabIndex = 45;
            this.label15.Text = "label15";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(56, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 12);
            this.label14.TabIndex = 44;
            this.label14.Text = "label14";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(56, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 12);
            this.label13.TabIndex = 43;
            this.label13.Text = "label13";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(56, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 12);
            this.label12.TabIndex = 42;
            this.label12.Text = "label12";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(56, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 12);
            this.label11.TabIndex = 41;
            this.label11.Text = "label11";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(56, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 12);
            this.label10.TabIndex = 40;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(56, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 12);
            this.label9.TabIndex = 39;
            this.label9.Text = "label9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 12);
            this.label8.TabIndex = 38;
            this.label8.Text = "내용";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 12);
            this.label7.TabIndex = 37;
            this.label7.Text = "위치";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "코드";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "레벨";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "시각";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "분류";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "리소스";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "호스트";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // treeMainView1
            // 
            this.treeMainView1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.treeMainView1.AllowEditing = false;
            this.treeMainView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeMainView1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.treeMainView1.ColumnInfo = "9,0,0,0,0,100,Columns:1{Visible:False;}\t2{Visible:False;}\t3{Visible:False;}\t4{Vis" +
    "ible:False;}\t5{Visible:False;}\t6{Visible:False;}\t7{Visible:False;}\t8{Visible:Fal" +
    "se;}\t";
            this.treeMainView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMainView1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.treeMainView1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.treeMainView1.ForeColor = System.Drawing.Color.White;
            this.treeMainView1.Location = new System.Drawing.Point(0, 0);
            this.treeMainView1.Name = "treeMainView1";
            this.treeMainView1.Rows.Count = 0;
            this.treeMainView1.Rows.DefaultSize = 20;
            this.treeMainView1.Rows.Fixed = 0;
            this.treeMainView1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.treeMainView1.Size = new System.Drawing.Size(214, 521);
            this.treeMainView1.StyleInfo = resources.GetString("treeMainView1.StyleInfo");
            this.treeMainView1.TabIndex = 28;
            this.treeMainView1.Tree.Column = 0;
            this.treeMainView1.Tree.LineColor = System.Drawing.Color.Black;
            this.treeMainView1.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.treeMainView_OwnerDrawCell);
            this.treeMainView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeMainView_MouseDoubleClick);
            // 
            // treeMainView2
            // 
            this.treeMainView2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.treeMainView2.AllowEditing = false;
            this.treeMainView2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeMainView2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.treeMainView2.ColumnInfo = "9,0,0,0,0,100,Columns:1{Visible:False;}\t2{Visible:False;}\t3{Visible:False;}\t4{Vis" +
    "ible:False;}\t5{Visible:False;}\t6{Visible:False;}\t7{Visible:False;}\t8{Visible:Fal" +
    "se;}\t";
            this.treeMainView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMainView2.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.treeMainView2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.treeMainView2.ForeColor = System.Drawing.Color.White;
            this.treeMainView2.Location = new System.Drawing.Point(0, 0);
            this.treeMainView2.Name = "treeMainView2";
            this.treeMainView2.Rows.Count = 0;
            this.treeMainView2.Rows.DefaultSize = 20;
            this.treeMainView2.Rows.Fixed = 0;
            this.treeMainView2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.treeMainView2.Size = new System.Drawing.Size(214, 521);
            this.treeMainView2.StyleInfo = resources.GetString("treeMainView2.StyleInfo");
            this.treeMainView2.TabIndex = 28;
            this.treeMainView2.Tree.Column = 0;
            this.treeMainView2.Tree.LineColor = System.Drawing.Color.Black;
            this.treeMainView2.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.treeMainView_OwnerDrawCell);
            this.treeMainView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeMainView_MouseDoubleClick);
            // 
            // treeMainView3
            // 
            this.treeMainView3.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.treeMainView3.AllowEditing = false;
            this.treeMainView3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeMainView3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.treeMainView3.ColumnInfo = "9,0,0,0,0,100,Columns:1{Visible:False;}\t2{Visible:False;}\t3{Visible:False;}\t4{Vis" +
    "ible:False;}\t5{Visible:False;}\t6{Visible:False;}\t7{Visible:False;}\t8{Visible:Fal" +
    "se;}\t";
            this.treeMainView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMainView3.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.treeMainView3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.treeMainView3.ForeColor = System.Drawing.Color.White;
            this.treeMainView3.Location = new System.Drawing.Point(0, 0);
            this.treeMainView3.Name = "treeMainView3";
            this.treeMainView3.Rows.Count = 0;
            this.treeMainView3.Rows.DefaultSize = 20;
            this.treeMainView3.Rows.Fixed = 0;
            this.treeMainView3.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.treeMainView3.Size = new System.Drawing.Size(214, 521);
            this.treeMainView3.StyleInfo = resources.GetString("treeMainView3.StyleInfo");
            this.treeMainView3.TabIndex = 28;
            this.treeMainView3.Tree.Column = 0;
            this.treeMainView3.Tree.LineColor = System.Drawing.Color.Black;
            this.treeMainView3.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.treeMainView_OwnerDrawCell);
            this.treeMainView3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeMainView_MouseDoubleClick);
            // 
            // treeMainView4
            // 
            this.treeMainView4.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.treeMainView4.AllowEditing = false;
            this.treeMainView4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeMainView4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.treeMainView4.ColumnInfo = "9,0,0,0,0,100,Columns:1{Visible:False;}\t2{Visible:False;}\t3{Visible:False;}\t4{Vis" +
    "ible:False;}\t5{Visible:False;}\t6{Visible:False;}\t7{Visible:False;}\t8{Visible:Fal" +
    "se;}\t";
            this.treeMainView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMainView4.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.treeMainView4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.treeMainView4.ForeColor = System.Drawing.Color.White;
            this.treeMainView4.Location = new System.Drawing.Point(0, 0);
            this.treeMainView4.Name = "treeMainView4";
            this.treeMainView4.Rows.Count = 0;
            this.treeMainView4.Rows.DefaultSize = 20;
            this.treeMainView4.Rows.Fixed = 0;
            this.treeMainView4.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.treeMainView4.Size = new System.Drawing.Size(214, 521);
            this.treeMainView4.StyleInfo = resources.GetString("treeMainView4.StyleInfo");
            this.treeMainView4.TabIndex = 28;
            this.treeMainView4.Tree.Column = 0;
            this.treeMainView4.Tree.LineColor = System.Drawing.Color.Black;
            this.treeMainView4.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.treeMainView_OwnerDrawCell);
            this.treeMainView4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeMainView_MouseDoubleClick);
            // 
            // treeMainView5
            // 
            this.treeMainView5.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.treeMainView5.AllowEditing = false;
            this.treeMainView5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeMainView5.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.treeMainView5.ColumnInfo = "9,0,0,0,0,100,Columns:1{Visible:False;}\t2{Visible:False;}\t3{Visible:False;}\t4{Vis" +
    "ible:False;}\t5{Visible:False;}\t6{Visible:False;}\t7{Visible:False;}\t8{Visible:Fal" +
    "se;}\t";
            this.treeMainView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMainView5.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.treeMainView5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.treeMainView5.ForeColor = System.Drawing.Color.White;
            this.treeMainView5.Location = new System.Drawing.Point(0, 0);
            this.treeMainView5.Name = "treeMainView5";
            this.treeMainView5.Rows.Count = 0;
            this.treeMainView5.Rows.DefaultSize = 20;
            this.treeMainView5.Rows.Fixed = 0;
            this.treeMainView5.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.treeMainView5.Size = new System.Drawing.Size(214, 521);
            this.treeMainView5.StyleInfo = resources.GetString("treeMainView5.StyleInfo");
            this.treeMainView5.TabIndex = 28;
            this.treeMainView5.Tree.Column = 0;
            this.treeMainView5.Tree.LineColor = System.Drawing.Color.Black;
            this.treeMainView5.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.treeMainView_OwnerDrawCell);
            this.treeMainView5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeMainView_MouseDoubleClick);
            // 
            // treeMainView6
            // 
            this.treeMainView6.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.treeMainView6.AllowEditing = false;
            this.treeMainView6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeMainView6.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.treeMainView6.ColumnInfo = "9,0,0,0,0,100,Columns:1{Visible:False;}\t2{Visible:False;}\t3{Visible:False;}\t4{Vis" +
    "ible:False;}\t5{Visible:False;}\t6{Visible:False;}\t7{Visible:False;}\t8{Visible:Fal" +
    "se;}\t";
            this.treeMainView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMainView6.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.treeMainView6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.treeMainView6.ForeColor = System.Drawing.Color.White;
            this.treeMainView6.Location = new System.Drawing.Point(0, 0);
            this.treeMainView6.Name = "treeMainView6";
            this.treeMainView6.Rows.Count = 0;
            this.treeMainView6.Rows.DefaultSize = 20;
            this.treeMainView6.Rows.Fixed = 0;
            this.treeMainView6.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.treeMainView6.Size = new System.Drawing.Size(214, 521);
            this.treeMainView6.StyleInfo = resources.GetString("treeMainView6.StyleInfo");
            this.treeMainView6.TabIndex = 28;
            this.treeMainView6.Tree.Column = 0;
            this.treeMainView6.Tree.LineColor = System.Drawing.Color.Black;
            this.treeMainView6.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.treeMainView_OwnerDrawCell);
            this.treeMainView6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeMainView_MouseDoubleClick);
            // 
            // treeMainView7
            // 
            this.treeMainView7.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.treeMainView7.AllowEditing = false;
            this.treeMainView7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeMainView7.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.treeMainView7.ColumnInfo = "9,0,0,0,0,100,Columns:1{Visible:False;}\t2{Visible:False;}\t3{Visible:False;}\t4{Vis" +
    "ible:False;}\t5{Visible:False;}\t6{Visible:False;}\t7{Visible:False;}\t8{Visible:Fal" +
    "se;}\t";
            this.treeMainView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMainView7.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.treeMainView7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.treeMainView7.ForeColor = System.Drawing.Color.White;
            this.treeMainView7.Location = new System.Drawing.Point(0, 0);
            this.treeMainView7.Name = "treeMainView7";
            this.treeMainView7.Rows.Count = 0;
            this.treeMainView7.Rows.DefaultSize = 20;
            this.treeMainView7.Rows.Fixed = 0;
            this.treeMainView7.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.treeMainView7.Size = new System.Drawing.Size(214, 521);
            this.treeMainView7.StyleInfo = resources.GetString("treeMainView7.StyleInfo");
            this.treeMainView7.TabIndex = 28;
            this.treeMainView7.Tree.Column = 0;
            this.treeMainView7.Tree.LineColor = System.Drawing.Color.Black;
            this.treeMainView7.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.treeMainView_OwnerDrawCell);
            this.treeMainView7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeMainView_MouseDoubleClick);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.treeMainView1);
            this.panel10.Controls.Add(this.treeMainView2);
            this.panel10.Controls.Add(this.treeMainView3);
            this.panel10.Controls.Add(this.treeMainView4);
            this.panel10.Controls.Add(this.treeMainView5);
            this.panel10.Controls.Add(this.treeMainView6);
            this.panel10.Controls.Add(this.treeMainView7);
            this.panel10.Controls.Add(this.splitter3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 79);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(216, 525);
            this.panel10.TabIndex = 35;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(0, 521);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(214, 2);
            this.splitter3.TabIndex = 27;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.splitter2.Location = new System.Drawing.Point(216, 79);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(2, 525);
            this.splitter2.TabIndex = 36;
            this.splitter2.TabStop = false;
            // 
            // APMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 844);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.alertPopupPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.mainStatusPanel);
            this.Controls.Add(this.mainToolbarPanel);
            this.Controls.Add(this.mainTopPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "APMMain";
            this.Text = "Exture 3.0 APM";
            this.TopMost = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.APMMain_FormClosed);
            this.Load += new System.EventHandler(this.APMMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.APMMain_Paint);
            this.Resize += new System.EventHandler(this.APMMain_Resize);
            this.mainToolbarPanel.ResumeLayout(false);
            this.mainToolbarPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolbatSetupBtn)).EndInit();
            this.mainTopPanel.ResumeLayout(false);
            this.mainTopPanel.PerformLayout();
            this.mainSystemButtonPanel.ResumeLayout(false);
            this.mainSystemButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMaxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMinBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIconPictureBox)).EndInit();
            this.MNU_MainMenu.ResumeLayout(false);
            this.MNU_MainMenu.PerformLayout();
            this.mainStatusPanel.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlertMsgInfoPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessMsgInfoPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogMsgInfoPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventMsgInfoPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendInfoPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recvInfoPanel)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_Pms7)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Message7)).EndInit();
            this.alertTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alertTitlePicture)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Event7)).EndInit();
            this.eventTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventTitlePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLeftPicture)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Log7)).EndInit();
            this.logTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logTitlePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLeftPicture)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSV_MSG_Process7)).EndInit();
            this.processTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processTitlePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processLeftPicture)).EndInit();
            this.alertPopupPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alertPopupPanelCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMainView7)).EndInit();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel mainTopPanel;
        private System.Windows.Forms.Panel mainToolbarPanel;
        private System.Windows.Forms.MenuStrip MNU_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바둑판정렬ToolStripMenuItem;
        private System.Windows.Forms.Panel mainStatusPanel;
        private System.Windows.Forms.PictureBox mainIconPictureBox;
        private System.Windows.Forms.Panel mainCaptionLeftPanel;
        private System.Windows.Forms.Panel mainSystemButtonPanel;
        private APMPublicLib.Common.APMPictureButton mainCloseBtn;
        private APMPublicLib.Common.APMPictureButton mainMaxBtn;
        private APMPublicLib.Common.APMPictureButton mainMinBtn;
        private System.Windows.Forms.Panel mainCaptionRightPanel;
        private System.Windows.Forms.PictureBox sendInfoPanel;
        private System.Windows.Forms.PictureBox recvInfoPanel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem soundOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPMInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panel4ToolStripMenuItem;
        private System.Windows.Forms.PictureBox AlertMsgInfoPanel;
        private System.Windows.Forms.PictureBox ProcessMsgInfoPanel;
        private System.Windows.Forms.PictureBox LogMsgInfoPanel;
        private System.Windows.Forms.PictureBox EventMsgInfoPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel eventTopPanel;
        private System.Windows.Forms.PictureBox eventTitlePicture;
        private System.Windows.Forms.PictureBox eventLeftPicture;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel logTopPanel;
        private System.Windows.Forms.PictureBox logTitlePicture;
        private System.Windows.Forms.PictureBox logLeftPicture;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel processTopPanel;
        private System.Windows.Forms.PictureBox processTitlePicture;
        private System.Windows.Forms.PictureBox processLeftPicture;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel alertTopPanel;
        private System.Windows.Forms.PictureBox alertTitlePicture;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel mainToolbarPanelTop;
        private APMPublicLib.Common.APMPictureButton toolbatSetupBtn;
        private APMPublicLib.Common.APMOpenWndToolbarPanel mainToolbarOpenWindowPanel;
        private System.Windows.Forms.ToolStripMenuItem treeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWindowToolStripMenuItem;
        private System.Windows.Forms.Panel alertPopupPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private APMPublicLib.Common.APMPictureButton alertPopupPanelCloseBtn;
        private System.Windows.Forms.ToolStripMenuItem alertPopupViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPasswordChangeToolStripMenuItem;
        private System.Windows.Forms.Panel panel13;
        private C1.Win.C1FlexGrid.C1FlexGrid LSV_MSG_Event1, LSV_MSG_Event2, LSV_MSG_Event3, LSV_MSG_Event4, LSV_MSG_Event5, LSV_MSG_Event6, LSV_MSG_Event7;
        private C1.Win.C1FlexGrid.C1FlexGrid LSV_MSG_Log1, LSV_MSG_Log2, LSV_MSG_Log3, LSV_MSG_Log4, LSV_MSG_Log5, LSV_MSG_Log6, LSV_MSG_Log7;
        private C1.Win.C1FlexGrid.C1FlexGrid LSV_MSG_Process1, LSV_MSG_Process2, LSV_MSG_Process3, LSV_MSG_Process4, LSV_MSG_Process5, LSV_MSG_Process6, LSV_MSG_Process7;
        private C1.Win.C1FlexGrid.C1FlexGrid LSV_MSG_Message1, LSV_MSG_Message2, LSV_MSG_Message3, LSV_MSG_Message4, LSV_MSG_Message5, LSV_MSG_Message6, LSV_MSG_Message7;
        private C1.Win.C1FlexGrid.C1FlexGrid LSV_Pms1, LSV_Pms2, LSV_Pms3, LSV_Pms4, LSV_Pms5, LSV_Pms6, LSV_Pms7;
        private C1.Win.C1FlexGrid.C1FlexGrid treeMainView1, treeMainView2, treeMainView3, treeMainView4, treeMainView5, treeMainView6, treeMainView7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox serverInfoComboBox;
        private System.Windows.Forms.Panel InfoPanel;
#endif
}

