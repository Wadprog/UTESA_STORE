namespace UTESA_STORE
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.dragControl1 = new UTESA_STORE.RJControls.CTDragControl(this.components);
            this.lblCaption = new UTESA_STORE.RJControls.CTLabel();
            this.txtUser = new UTESA_STORE.RJControls.CTTextBox();
            this.txtPassword = new UTESA_STORE.RJControls.CTTextBox();
            this.lblForgotPass = new UTESA_STORE.RJControls.CTLabel();
            this.dragControl2 = new UTESA_STORE.RJControls.CTDragControl(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.rjBarIcon2 = new UTESA_STORE.RJControls.CTMenuIcon();
            this.rjBarIcon1 = new UTESA_STORE.RJControls.CTMenuIcon();
            this.btnLogin = new UTESA_STORE.RJControls.CTButton();
            this.icoBanner = new UTESA_STORE.RJControls.CTImageColorOverlay();
            ((System.ComponentModel.ISupportInitialize)(this.rjBarIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjBarIcon1)).BeginInit();
            this.icoBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragControl1
            // 
            this.dragControl1.DragControl = this;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCaption.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.lblCaption.LinkLabel = false;
            this.lblCaption.Location = new System.Drawing.Point(43, 49);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(63, 23);
            this.lblCaption.Style = UTESA_STORE.RJControls.LabelStyle.Title2;
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "Login";
            // 
            // txtUser
            // 
            this.txtUser._Customizable = false;
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtUser.BorderSize = 2;
            this.txtUser.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(75, 127);
            this.txtUser.MaxLength = 100;
            this.txtUser.MultiLine = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.txtUser.PasswordChar = false;
            this.txtUser.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtUser.PlaceHolderText = "Username";
            this.txtUser.Size = new System.Drawing.Size(254, 35);
            this.txtUser.Style = UTESA_STORE.RJControls.TextBoxStyle.MatteLine;
            this.txtUser.TabIndex = 2;
            this.txtUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // txtPassword
            // 
            this.txtPassword._Customizable = false;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtPassword.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(75, 183);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.MultiLine = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceHolderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(254, 35);
            this.txtPassword.Style = UTESA_STORE.RJControls.TextBoxStyle.MatteLine;
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPass.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.lblForgotPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.lblForgotPass.LinkLabel = true;
            this.lblForgotPass.Location = new System.Drawing.Point(143, 319);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(125, 16);
            this.lblForgotPass.Style = UTESA_STORE.RJControls.LabelStyle.Normal;
            this.lblForgotPass.TabIndex = 5;
            this.lblForgotPass.Text = "Forgot Password?";
            // 
            // dragControl2
            // 
            this.dragControl2.DragControl = this.icoBanner;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMessage.Location = new System.Drawing.Point(72, 231);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 16);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Message";
            this.lblMessage.Visible = false;
            // 
            // rjBarIcon2
            // 
            this.rjBarIcon2.BackColor = System.Drawing.Color.Transparent;
            this.rjBarIcon2.BackIcon = true;
            this.rjBarIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjBarIcon2.Customizable = false;
            this.rjBarIcon2.DropdownMenu = null;
            this.rjBarIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjBarIcon2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.rjBarIcon2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjBarIcon2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjBarIcon2.IconSize = 25;
            this.rjBarIcon2.Location = new System.Drawing.Point(35, 183);
            this.rjBarIcon2.Name = "rjBarIcon2";
            this.rjBarIcon2.Size = new System.Drawing.Size(25, 25);
            this.rjBarIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rjBarIcon2.TabIndex = 11;
            this.rjBarIcon2.TabStop = false;
            // 
            // rjBarIcon1
            // 
            this.rjBarIcon1.BackColor = System.Drawing.Color.Transparent;
            this.rjBarIcon1.BackIcon = true;
            this.rjBarIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjBarIcon1.Customizable = false;
            this.rjBarIcon1.DropdownMenu = null;
            this.rjBarIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjBarIcon1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.rjBarIcon1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjBarIcon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjBarIcon1.IconSize = 25;
            this.rjBarIcon1.Location = new System.Drawing.Point(35, 127);
            this.rjBarIcon1.Name = "rjBarIcon1";
            this.rjBarIcon1.Size = new System.Drawing.Size(25, 25);
            this.rjBarIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rjBarIcon1.TabIndex = 10;
            this.rjBarIcon1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.BorderSize = 1;
            this.btnLogin.Design = UTESA_STORE.RJControls.ButtonDesign.Normal;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 24;
            this.btnLogin.Location = new System.Drawing.Point(75, 263);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(254, 40);
            this.btnLogin.Style = UTESA_STORE.RJControls.ControlStyle.Glass;
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // icoBanner
            // 
            this.icoBanner.BackgroundImage = global::UTESA_STORE.Properties.Resources.pencil;
            this.icoBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icoBanner.Controls.Add(this.rjBarIcon2);
            this.icoBanner.Controls.Add(this.txtUser);
            this.icoBanner.Controls.Add(this.rjBarIcon1);
            this.icoBanner.Controls.Add(this.lblCaption);
            this.icoBanner.Controls.Add(this.lblMessage);
            this.icoBanner.Controls.Add(this.txtPassword);
            this.icoBanner.Controls.Add(this.btnLogin);
            this.icoBanner.Controls.Add(this.lblForgotPass);
            this.icoBanner.Customizable = false;
            this.icoBanner.Dock = System.Windows.Forms.DockStyle.Left;
            this.icoBanner.Image = global::UTESA_STORE.Properties.Resources.pencil;
            this.icoBanner.ImageMode = System.Windows.Forms.ImageLayout.Stretch;
            this.icoBanner.Location = new System.Drawing.Point(0, 0);
            this.icoBanner.Name = "icoBanner";
            this.icoBanner.Opacity = 80;
            this.icoBanner.OverlayColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.icoBanner.Size = new System.Drawing.Size(381, 470);
            this.icoBanner.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 470);
            this.Controls.Add(this.icoBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.rjBarIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjBarIcon1)).EndInit();
            this.icoBanner.ResumeLayout(false);
            this.icoBanner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RJControls.CTDragControl dragControl1;
        private RJControls.CTTextBox txtPassword;
        private RJControls.CTTextBox txtUser;
        private RJControls.CTLabel lblCaption;
        private RJControls.CTButton btnLogin;
        private RJControls.CTLabel lblForgotPass;
        private RJControls.CTDragControl dragControl2;
        private System.Windows.Forms.Label lblMessage;
        private RJControls.CTMenuIcon rjBarIcon2;
        private RJControls.CTMenuIcon rjBarIcon1;
        private RJControls.CTImageColorOverlay icoBanner;
    }
}