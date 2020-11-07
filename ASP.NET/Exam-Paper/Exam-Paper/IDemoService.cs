using Exam_Paper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Exam_Paper
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDemoService" in both code and config file together.
    [ServiceContract]
    public interface IDemoService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "api/b1/BlogList")]
        IEnumerable<Contact> GetContactList();
    }
}
