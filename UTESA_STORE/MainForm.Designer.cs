namespace UTESA_STORE
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbSideMenuLogo = new System.Windows.Forms.PictureBox();
            this.pbProfilePicture = new UTESA_STORE.RJControls.CTCircularPictureBox();
            this.lblUserName = new UTESA_STORE.RJControls.CTLabel();
            this.dmUserOptions = new UTESA_STORE.RJControls.CTDropdownMenu(this.components);
            this.miMyProfile = new FontAwesome.Sharp.IconMenuItem();
            this.miSettings = new FontAwesome.Sharp.IconMenuItem();
            this.miTermsCond = new FontAwesome.Sharp.IconMenuItem();
            this.miHelp = new FontAwesome.Sharp.IconMenuItem();
            this.miLogout = new FontAwesome.Sharp.IconMenuItem();
            this.miExit = new FontAwesome.Sharp.IconMenuItem();
            this.dmSalesOrder = new UTESA_STORE.RJControls.CTDropdownMenu(this.components);
            this.salesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingDeliveriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hightPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProducts = new UTESA_STORE.RJControls.CTMenuButton();
            this.btnCustomers = new UTESA_STORE.RJControls.CTMenuButton();
            this.dmCustomControls = new UTESA_STORE.RJControls.CTDropdownMenu(this.components);
            this.commonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dmCustomForms = new UTESA_STORE.RJControls.CTDropdownMenu(this.components);
            this.baseFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rjLabel1 = new UTESA_STORE.RJControls.CTLabel();
            this.rjLabel2 = new UTESA_STORE.RJControls.CTLabel();
            this.BtnSaleNav = new UTESA_STORE.RJControls.CTMenuButton();
            this.pnlSideMenu.SuspendLayout();
            this.pnlSideMenuHeader.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSideMenuLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.dmUserOptions.SuspendLayout();
            this.dmSalesOrder.SuspendLayout();
            this.dmCustomControls.SuspendLayout();
            this.dmCustomForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.Controls.Add(this.BtnSaleNav);
            this.pnlSideMenu.Controls.Add(this.btnCustomers);
            this.pnlSideMenu.Controls.Add(this.btnProducts);
            this.pnlSideMenu.Size = new System.Drawing.Size(220, 548);
            this.pnlSideMenu.Controls.SetChildIndex(this.btnProducts, 0);
            this.pnlSideMenu.Controls.SetChildIndex(this.btnCustomers, 0);
            this.pnlSideMenu.Controls.SetChildIndex(this.BtnSaleNav, 0);
            // 
            // pnlSideMenuHeader
            // 
            this.pnlSideMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.pnlSideMenuHeader.Controls.Add(this.pbSideMenuLogo);
            this.pnlSideMenuHeader.Controls.SetChildIndex(this.pbSideMenuLogo, 0);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.lblUserName);
            this.pnlTitleBar.Controls.Add(this.pbProfilePicture);
            this.pnlTitleBar.Location = new System.Drawing.Point(221, 1);
            this.pnlTitleBar.Size = new System.Drawing.Size(958, 60);
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitleBar_Paint);
            this.pnlTitleBar.Controls.SetChildIndex(this.pbProfilePicture, 0);
            this.pnlTitleBar.Controls.SetChildIndex(this.lblUserName, 0);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Controls.Add(this.rjLabel2);
            this.pnlDesktop.Controls.Add(this.rjLabel1);
            this.pnlDesktop.Controls.Add(this.pictureBox2);
            this.pnlDesktop.Location = new System.Drawing.Point(221, 86);
            this.pnlDesktop.Size = new System.Drawing.Size(958, 523);
            // 
            // pnlDesktopHeader
            // 
            this.pnlDesktopHeader.Location = new System.Drawing.Point(221, 61);
            this.pnlDesktopHeader.Size = new System.Drawing.Size(958, 25);
            // 
            // pbSideMenuLogo
            // 
            this.pbSideMenuLogo.Image = global::UTESA_STORE.Properties.Resources.logo_size;
            this.pbSideMenuLogo.Location = new System.Drawing.Point(9, 5);
            this.pbSideMenuLogo.Name = "pbSideMenuLogo";
            this.pbSideMenuLogo.Size = new System.Drawing.Size(110, 50);
            this.pbSideMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSideMenuLogo.TabIndex = 1;
            this.pbSideMenuLogo.TabStop = false;
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProfilePicture.Image = global::UTESA_STORE.Properties.Resources.userProfile;
            this.pbProfilePicture.Location = new System.Drawing.Point(787, 13);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(35, 35);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 7;
            this.pbProfilePicture.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserName.LinkLabel = false;
            this.lblUserName.Location = new System.Drawing.Point(828, 23);
            this.lblUserName.MaximumSize = new System.Drawing.Size(95, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 16);
            this.lblUserName.Style = UTESA_STORE.RJControls.LabelStyle.BarText;
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // dmUserOptions
            // 
            this.dmUserOptions.ActiveMenuItem = false;
            this.dmUserOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmUserOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMyProfile,
            this.miSettings,
            this.miTermsCond,
            this.miHelp,
            this.miLogout,
            this.miExit});
            this.dmUserOptions.Name = "dmUserOptions";
            this.dmUserOptions.OwnerIsMenuButton = false;
            this.dmUserOptions.Size = new System.Drawing.Size(182, 136);
            // 
            // miMyProfile
            // 
            this.miMyProfile.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.miMyProfile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(85)))), ((int)(((byte)(230)))));
            this.miMyProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miMyProfile.IconSize = 21;
            this.miMyProfile.Name = "miMyProfile";
            this.miMyProfile.Size = new System.Drawing.Size(181, 22);
            this.miMyProfile.Text = "My Profile";
            this.miMyProfile.Click += new System.EventHandler(this.miMyProfile_Click);
            // 
            // miSettings
            // 
            this.miSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.miSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(168)))), ((int)(((byte)(210)))));
            this.miSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miSettings.IconSize = 21;
            this.miSettings.Name = "miSettings";
            this.miSettings.Size = new System.Drawing.Size(181, 22);
            this.miSettings.Text = "Settings";
            // 
            // miTermsCond
            // 
            this.miTermsCond.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.miTermsCond.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(235)))));
            this.miTermsCond.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miTermsCond.IconSize = 21;
            this.miTermsCond.Name = "miTermsCond";
            this.miTermsCond.Size = new System.Drawing.Size(181, 22);
            this.miTermsCond.Text = "Terms and Cond";
            this.miTermsCond.Click += new System.EventHandler(this.miTermsCond_Click);
            // 
            // miHelp
            // 
            this.miHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.miHelp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.miHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miHelp.IconSize = 21;
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(181, 22);
            this.miHelp.Text = "Help";
            this.miHelp.Click += new System.EventHandler(this.miHelp_Click);
            // 
            // miLogout
            // 
            this.miLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.miLogout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(228)))));
            this.miLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miLogout.IconSize = 21;
            this.miLogout.Name = "miLogout";
            this.miLogout.Size = new System.Drawing.Size(181, 22);
            this.miLogout.Text = "Logout";
            this.miLogout.Click += new System.EventHandler(this.miLogout_Click);
            // 
            // miExit
            // 
            this.miExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.miExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(37)))), ((int)(((byte)(118)))));
            this.miExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miExit.IconSize = 21;
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(181, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // dmSalesOrder
            // 
            this.dmSalesOrder.ActiveMenuItem = false;
            this.dmSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmSalesOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesListToolStripMenuItem,
            this.salesListToolStripMenuItem1,
            this.pendingDeliveriesToolStripMenuItem,
            this.dropSaleToolStripMenuItem,
            this.renewSalesToolStripMenuItem});
            this.dmSalesOrder.Name = "dmSalesOrder";
            this.dmSalesOrder.OwnerIsMenuButton = false;
            this.dmSalesOrder.Size = new System.Drawing.Size(195, 114);
            // 
            // salesListToolStripMenuItem
            // 
            this.salesListToolStripMenuItem.Name = "salesListToolStripMenuItem";
            this.salesListToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.salesListToolStripMenuItem.Text = "New Sale";
            // 
            // salesListToolStripMenuItem1
            // 
            this.salesListToolStripMenuItem1.Name = "salesListToolStripMenuItem1";
            this.salesListToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.salesListToolStripMenuItem1.Text = "Sales List";
            // 
            // pendingDeliveriesToolStripMenuItem
            // 
            this.pendingDeliveriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hightPriorityToolStripMenuItem,
            this.mediumPriorityToolStripMenuItem,
            this.lowPriorityToolStripMenuItem});
            this.pendingDeliveriesToolStripMenuItem.Name = "pendingDeliveriesToolStripMenuItem";
            this.pendingDeliveriesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pendingDeliveriesToolStripMenuItem.Text = "Pending Deliveries";
            // 
            // hightPriorityToolStripMenuItem
            // 
            this.hightPriorityToolStripMenuItem.Name = "hightPriorityToolStripMenuItem";
            this.hightPriorityToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.hightPriorityToolStripMenuItem.Text = "Hight Priority";
            // 
            // mediumPriorityToolStripMenuItem
            // 
            this.mediumPriorityToolStripMenuItem.Name = "mediumPriorityToolStripMenuItem";
            this.mediumPriorityToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.mediumPriorityToolStripMenuItem.Text = "Medium Priority";
            // 
            // lowPriorityToolStripMenuItem
            // 
            this.lowPriorityToolStripMenuItem.Name = "lowPriorityToolStripMenuItem";
            this.lowPriorityToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.lowPriorityToolStripMenuItem.Text = "Low Priority";
            // 
            // dropSaleToolStripMenuItem
            // 
            this.dropSaleToolStripMenuItem.Name = "dropSaleToolStripMenuItem";
            this.dropSaleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.dropSaleToolStripMenuItem.Text = "Drop Sales";
            // 
            // renewSalesToolStripMenuItem
            // 
            this.renewSalesToolStripMenuItem.Name = "renewSalesToolStripMenuItem";
            this.renewSalesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.renewSalesToolStripMenuItem.Text = "Renew Sales";
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.DropdownMenu = null;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnProducts.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducts.IconSize = 28;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 65);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(220, 55);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "   Productos";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.DropdownMenu = null;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnCustomers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomers.IconSize = 28;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 120);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCustomers.Size = new System.Drawing.Size(220, 55);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "   Clientes";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // dmCustomControls
            // 
            this.dmCustomControls.ActiveMenuItem = false;
            this.dmCustomControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmCustomControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commonToolStripMenuItem,
            this.menusToolStripMenuItem,
            this.containersToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.componentsToolStripMenuItem,
            this.specialsToolStripMenuItem});
            this.dmCustomControls.Name = "dmCustomControls";
            this.dmCustomControls.OwnerIsMenuButton = false;
            this.dmCustomControls.Size = new System.Drawing.Size(156, 136);
            // 
            // commonToolStripMenuItem
            // 
            this.commonToolStripMenuItem.Name = "commonToolStripMenuItem";
            this.commonToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.commonToolStripMenuItem.Text = "Common";
            // 
            // menusToolStripMenuItem
            // 
            this.menusToolStripMenuItem.Name = "menusToolStripMenuItem";
            this.menusToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.menusToolStripMenuItem.Text = "Menus";
            // 
            // containersToolStripMenuItem
            // 
            this.containersToolStripMenuItem.Name = "containersToolStripMenuItem";
            this.containersToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.containersToolStripMenuItem.Text = "Containers";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // componentsToolStripMenuItem
            // 
            this.componentsToolStripMenuItem.Name = "componentsToolStripMenuItem";
            this.componentsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.componentsToolStripMenuItem.Text = "Components";
            // 
            // specialsToolStripMenuItem
            // 
            this.specialsToolStripMenuItem.Name = "specialsToolStripMenuItem";
            this.specialsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.specialsToolStripMenuItem.Text = "Specials";
            // 
            // dmCustomForms
            // 
            this.dmCustomForms.ActiveMenuItem = false;
            this.dmCustomForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmCustomForms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseFormToolStripMenuItem,
            this.mainFormToolStripMenuItem,
            this.childFormToolStripMenuItem});
            this.dmCustomForms.Name = "dmCustomForms";
            this.dmCustomForms.OwnerIsMenuButton = false;
            this.dmCustomForms.Size = new System.Drawing.Size(145, 70);
            // 
            // baseFormToolStripMenuItem
            // 
            this.baseFormToolStripMenuItem.Name = "baseFormToolStripMenuItem";
            this.baseFormToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.baseFormToolStripMenuItem.Text = "Base Form";
            // 
            // mainFormToolStripMenuItem
            // 
            this.mainFormToolStripMenuItem.Name = "mainFormToolStripMenuItem";
            this.mainFormToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.mainFormToolStripMenuItem.Text = "Main Form";
            // 
            // childFormToolStripMenuItem
            // 
            this.childFormToolStripMenuItem.Name = "childFormToolStripMenuItem";
            this.childFormToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.childFormToolStripMenuItem.Text = "Child Form";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::UTESA_STORE.Properties.Resources.logo_size_invert;
            this.pictureBox2.Location = new System.Drawing.Point(319, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // rjLabel1
            // 
            this.rjLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjLabel1.AutoSize = true;
            this.rjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel1.Font = new System.Drawing.Font("Verdana", 18F);
            this.rjLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel1.LinkLabel = false;
            this.rjLabel1.Location = new System.Drawing.Point(394, 271);
            this.rjLabel1.Name = "rjLabel1";
            this.rjLabel1.Size = new System.Drawing.Size(140, 29);
            this.rjLabel1.Style = UTESA_STORE.RJControls.LabelStyle.Custom;
            this.rjLabel1.TabIndex = 1;
            this.rjLabel1.Text = "1-11-1414";
            this.rjLabel1.Click += new System.EventHandler(this.rjLabel1_Click);
            // 
            // rjLabel2
            // 
            this.rjLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjLabel2.AutoSize = true;
            this.rjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel2.LinkLabel = false;
            this.rjLabel2.Location = new System.Drawing.Point(413, 300);
            this.rjLabel2.Name = "rjLabel2";
            this.rjLabel2.Size = new System.Drawing.Size(103, 18);
            this.rjLabel2.Style = UTESA_STORE.RJControls.LabelStyle.Custom;
            this.rjLabel2.TabIndex = 2;
            this.rjLabel2.Text = "Wadson Vaval";
            // 
            // BtnSaleNav
            // 
            this.BtnSaleNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.BtnSaleNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSaleNav.DropdownMenu = null;
            this.BtnSaleNav.FlatAppearance.BorderSize = 0;
            this.BtnSaleNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaleNav.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaleNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.BtnSaleNav.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.BtnSaleNav.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.BtnSaleNav.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSaleNav.IconSize = 28;
            this.BtnSaleNav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaleNav.Location = new System.Drawing.Point(0, 175);
            this.BtnSaleNav.Name = "BtnSaleNav";
            this.BtnSaleNav.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtnSaleNav.Size = new System.Drawing.Size(220, 55);
            this.BtnSaleNav.TabIndex = 5;
            this.BtnSaleNav.Text = "   Ventas";
            this.BtnSaleNav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaleNav.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSaleNav.UseVisualStyleBackColor = false;
            this.BtnSaleNav.Click += new System.EventHandler(this.BtnSaleNav_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.BorderSize = 1;
            this.ClientSize = new System.Drawing.Size(1180, 610);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.Controls.SetChildIndex(this.pnlTitleBar, 0);
            this.Controls.SetChildIndex(this.pnlDesktopHeader, 0);
            this.Controls.SetChildIndex(this.pnlDesktop, 0);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenuHeader.ResumeLayout(false);
            this.pnlSideMenuHeader.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSideMenuLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.dmUserOptions.ResumeLayout(false);
            this.dmSalesOrder.ResumeLayout(false);
            this.dmCustomControls.ResumeLayout(false);
            this.dmCustomForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSideMenuLogo;
        private RJControls.CTLabel lblUserName;
        private RJControls.CTCircularPictureBox pbProfilePicture;
        private RJControls.CTDropdownMenu dmUserOptions;
        private FontAwesome.Sharp.IconMenuItem miMyProfile;
        private FontAwesome.Sharp.IconMenuItem miSettings;
        private FontAwesome.Sharp.IconMenuItem miTermsCond;
        private FontAwesome.Sharp.IconMenuItem miHelp;
        private FontAwesome.Sharp.IconMenuItem miLogout;
        private FontAwesome.Sharp.IconMenuItem miExit;
        private RJControls.CTMenuButton btnCustomers;
        private RJControls.CTMenuButton btnProducts;
        private RJControls.CTDropdownMenu dmSalesOrder;
        private System.Windows.Forms.ToolStripMenuItem salesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pendingDeliveriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewSalesToolStripMenuItem;
        private RJControls.CTDropdownMenu dmCustomControls;
        private System.Windows.Forms.ToolStripMenuItem commonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem containersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hightPriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumPriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowPriorityToolStripMenuItem;
        private RJControls.CTDropdownMenu dmCustomForms;
        private System.Windows.Forms.ToolStripMenuItem baseFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem childFormToolStripMenuItem;
        private RJControls.CTLabel rjLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJControls.CTLabel rjLabel2;
        private RJControls.CTMenuButton BtnSaleNav;
    }
}