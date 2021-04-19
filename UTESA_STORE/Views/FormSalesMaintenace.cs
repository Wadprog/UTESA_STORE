using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTESA_STORE.Views
{
  
    public partial class FormSalesMaintenace : RJForms.ChildForm
    {
        Api.Sale OrderApi = new Api.Sale();

        Models.User User = new Models.User(); 
        public FormSalesMaintenace()
        {
            InitializeComponent();
        }

        private void ctLabel1_Click(object sender, EventArgs e)
        {

        }

        //private Models.Product ProductDetails(string ProductName) { }
        //private Models.Customer CustomerDetails(string customerName) {
        
       // }

        private async void Btn_save_Click(object sender, EventArgs e)
        {

            Models.SalesOrder Order = new Models.SalesOrder();
           // Models.Product  product = ProductDetails(CbProd.Text);
          //  Models.Customer ctx = CustomerDetails(CbClient.Text);


            //Order.CustomerId = ctx.Id; 
            // Order.ProductId = product.Id; 
            //Order.Price= product.UnitPrice;
            // Order.Amount =product.Stock;
            // Order.SellerId = User.Id;
            //Order.Purchase_Date = new DateTime(); 


            Order.CustomerId = 1;
             Order.ProductId = 1; 
            Order.Price= 12.4;
             Order.Amount =3;
             Order.SellerId = 1;
            Order.Purchase_Date = new DateTime(); 
            await OrderApi.Post(Order); 
        }
    }
}
