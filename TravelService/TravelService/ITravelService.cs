using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TravelService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITravelService" in both code and config file together.
    [ServiceContract]
    public interface ITravelService
    {
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
            UriTemplate = "api/v1/GetLocation"
          )] // định nghĩa đường link trả về
        List<Location> GetLocations();

        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
           UriTemplate = "api/v1/CreateLocation"
         )] // định nghĩa đường link trả về
        bool AddLocation(Location location);

        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "PUT",
           ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
           UriTemplate = "api/v1/EditLocation/{id}"
         )] // định nghĩa đường link trả về
        bool EditLocation(string id, Location location);

        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
           UriTemplate = "api/v1/DeleteLocation/{id}"
         )] // định nghĩa đường link trả về
        bool DeleteLocation(string id);
    }
}
