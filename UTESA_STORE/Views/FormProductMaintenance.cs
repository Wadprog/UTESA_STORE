using System;
using System.Windows.Forms;
using UTESA_STORE.Models;

public enum UsedConstructor { Empty ,WithVar };
namespace UTESA_STORE.TestAndDemo
{
    public partial class FormProductMaintenance : RJForms.ChildForm
    {
        
        UsedConstructor UsedConstructor { set; get; }
        Api.Product ProdApi = new Api.Product(); 
        public FormProductMaintenance()
        {
            UsedConstructor = UsedConstructor.Empty; 
            InitializeComponent();
            lblTitle.Text = "Agregar Nuevo Producto";
            btnSave.Text = "Agregar";
            btnSave.BackColor = Settings.Colors.Confirm;
            txtID.Enabled = false; 
        }

        public FormProductMaintenance(Product product)
        {
            UsedConstructor = UsedConstructor.WithVar;
            InitializeComponent();
            lblTitle.Text = "Editar producto";
            btnSave.Text = "Guardar";
            btnSave.BackColor = Settings.UIAppearance.StyleColor; 
            txtID.Text = product.Id.ToString();
            txtProduct.Text = product.Item;
            txtStock.Text = product.Stock.ToString();
            txtUnitPrice.Text = product.UnitPrice.ToString();
            txtID.Enabled = false;//Block id field.
            lblTitle.Select();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            Models.Product NewProduct = new Models.Product();

            NewProduct.Item = txtProduct.Text;
            NewProduct.Stock = Convert.ToInt32(txtStock.Text);
            NewProduct.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);

            if (UsedConstructor == UsedConstructor.WithVar) {
                NewProduct.Id = Convert.ToInt32(txtID.Text);
                await ProdApi.Put(NewProduct); 
            }else
            {

                await ProdApi.Post(NewProduct);
            }
            this.DialogResult = DialogResult.OK;
            this.Dispose(); 
           
        }
    }
}
