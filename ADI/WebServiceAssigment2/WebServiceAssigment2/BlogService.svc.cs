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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BlogService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BlogService.svc or BlogService.svc.cs at the Solution Explorer and start debugging.
    public class BlogService : IBlogService
    {
        FRDbContext db;
        public BlogService()
        {
            db = new FRDbContext();
        }
        public void AddBlog(Blog b,string email,string pwd)
        {
            var data = db.Users.ToList();
            foreach(var item in data)
            {
                if(item.Email == email)
                {
                    if(item.Password == pwd)
                    {
                        b.UserID = item.ID;
                        db.Blogs.Add(b);
                        db.SaveChanges();
                    }
                }
            }
           
        }

        public void DeleteBlog(int id)
        {
            var data = db.Blogs.Where(x => x.ID == id).First();
            db.Blogs.Remove(data);
            db.SaveChanges();
        }

        public Blog GetBlogById(int id)
        {
          
            var data = db.Blogs.Where(x => x.ID == id).First();
            return data;
         
            
        }

        public IEnumerable<Blog> GetBlogByTypeId(int id)
        {           
            var data = db.Blogs.Where(x => x.TypeBlogID == id && x.Status==1).OrderByDescending(x => x.Created).AsEnumerable();
            return data;          
        }

        public IEnumerable<Blog> GetBlogList(string email, string pwd)
        {
            var dataUs = db.Users.ToList();
            foreach(var item in dataUs)
            {
                if(item.Email == email)
                {
                    if (item.Password == pwd)
                    {
                        var data = db.Blogs.OrderByDescending(x => x.Created).ToList();
                        return data;
                    }
                }
            }
            return null;
            
        }

        public List<Blog> GetBlogListConsumer()
        {
            var data = db.Blogs.Where(x => x.Status == 1).OrderByDescending(x => x.Created).ToList();
            return data;
        }

        public void UpdateBlog(Blog b)
        {
            db.Entry(b).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
