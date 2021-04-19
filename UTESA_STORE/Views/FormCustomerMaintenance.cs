using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTESA_STORE.Models;

public enum ConstructorUsed { Empty, WithVar };
namespace UTESA_STORE.TestAndDemo
{
    public partial class FormCustomerMaintenance : RJForms.ChildForm
    {
        Api.Customer CustomerApi = new Api.Customer();
        ConstructorUsed ConstructorUsed { get; set; }
        public FormCustomerMaintenance()
        {
            InitializeComponent();
            lblTitle.Text = "Add new customer";
            btnSave.Text = "Add";
            btnSave.BackColor = Settings.Colors.Confirm;
            ConstructorUsed = ConstructorUsed.Empty;
        }

        public FormCustomerMaintenance(Customer customer)
        {
            InitializeComponent();
            ConstructorUsed = ConstructorUsed.WithVar;
            lblTitle.Select();//Not focus on text boxes when starting the form.
            lblTitle.Text = "Modificar Cliente";
            btnSave.Text = "Guadar";
            btnSave.BackColor = Settings.UIAppearance.StyleColor;

            txtNames.Text = customer.Names;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.PhoneNumber;
            txtAddress.Text = customer.StreetAddres;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Models.Customer NewCustomer = new Models.Customer();
            NewCustomer.Email = txtEmail.Text;
            NewCustomer.StreetAddres = txtAddress.Text;
            NewCustomer.Names = txtNames.Text;
            NewCustomer.PhoneNumber = txtPhone.Text;
            if (ConstructorUsed == ConstructorUsed.WithVar)
                await CustomerApi.Put(NewCustomer);
            else
                await CustomerApi.Post(NewCustomer);
            this.DialogResult = DialogResult.OK;


        }
    }
}
