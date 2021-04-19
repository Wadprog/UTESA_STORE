using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace UTESA_STORE.Api
{
    public class Sale
    {

        String BaseUrl = "https://localhost:44395/api/sale";
        HttpClient client = new HttpClient();
        Fetch Getter = new Fetch();
        public List<Models.SalesOrder> OrdersList = new List<Models.SalesOrder>();

        public List<Models.SalesOrder> Get()
        {
            string response = Getter.Get(BaseUrl);
            List<Models.SalesOrder> orders = JsonConvert.DeserializeObject<List<Models.SalesOrder>>(response);
            OrdersList = orders;
            return orders;

        }

        public async Task<Models.SalesOrder> Post(Models.SalesOrder Orders)
        {

            var data = JsonConvert.SerializeObject(Orders);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(BaseUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Models.SalesOrder Order = JsonConvert.DeserializeObject<Models.SalesOrder>(result);
                return Order;
            }
            throw new Exception("Error guardar nuevo producto");
        }

        public async Task<Models.SalesOrder> Put(Models.SalesOrder Order)
        {

            var data = JsonConvert.SerializeObject(Order);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");

            var response = await client.PutAsync(BaseUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Models.SalesOrder NOrder = JsonConvert.DeserializeObject<Models.SalesOrder>(result);
                return NOrder;
            }
            throw new Exception("Error guardar nuevo producto");
        }
    }
}
