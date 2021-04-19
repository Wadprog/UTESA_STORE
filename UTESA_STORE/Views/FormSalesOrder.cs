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

namespace UTESA_STORE.TestAndDemo
{
    public partial class FormSalesOrder : RJForms.ChildForm
    {
      

        int rows = 8;
        int starIndex = 0;
        bool isDragging = false;
        List<SalesOrder> salesList = new List<SalesOrder>();
        Api.Sale salesOrder = new Api.Sale();

        DataSet _DataSet = new DataSet();
        DataTable _DataTable = new DataTable();


        public FormSalesOrder()
        {
            InitializeComponent();
            cbPeriod.SelectedIndex = 5;
            rjComboBox2.Text = "All";
        }
        

        private void LoadPageDatagridView()
        {
        }

        private void resetData()
        {
            _DataSet.Tables.Clear();
            _DataTable.Rows.Clear();
        }
        private void LoadData()
        {

            List<Models.SalesOrder> SalesOrders = salesOrder.Get();
            resetData();
            foreach (Models.SalesOrder Order in SalesOrders)
                _DataTable.Rows.Add(Order.Customer, Order.Product,Order.Price,Order.Amount,Order.Seller,Order.Purchase_Date);

            _DataSet.Tables.Add(_DataTable);
            OrdersList.DataSource = _DataSet;
            OrdersList.DataMember = _DataTable.TableName;

        }

        private void configureSaleList() {

        _DataTable.Columns.Add("Nombre", typeof(string));
            _DataTable.Columns.Add("Producto", typeof(string));
            _DataTable.Columns.Add("Precio", typeof(string));
            _DataTable.Columns.Add("Cantidad", typeof(string));
            _DataTable.Columns.Add("Vendedor", typeof(string));
            _DataTable.Columns.Add("Fecha", typeof(DateTime));
        }
        private void FormSalesOrder_Load(object sender, EventArgs e)
        {

            configureSaleList();
            if (salesOrder.OrdersList.Count <= 0)
                LoadData();
           
        }
  
        private void FormSalesOrder_Move(object sender, EventArgs e)
        {
            isDragging = true;
        }
        private void FormSalesOrder_ResizeEnd(object sender, EventArgs e)
        {
            if (isDragging == false)
            {
                rows = OrdersList.Height / OrdersList.Rows[0].Height - 1;
                LoadPageDatagridView();
            }
            isDragging = false;
        }

        private void FormSalesOrder_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                rows = OrdersList.Height / OrdersList.Rows[0].Height - 1;
                LoadPageDatagridView();
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            var form = new Views.FormSalesMaintenace();
            var res= form.ShowDialog();

            if (res == DialogResult.OK) { LoadData(); }
        }
    }
}
