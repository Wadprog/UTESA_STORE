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

using CTX =UTESA_STORE.Api.Customer;
namespace UTESA_STORE.TestAndDemo
{
    public partial class FormCustomer : RJForms.ChildForm
    {

       CTX CustomerApi = new CTX();
       DataSet _DataSet = new DataSet();
       DataTable _DataTable = new DataTable();
        public FormCustomer()
        {
            InitializeComponent();
          //  CustomersList.DataSource = new Customer().GetCustomerList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmCustomer = new FormCustomerMaintenance();
           DialogResult res= frmCustomer.ShowDialog();
            if (res == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var email = CustomersList.CurrentRow.Cells[2].Value.ToString();
            var customer = CustomerApi.CustomersList.FirstOrDefault(t => t.Email == email);
            var frmCustomer = new FormCustomerMaintenance(customer);
            DialogResult res = frmCustomer.ShowDialog();

            if (res == DialogResult.OK)
             LoadData();
            
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            configureCustomerList();
            if (CustomerApi.CustomersList.Count <= 0)
                LoadData(); 
        }
        private void configureCustomerList()
        {
            _DataTable.Columns.Add("Nombre", typeof(string));
            _DataTable.Columns.Add("Telefono", typeof(string));
            _DataTable.Columns.Add("Correo", typeof(string));
            _DataTable.Columns.Add("Dirreccion", typeof(string));
            SearchCategory.Items.Add("Nombre");
            SearchCategory.Items.Add("Telefono");
            SearchCategory.Items.Add("Correo");
            SearchCategory.Items.Add("Dirreccion");
        }
        private void resetData()
        {
            _DataSet.Tables.Clear();
            _DataTable.Rows.Clear();
        }
        private void LoadData() {

            List<Models.Customer> Customers= CustomerApi.Get();

            resetData();
            foreach (Models.Customer CTX in Customers)
                _DataTable.Rows.Add(CTX.Names, CTX.PhoneNumber, CTX.Email, CTX.StreetAddres);

            _DataSet.Tables.Add(_DataTable);
            CustomersList.DataSource = _DataSet;
            CustomersList.DataMember = _DataTable.TableName;

        }

        private void SearchBox_onTextChanged(object sender, EventArgs e)
        {
            Filter(SearchCategory.Text, SearchBox.Text); 
        }

        private void Filter(string Category, string Term) {
           
            DataView _DataView = _DataSet.Tables[0].DefaultView;
            _DataView.RowFilter = string.Format("{1} LIKE '%{0}%'", Term, Category);
            CustomersList.DataSource = _DataView;
        }
    }
}
