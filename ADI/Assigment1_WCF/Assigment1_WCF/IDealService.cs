using Assigment1_WCF.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assigment1_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDealService" in both code and config file together.
    [ServiceContract]
    public interface IDealService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "api/v1/Deals"
            )]
        IEnumerable<Deal> GetDealList();

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "api/v1/AddDeal")]
        string AddDeal(Deal deal,string accountNumber,int codePin);
        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "api/v1/ListDeals"
            )]
        List<Deal> GetDealListById(string accountNumber,int codePin);

    }
}
