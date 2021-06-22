
using coWorking.Models;
using System.Linq;
using System;

namespace coWorking.Data
{
    public class UserData
    {
        private JsonManager<User> jsonManager;

        public UserData() {

            jsonManager = new JsonManager<User>();
        }

        public bool CreatedAdmin(){

            var userCOllection = jsonManager.GetCollection();

            if (userCOllection.Any( p => p.Name=="ADMIN" && p.Email=="ADMIN" ))
            {
                return true;
            }

            var AdminUser = new User()
            {
                Name = "ADMIN",
                LastName = "ADMIN",
                Email = "ADMIN",
                UserId = Guid.NewGuid()
            };
        }
    }
}