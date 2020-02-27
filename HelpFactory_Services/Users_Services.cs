using HelpFactory.DataBase;
using HelpFactory_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFactory_Services
{
   public class USERS_Services
    {
        public User GetUser(int Id)
        {
            using (var context = new HelpFactory_Context())
            {
                return context.Users.Find(Id);
            }
        }

        public List<User> GetUsers()
        {
            using (var context = new HelpFactory_Context())
            {
                return context.Users.ToList();
            }
        }
        public void SaveUser(User user)
        {
            using (var context = new HelpFactory_Context())
            {
                context.Users.Add(user);
                context.SaveChanges();

            }
        }
        public void UpdateUser(User user)
        {
            using (var context = new HelpFactory_Context())
            {
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();

            }
        }
        public void DeleteUser(User user)
        {
            using (var context = new HelpFactory_Context())
            {
                context.Entry(user).State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

    }
}
