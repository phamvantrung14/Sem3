using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TestConsumerAs2.CommentsServiceReference;

namespace TestConsumerAs2.Models
{
    public class CommentClient
    {
        CommentServiceClient client = new CommentServiceClient();
        public List<Comment> GetCommentByBlog(int id)
        {
            var list = client.GetCommentByBlogList(id);
            var cm = new List<Comment>();
            list.ForEach(a => cm.Add(new Comment()
            {
                ID = a.ID,
                BlogID = a.BlogID,
                Content = a.Content,
                Created = a.Created,
                CustomerID = a.CustomerID,
                Rate = a.Rate,
                ParentId = a.ParentId
            }));
            return cm;
        }
        public List<Comment> GetCommentPrentId(int id)
        {
            var list = client.GetCommentParentByBlogList(id);
            var cm = new List<Comment>();
            list.ForEach(a => cm.Add(new Comment()
            {
                ID = a.ID,
                BlogID = a.BlogID,
                Content = a.Content,
                Created = a.Created,
                CustomerID = a.CustomerID,
                Rate = a.Rate,
                ParentId = a.ParentId
            }));
            return cm;
        }
        public void StoreComment(Comment cmNew,string email,string pwd,int id)
        {
            var cm = new CommentsServiceReference.Comments()
            {
                BlogID = cmNew.BlogID,
                Content = cmNew.Content,
                Created = cmNew.Created,
                CustomerID = cmNew.CustomerID,
                ID = cmNew.ID,
                ParentId = cmNew.ParentId,
                Rate = cmNew.Rate,
            };
            client.AddCommentByBlogList(cm,email,pwd,id);
        }


    }
}