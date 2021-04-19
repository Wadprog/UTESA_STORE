using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UTESA_STORE.Api
{
    public class Customer
    {

        String BaseUrl = "https://localhost:44395/api/customer";
        HttpClient client = new HttpClient();
        Fetch Getter = new Fetch();
        public List<Models.Customer> CustomersList = new List<Models.Customer>();

        public List<Models.Customer> Get()
        {
            string response = Getter.Get(BaseUrl);
            List<Models.Customer> Customers = JsonConvert.DeserializeObject<List<Models.Customer>>(response);
            CustomersList = Customers;
            return Customers;

        }

        public async Task<Models.Customer> Post(Models.Customer NewCustomer)
        {

            var data = JsonConvert.SerializeObject(NewCustomer);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(BaseUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Models.Customer NCustomer = JsonConvert.DeserializeObject<Models.Customer>(result);
                return NCustomer;
            }
            throw new Exception("Error guardar nuevo Cliente");
        }

        public async Task<Models.Customer> Put(Models.Customer NewCustomer)
        {

            var data = JsonConvert.SerializeObject(NewCustomer);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");

            var response = await client.PutAsync(BaseUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Models.Customer ctx = JsonConvert.DeserializeObject<Models.Customer>(result);
                return ctx;
            }
            throw new Exception("Error Modifica nuevo client");
        }
    }
}
