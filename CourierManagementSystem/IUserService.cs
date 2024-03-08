using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace CourierManagementSystem
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        string register(string user_name, string email, string password, string mobile_no);

        [OperationContract]
        UserInfo login(string email, string password);
    }

    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public string UserID { get; set; }

        [DataMember]
        public string message { get; set; }
    }
}
