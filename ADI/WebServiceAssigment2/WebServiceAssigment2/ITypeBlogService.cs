using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebServiceAssigment2.Models.DataModels;

namespace WebServiceAssigment2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITypeBlogService" in both code and config file together.
    [ServiceContract]
    public interface ITypeBlogService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "api/t1/TypeBlogs")]
        IEnumerable<TypeBlog> GetTypeBlogList();

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "api/t1/AddTypeBlog")]
        void AddTypeBlog(TypeBlog typeBlog);

        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "api/t1/TypeBlog/{id}")]
        TypeBlog GetTypeBlogById(int id);

        [OperationContract]
        [WebInvoke(Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "api/t1/UpdateTypeBlog/{id}")]
        void UpdateTypeBlog(TypeBlog typeBlog);
    }
}
