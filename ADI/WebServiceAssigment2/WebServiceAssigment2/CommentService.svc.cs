using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebServiceAssigment2.Models.DataModels;

namespace WebServiceAssigment2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CommentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CommentService.svc or CommentService.svc.cs at the Solution Explorer and start debugging.
    public class CommentService : ICommentService
    {
        FRDbContext db;
        public CommentService()
        {
            db = new FRDbContext();
        }
        public void AddCommentByBlogList(Comments cm, string email, string pwd,int id)
        {
            var data = db.Customers.ToList();
            foreach(var item in data)
            {
                if(item.Email == email)
                {
                    if(item.Password == pwd)
                    {
                        cm.BlogID = id;
                        cm.CustomerID = item.ID;
                        db.Comments.Add(cm);
                        db.SaveChanges();
                    }
                }
            }
            
        }

        public IEnumerable<Comments> GetCommentByBlogList(int blogId)
        {
            var data = db.Comments.Where(x => x.BlogID == blogId).OrderByDescending(x => x.Created).AsEnumerable();
            return data;
        }

        public IEnumerable<Comments> GetCommentParentByBlogList(int blogId)
        {
            var data = db.Comments.Where(x => x.BlogID == blogId).OrderBy(x => x.Created).AsEnumerable();
            return data;
        }
    }
}
