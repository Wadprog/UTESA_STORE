using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace UTESA_STORE.Api
{
   public class Product
    {

        String BaseUrl = "https://localhost:44395/api/product";
        HttpClient client = new HttpClient();
        Fetch Getter = new Fetch();
        public List<Models.Product> ProductList = new List<Models.Product>(); 

        public  List<Models.Product> Get() {
            string response = Getter.Get(BaseUrl);
            List<Models.Product> products = JsonConvert.DeserializeObject<List<Models.Product>>(response);
            ProductList = products; 
            return products; 

        }

        public async Task<Models.Product> Post(Models.Product Product ) {

            var data = JsonConvert.SerializeObject(Product);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(BaseUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Models.Product product = JsonConvert.DeserializeObject<Models.Product>(result);
                return product; 
            }
            throw new Exception("Error guardar nuevo producto"); 
        }

        public async Task<Models.Product> Put(Models.Product Product) {

            var data = JsonConvert.SerializeObject(Product);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");

            var response = await client.PutAsync(BaseUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Models.Product product = JsonConvert.DeserializeObject<Models.Product>(result);
                return product;
            }
            throw new Exception("Error guardar nuevo producto");
        }
    }
}
