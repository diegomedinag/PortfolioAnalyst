namespace PortfolioAnalystUIW
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.SkinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.SkinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.BarButtonItemUsers = new DevExpress.XtraBars.BarButtonItem();
            this.BarStaticItemDbConnection = new DevExpress.XtraBars.BarStaticItem();
            this.BarStaticItemUser = new DevExpress.XtraBars.BarStaticItem();
            this.BarButtonItemAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItemUserProfiles = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItemBrokers = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItemCurrencies = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItemReportDesigner = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItemExcelDesigner = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItemHtmlDesigner = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItemDashboardDesigner = new DevExpress.XtraBars.BarButtonItem();
            this.RibbonPagePortfolio = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RibbonPageFiles = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RibbonPageGroupAgents = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RibbonPageGroupBasicData = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RibbonPageSetup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RibbonPageGroupSkin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RibbonPageGroupReporting = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RibbonPageHelp = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar2 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.DocumentManagerMainForm = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentManagerMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RibbonControl1
            // 
            this.RibbonControl1.ExpandCollapseItem.Id = 0;
            this.RibbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RibbonControl1.ExpandCollapseItem,
            this.SkinPaletteDropDownButtonItem1,
            this.SkinDropDownButtonItem1,
            this.BarButtonItemUsers,
            this.BarStaticItemDbConnection,
            this.BarStaticItemUser,
            this.BarButtonItemAccounts,
            this.BarButtonItemUserProfiles,
            this.BarButtonItemBrokers,
            this.BarButtonItemCurrencies,
            this.BarButtonItemReportDesigner,
            this.BarButtonItemExcelDesigner,
            this.BarButtonItemHtmlDesigner,
            this.BarButtonItemDashboardDesigner});
            this.RibbonControl1.Location = new System.Drawing.Point(0, 0);
            this.RibbonControl1.MaxItemId = 17;
            this.RibbonControl1.Name = "RibbonControl1";
            this.RibbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RibbonPagePortfolio,
            this.RibbonPageFiles,
            this.RibbonPageSetup,
            this.RibbonPageHelp});
            this.RibbonControl1.Size = new System.Drawing.Size(766, 158);
            this.RibbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // SkinPaletteDropDownButtonItem1
            // 
            this.SkinPaletteDropDownButtonItem1.Id = 4;
            this.SkinPaletteDropDownButtonItem1.Name = "SkinPaletteDropDownButtonItem1";
            // 
            // SkinDropDownButtonItem1
            // 
            this.SkinDropDownButtonItem1.Id = 5;
            this.SkinDropDownButtonItem1.Name = "SkinDropDownButtonItem1";
            // 
            // BarButtonItemUsers
            // 
            this.BarButtonItemUsers.Caption = "Users";
            this.BarButtonItemUsers.Id = 6;
            this.BarButtonItemUsers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarButtonItemUsers.ImageOptions.SvgImage")));
            this.BarButtonItemUsers.Name = "BarButtonItemUsers";
            this.BarButtonItemUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemUsers_ItemClick);
            // 
            // BarStaticItemDbConnection
            // 
            this.BarStaticItemDbConnection.Caption = "Connected to DB";
            this.BarStaticItemDbConnection.Id = 7;
            this.BarStaticItemDbConnection.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarStaticItemDbConnection.ImageOptions.SvgImage")));
            this.BarStaticItemDbConnection.Name = "BarStaticItemDbConnection";
            this.BarStaticItemDbConnection.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // BarStaticItemUser
            // 
            this.BarStaticItemUser.Caption = "User";
            this.BarStaticItemUser.Id = 8;
            this.BarStaticItemUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarStaticItemUser.ImageOptions.SvgImage")));
            this.BarStaticItemUser.Name = "BarStaticItemUser";
            this.BarStaticItemUser.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // BarButtonItemAccounts
            // 
            this.BarButtonItemAccounts.Caption = "Accounts";
            this.BarButtonItemAccounts.Id = 9;
            this.BarButtonItemAccounts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarButtonItemAccounts.ImageOptions.SvgImage")));
            this.BarButtonItemAccounts.Name = "BarButtonItemAccounts";
            this.BarButtonItemAccounts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemAccounts_ItemClick);
            // 
            // BarButtonItemUserProfiles
            // 
            this.BarButtonItemUserProfiles.Caption = "Users Profiles";
            this.BarButtonItemUserProfiles.Id = 10;
            this.BarButtonItemUserProfiles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarButtonItemUserProfiles.ImageOptions.SvgImage")));
            this.BarButtonItemUserProfiles.Name = "BarButtonItemUserProfiles";
            // 
            // BarButtonItemBrokers
            // 
            this.BarButtonItemBrokers.Caption = "Brokers";
            this.BarButtonItemBrokers.Id = 11;
            this.BarButtonItemBrokers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarButtonItemBrokers.ImageOptions.SvgImage")));
            this.BarButtonItemBrokers.Name = "BarButtonItemBrokers";
            // 
            // BarButtonItemCurrencies
            // 
            this.BarButtonItemCurrencies.Caption = "Currencies";
            this.BarButtonItemCurrencies.Id = 12;
            this.BarButtonItemCurrencies.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarButtonItemCurrencies.ImageOptions.SvgImage")));
            this.BarButtonItemCurrencies.Name = "BarButtonItemCurrencies";
            // 
            // BarButtonItemReportDesigner
            // 
            this.BarButtonItemReportDesigner.Caption = "Report designer";
            this.BarButtonItemReportDesigner.Id = 13;
            this.BarButtonItemReportDesigner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarButtonItemReportDesigner.ImageOptions.SvgImage")));
            this.BarButtonItemReportDesigner.Name = "BarButtonItemReportDesigner";
            // 
            // BarButtonItemExcelDesigner
            // 
            this.BarButtonItemExcelDesigner.Caption = "Excel designer";
            this.BarButtonItemExcelDesigner.Id = 14;
            this.BarButtonItemExcelDesigner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarButtonItemExcelDesigner.ImageOptions.SvgImage")));
            this.BarButtonItemExcelDesigner.Name = "BarButtonItemExcelDesigner";
            // 
            // BarButtonItemHtmlDesigner
            // 
            this.BarButtonItemHtmlDesigner.Caption = "HTML designer";
            this.BarButtonItemHtmlDesigner.Id = 15;
            this.BarButtonItemHtmlDesigner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarButtonItemHtmlDesigner.ImageOptions.SvgImage")));
            this.BarButtonItemHtmlDesigner.Name = "BarButtonItemHtmlDesigner";
            // 
            // BarButtonItemDashboardDesigner
            // 
            this.BarButtonItemDashboardDesigner.Caption = "Dashboard designer";
            this.BarButtonItemDashboardDesigner.Id = 16;
            this.BarButtonItemDashboardDesigner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarButtonItemDashboardDesigner.ImageOptions.SvgImage")));
            this.BarButtonItemDashboardDesigner.Name = "BarButtonItemDashboardDesigner";
            // 
            // RibbonPagePortfolio
            // 
            this.RibbonPagePortfolio.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.RibbonPagePortfolio.Name = "RibbonPagePortfolio";
            this.RibbonPagePortfolio.Text = "Portfolio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // RibbonPageFiles
            // 
            this.RibbonPageFiles.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.RibbonPageGroupAgents,
            this.RibbonPageGroupBasicData});
            this.RibbonPageFiles.Name = "RibbonPageFiles";
            this.RibbonPageFiles.Text = "Files";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BarButtonItemAccounts);
            this.ribbonPageGroup2.ItemLinks.Add(this.BarButtonItemUsers);
            this.ribbonPageGroup2.ItemLinks.Add(this.BarButtonItemUserProfiles);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Authentication";
            // 
            // RibbonPageGroupAgents
            // 
            this.RibbonPageGroupAgents.ItemLinks.Add(this.BarButtonItemBrokers);
            this.RibbonPageGroupAgents.Name = "RibbonPageGroupAgents";
            this.RibbonPageGroupAgents.Text = "Agents";
            // 
            // RibbonPageGroupBasicData
            // 
            this.RibbonPageGroupBasicData.ItemLinks.Add(this.BarButtonItemCurrencies);
            this.RibbonPageGroupBasicData.Name = "RibbonPageGroupBasicData";
            this.RibbonPageGroupBasicData.Text = "Basic data";
            // 
            // RibbonPageSetup
            // 
            this.RibbonPageSetup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RibbonPageGroupSkin,
            this.RibbonPageGroupReporting});
            this.RibbonPageSetup.Name = "RibbonPageSetup";
            this.RibbonPageSetup.Text = "Setup";
            // 
            // RibbonPageGroupSkin
            // 
            this.RibbonPageGroupSkin.ItemLinks.Add(this.SkinDropDownButtonItem1);
            this.RibbonPageGroupSkin.ItemLinks.Add(this.SkinPaletteDropDownButtonItem1);
            this.RibbonPageGroupSkin.Name = "RibbonPageGroupSkin";
            this.RibbonPageGroupSkin.Text = "Skin";
            // 
            // RibbonPageGroupReporting
            // 
            this.RibbonPageGroupReporting.ItemLinks.Add(this.BarButtonItemReportDesigner);
            this.RibbonPageGroupReporting.ItemLinks.Add(this.BarButtonItemExcelDesigner);
            this.RibbonPageGroupReporting.ItemLinks.Add(this.BarButtonItemHtmlDesigner);
            this.RibbonPageGroupReporting.ItemLinks.Add(this.BarButtonItemDashboardDesigner);
            this.RibbonPageGroupReporting.Name = "RibbonPageGroupReporting";
            this.RibbonPageGroupReporting.Text = "Reporting";
            // 
            // RibbonPageHelp
            // 
            this.RibbonPageHelp.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.RibbonPageHelp.Name = "RibbonPageHelp";
            this.RibbonPageHelp.Text = "Help";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonStatusBar2
            // 
            this.ribbonStatusBar2.Location = new System.Drawing.Point(0, 415);
            this.ribbonStatusBar2.Name = "ribbonStatusBar2";
            this.ribbonStatusBar2.Ribbon = this.RibbonControl1;
            this.ribbonStatusBar2.Size = new System.Drawing.Size(766, 27);
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.BarStaticItemDbConnection);
            this.ribbonStatusBar1.ItemLinks.Add(this.BarStaticItemUser);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 442);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.RibbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(766, 24);
            // 
            // DocumentManagerMainForm
            // 
            this.DocumentManagerMainForm.MdiParent = this;
            this.DocumentManagerMainForm.MenuManager = this.RibbonControl1;
            this.DocumentManagerMainForm.View = this.tabbedView1;
            this.DocumentManagerMainForm.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 466);
            this.Controls.Add(this.ribbonStatusBar2);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.RibbonControl1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Ribbon = this.RibbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Portfolio Analyst";
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentManagerMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage RibbonPagePortfolio;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage RibbonPageFiles;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage RibbonPageSetup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RibbonPageGroupSkin;
        private DevExpress.XtraBars.Ribbon.RibbonPage RibbonPageHelp;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem SkinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem SkinDropDownButtonItem1;
        private DevExpress.XtraBars.BarButtonItem BarButtonItemUsers;
        private DevExpress.XtraBars.BarStaticItem BarStaticItemDbConnection;
        private DevExpress.XtraBars.BarStaticItem BarStaticItemUser;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem BarButtonItemAccounts;
        private DevExpress.XtraBars.BarButtonItem BarButtonItemUserProfiles;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RibbonPageGroupAgents;
        private DevExpress.XtraBars.Docking2010.DocumentManager DocumentManagerMainForm;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem BarButtonItemBrokers;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RibbonPageGroupBasicData;
        private DevExpress.XtraBars.BarButtonItem BarButtonItemCurrencies;
        private DevExpress.XtraBars.BarButtonItem BarButtonItemReportDesigner;
        private DevExpress.XtraBars.BarButtonItem BarButtonItemExcelDesigner;
        private DevExpress.XtraBars.BarButtonItem BarButtonItemHtmlDesigner;
        private DevExpress.XtraBars.BarButtonItem BarButtonItemDashboardDesigner;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RibbonPageGroupReporting;
    }
}

