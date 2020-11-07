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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TypeBlogService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TypeBlogService.svc or TypeBlogService.svc.cs at the Solution Explorer and start debugging.
    public class TypeBlogService : ITypeBlogService
    {
        FRDbContext db;
        public TypeBlogService()
        {
            db = new FRDbContext();
        }
        
        public void AddTypeBlog(TypeBlog typeBlog)
        {
            db.TypeBlogs.Add(typeBlog);
            db.SaveChanges();
        }

        public TypeBlog GetTypeBlogById(int id)
        {
            var data = db.TypeBlogs.Where(x => x.ID == id).First();
            return data;
        }

        public IEnumerable<TypeBlog> GetTypeBlogList()
        {
            var data = db.TypeBlogs.AsEnumerable();
            return data;
        }

        public void UpdateTypeBlog(TypeBlog typeBlog)
        {
            db.Entry(typeBlog).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
