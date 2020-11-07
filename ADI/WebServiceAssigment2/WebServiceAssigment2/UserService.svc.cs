using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebServiceAssigment2.Models.DataModels;

namespace WebServiceAssigment2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        FRDbContext db;
        public UserService()
        {
            db = new FRDbContext();
        }
        public void AddUser(User u)
        {
            db.Users.Add(u);
            db.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var data = db.Users.Find(id);
            db.Users.Remove(data);
            db.SaveChanges();
        }

        public User GetUserById(int id)
        {
            var data = db.Users.Where(x => x.ID == id).First();
            return data;
        }

        public User GetUserCheck(string email)
        {
            var data = db.Users.Where(x => x.Email == email ).First();
            return data;
        }

        public IEnumerable<User> GetUserList()
        {
            var data = db.Users.AsEnumerable();
            return data;
        }

        public void UpdateUser(User u)
        {
            db.Entry(u).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
