using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestConsumerAs2.TypeBlogServiceReference;

namespace TestConsumerAs2.Models
{
    public class TypeBlogClient
    {
        TypeBlogServiceClient client = new TypeBlogServiceClient();

        public TypeBlog GetTypeBlogById1(int id)
        {
            var data = client.GetTypeBlogById(id);
            TypeBlog tpb = new TypeBlog();
            tpb.ID = data.ID;
            tpb.TypeName = data.TypeName;
            tpb.Descriptions = data.Descriptions;
            tpb.Status = data.Status;
            return tpb;
        }
        public List<TypeBlog> GetAllTypeBlog()
        {
            var list = client.GetTypeBlogList();
            var tp = new List<TypeBlog>();
            list.ForEach(t => tp.Add(new TypeBlog
            {
                ID = t.ID,
                TypeName = t.TypeName,
                Descriptions = t.Descriptions,
                Status = t.Status,

            }));
            return tp;
            
        }

    }
}