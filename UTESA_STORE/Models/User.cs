using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTESA_STORE.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePicture { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthdate { get; set; }

        Api.User UserApi = new Api.User(); 
        public User Login(string username, string pass)
        {

            List<Models.User> UsersList = UserApi.Get();
            var user = UsersList.Find(x => x.Username == username && x.Password == pass);
           return user;
        }

        

    }
}
