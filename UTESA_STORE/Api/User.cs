using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UTESA_STORE.Api
{
    public class User
    {

        String BaseUrl = "https://localhost:44395/api/user";
        HttpClient client = new HttpClient();
        Fetch Getter = new Fetch();
        public List<Models.User> UsersList = new List<Models.User>();

        public List<Models.User> Get()
        {
            string response = Getter.Get(BaseUrl);
            List<Models.User> Users = JsonConvert.DeserializeObject<List<Models.User>>(response);
            UsersList = Users;
            return UsersList;

        }

        public async Task<Models.User> Post(Models.User NewUser)
        {

            var data = JsonConvert.SerializeObject(NewUser);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(BaseUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Models.User Nuser = JsonConvert.DeserializeObject<Models.User>(result);
                return Nuser;
            }
            throw new Exception("Error guardar nuevo Usuario");
        }

        public async Task<Models.User> Put(Models.User NewUser)
        {

            var data = JsonConvert.SerializeObject(NewUser);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");

            var response = await client.PutAsync(BaseUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Models.User ctx = JsonConvert.DeserializeObject<Models.User>(result);
                return ctx;
            }
            throw new Exception("Error Modifica nuevo Usuario");
        }
    }
}
