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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICommentService" in both code and config file together.
    [ServiceContract]
    public interface ICommentService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "api/m1/Comment/{id}")]
        IEnumerable<Comments> GetCommentByBlogList(int blogId);

        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "api/m1/CommentParent/{id}")]
        IEnumerable<Comments> GetCommentParentByBlogList(int blogId);

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "api/m1/AddComment")]
        void  AddCommentByBlogList(Comments cm,string email,string pwd,int id);
    }
}
