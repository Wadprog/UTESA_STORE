﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTESA_STORE.Settings;
using System.Diagnostics;

namespace UTESA_STORE
{
    public partial class LoginForm : RJForms.BaseForm
    {        

      

        public LoginForm()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            AddControlBox();
            ApplyAppearanceSettings();

            //Add line
            var line = new Control();
            //line.Size = new Size(lblDescription.Width - 10, 1);
            line.BackColor = Color.LightGray;
           // line.Location = new Point(lblDescription.Left + 5, lblTitle.Bottom + 15);
            icoBanner.Controls.Add(line);
        }
  

   

        private void AddControlBox()
        {//Add control buttons (Maximize, close and minimize)
		
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.btnClose.Height = 20;
            this.btnClose.Location = new Point(this.Width - btnClose.Width, 0);

            this.btnMinimize.Height = 20;
            this.btnMinimize.Location = new Point(this.btnClose.Location.X - btnMinimize.Width, 0);
        }
        private void ApplyAppearanceSettings()
        {// Apply the appearance properties of the configuration.

             this.PrimaryForm = true; // Set as primary form.
             this.Resizable = false; // Set that the form cannot be resized from the border.
             this.BorderSize = 0; // Remove the border.
             this.BackColor = UIAppearance.BackgroundColor; // Set the back color.

            if (UIAppearance.Theme == UITheme.Light)//if the theme is LIGHT, set the maximize, minimize and close buttons to black.
            {
                this.btnClose.Image = Properties.Resources.CloseDark;
                this.btnMaximize.Image = Properties.Resources.MaximizeDark;
                this.btnMinimize.Image = Properties.Resources.MinimizeDark;
            }

        }
        private void Login()
        {
            var user = new Models.User().Login(txtUser.Text, txtPassword.Text);

            if (user != null)
            {
                var mainForm = new MainForm(user);               
                mainForm.Show();
                this.Hide();

                //Redisplay the login form and clear fields if the main form is closed
                mainForm.FormClosed += new FormClosedEventHandler(MainForm_Logout);
            }
            else
            {
                lblMessage.Text = "*Incorrect username or password";
                lblMessage.Visible = true;
            }
        }
        private void Logout()
        {
            txtPassword.Clear();
            txtUser.Clear();           
            lblMessage.Visible = false;
            lblCaption.Select();            
            this.Show();
        }
       

        protected override void CloseWindow()
        {//Override the method (To remove the message box if you want to exit the app) and simply exit the application, This is optional.
            Application.Exit();
        }
      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                lblMessage.Text = "*Please enter your username";
                lblMessage.Visible = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblMessage.Text = "*Please enter your password";
                lblMessage.Visible = true;
                return;
            }

            Login();

        }
        private void MainForm_Logout(object sender, FormClosedEventArgs e)
        {
            Logout();
        }
        private void biYoutube_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtube.com/rjcodeadvanceen");
        }
        private void biWebPage_Click(object sender, EventArgs e)
        {
            Process.Start("https://rjcodeadvance.com/");
        }
        private void biGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/rjcodeadvance");
        }
        private void biFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/RJCodeAdvance");
        }
     

    }
}
