using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTESA_STORE.Models;
using PRD = UTESA_STORE.Api.Product; 

namespace UTESA_STORE.TestAndDemo
{

    
    public partial class FormProducts : RJForms.ChildForm
    {
        Api.Product PrdApi = new PRD();
        DataTable _DataTable = new DataTable();
        DataSet _DataSet = new DataSet(); 
        public FormProducts()
        {
            InitializeComponent();
           
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frmProduct = new FormProductMaintenance();
            var result = frmProduct.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadContent();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id =(int) ProductList.CurrentRow.Cells[0].Value;
            var product = PrdApi.ProductList.FirstOrDefault(t=>t.Id==id);
           
            var frmProduct = new FormProductMaintenance(product);
            var result = frmProduct.ShowDialog();

            if (result == DialogResult.OK) {
                LoadContent(); 
            }
        }

        private void  LoadContent() {
           List<Models.Product> Products =  PrdApi.Get();
            resetData(); 
            foreach (Models.Product Prd in Products)
                _DataTable.Rows.Add(Prd.Id,Prd.Item,Prd.UnitPrice,Prd.Stock );
            
            _DataSet.Tables.Add(_DataTable);
            ProductList.DataSource = _DataSet;
            ProductList.DataMember = _DataTable.TableName;
        }
        private void resetData() {
            _DataSet.Tables.Clear();
            _DataTable.Rows.Clear(); 
        }
        private void FormProducts_Load(object sender, EventArgs e)
        {

            configureProductList(); 


            if (PrdApi.ProductList.Count<=0) 
            LoadContent(); 
        }
        private void configureProductList()
        {
            _DataTable.Columns.Add("Id", typeof(int));
            _DataTable.Columns.Add("Nombre", typeof(string));
            _DataTable.Columns.Add("Precio", typeof(string));
            _DataTable.Columns.Add("Cantidad", typeof(string));
          
        }

        private void filter(string filterTerm) 
        {
    
            DataView _DataView = _DataSet.Tables[0].DefaultView;
            _DataView.RowFilter = string.Format("{1} LIKE '%{0}%'", SearchBox.Text, filterTerm);
            ProductList.DataSource = _DataView;
        }

        private void SearchBox_onTextChanged(object sender, EventArgs e)
        {
           
            filter("Nombre");
        }
    }
}
