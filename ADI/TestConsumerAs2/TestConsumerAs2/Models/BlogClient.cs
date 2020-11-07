using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestConsumerAs2.BlogServiceReference;

namespace TestConsumerAs2.Models
{
    public class BlogClient
    {
        BlogServiceClient client = new BlogServiceClient();
        public List<Blog> GetAllBlog()
        {
            var list = client.GetBlogListConsumer();
            var bl = new List<Blog>();
            list.ForEach(b => bl.Add(new Blog()
            {
                ID = b.ID,
                Content = b.Content,
                ContentShort = b.ContentShort,
                Created = b.Created,
                Place = b.Place,
                Status = b.Status,
                Image = b.Image,
                Title = b.Title,
                views = b.views,
                UserID = b.UserID,
                TypeBlogID = b.TypeBlogID
            }));
            return bl;
        }

        public List<Blog> GetListBlogByType(int id)
        {
            var list = client.GetBlogByTypeId(id);
            var bl = new List<Blog>();
            list.ForEach(b => bl.Add(new Blog()
            {
                ID = b.ID,
                Content = b.Content,
                ContentShort = b.ContentShort,
                Created = b.Created,
                Place = b.Place,
                Status = b.Status,
                Image = b.Image,
                Title = b.Title,
                views = b.views,
                UserID = b.UserID,
                TypeBlogID = b.TypeBlogID
            }));
            return bl;
        }

        public Blog GetBlogByID(int id)
        {
            var data = client.GetBlogById(id);
            Blog b = new Blog();

            b.ID = data.ID;
            b.Content = data.Content;
            b.ContentShort = data.ContentShort;
            b.Created = data.Created;
            b.Place = data.Place;
            b.Status = data.Status;
            b.Image = data.Image;
            b.Title = data.Title;
            b.views = data.views;
            b.UserID = data.UserID;
            b.TypeBlogID = data.TypeBlogID;

            return b;
            
        }

        public void UpdateBlog(Blog b)
        {
            var bl = new BlogServiceReference.Blog()
            {
                ID = b.ID,
                Content = b.Content,
                ContentShort = b.ContentShort,
                Created = b.Created,
                Place = b.Place,
                Status = b.Status,
                Title = b.Title,
                Image = b.Image,
                views = b.views,
                UserID = b.UserID,
                TypeBlogID = b.TypeBlogID
            };
            client.UpdateBlog(bl);
        }
        
    }
}