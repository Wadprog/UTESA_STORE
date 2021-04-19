using System;
using System.Windows.Forms;
using UTESA_STORE.Models;
using UTESA_STORE.TestAndDemo;

namespace UTESA_STORE
{
    public partial class MainForm : RJForms.MainForm
    {


        private User userConnected;
        public MainForm()
        {
            InitializeComponent();
            lblUserName.Text = "No login";
        }

        public MainForm(User user)
        {
            InitializeComponent();
            userConnected = user;
            lblUserName.Text = user.FirstName + " " + user.LastName;
            pbProfilePicture.Load(user.ProfilePicture); 
        }

        private void miMyProfile_Click(object sender, EventArgs e)
        {

        }
        private void miSettings_Click(object sender, EventArgs e)
        {
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormDashboard(), sender);
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormProducts(), sender);
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormCustomer(), sender);
        }


       
      
      
      
      
       
      
      




        private void miExit_Click(object sender, EventArgs e)
        {
            this.CloseWindow();
        }
        private void miLogout_Click(object sender, EventArgs e)
        {

        }
        private void miHelp_Click(object sender, EventArgs e)
        {

        }
        private void miTermsCond_Click(object sender, EventArgs e)
        {

        }


        private void rjLabel1_Click(object sender, EventArgs e)
        {

        }

        private void biUserOptions_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormUserProfile(userConnected));
        }

        private void BtnSaleNav_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormSalesOrder());
        }

        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
