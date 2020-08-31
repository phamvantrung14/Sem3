using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Nhom_01.Model
{
    public class NetWork
    {
        public async static Task<Root> GetNetwork()
        {

            var http = new HttpClient();
            var url = string.Format("http://api-demo-anhth.herokuapp.com/data.json");

            var response = await http.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();

            var serializer = new DataContractJsonSerializer(typeof(Root));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (Root)serializer.ReadObject(ms);
            return data;
        }

        [DataContract]
        public class Content
        {
            [DataMember]
            public string description { get; set; }
            [DataMember]
            public string url { get; set; }
        }

        [DataContract]
        public class Root
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string date { get; set; }
            [DataMember]
            public string title { get; set; }
            [DataMember]
            public string image { get; set; }
            [DataMember]
            public Content content { get; set; }
        }
    }
}
