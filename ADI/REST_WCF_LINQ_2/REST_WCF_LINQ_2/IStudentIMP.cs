using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace REST_WCF_LINQ_2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentIMP" in both code and config file together.
    [ServiceContract]
    public interface IStudentIMP
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/GetStudentList")]
        List<Student> GetStudents();

        [OperationContract]
        [WebInvoke(Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/CreateStudent")]
        bool AddStudents(Student st);

        [OperationContract]
        [WebInvoke(Method = "PUT",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "api/v1/UpdateStudent")]
        bool UpdateStudents(Student st);

        [OperationContract]
        [WebInvoke(Method = "DELETE",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "api/v1/DeleteStudent")]
        bool DeleteStudents(int id);

        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "api/v1/GetStudentById")]
        Student GetStudentById(int id);
    }
}
