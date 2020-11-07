using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestConsumerAs2.UserServiceReference;

namespace TestConsumerAs2.Models
{
    public class UserClient
    {
        UserServiceClient client = new UserServiceClient();
        public User GetUserById(int id)
        {
            var data = client.GetUserById(id);
            User u = new User();
            u.Email = data.Email;
            u.ID = data.ID;
            u.UserName = data.UserName;
            u.Password = data.Password;
            return u;
        }
        public List<User> getAllUser()
        {
            var list = client.GetUserList().ToList();
            var rt = new List<User>();
            list.ForEach(a => rt.Add(new User()
            {
                Email = a.Email,
                ID = a.ID,
                Created = a.Created,
                Password = a.Password,
                UserName = a.UserName,

            }));

            return rt;
        }
    }
}