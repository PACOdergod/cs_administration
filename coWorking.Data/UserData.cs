
using coWorking.Models;
using System.Linq;
using System;
using coWorking.Data.Tools;

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
                UserId = Guid.NewGuid(),
                Password = EncryptData.EncryptText("4adm¡n")
            };

            userCOllection.Add(AdminUser);
            jsonManager.SaveCollection(userCOllection);
            return true;
        }
    }
}