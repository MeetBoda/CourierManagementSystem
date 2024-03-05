using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem
{
    [ServiceContract]
    public interface IProfileService
    {
        [OperationContract]
        Profile getData(int user_id);
    }

    [DataContract]
    public class Profile
    {
        [DataMember]
        public int user_id { get; set; }
        [DataMember]
        public string user_name { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string mobile { get; set; }
        [DataMember]
        public List<History> history { get; set; }
    }

    [DataContract]
    public class History
    {
        [DataMember]
        public int courier_id { get; set; }
        [DataMember]
        public string sender_address { get; set; }
        [DataMember]
        public string src_city { get; set; }
        [DataMember]
        public string receiver_name { get; set; }
        [DataMember]
        public string receiver_address { get; set; }
        [DataMember]
        public string dest_city { get; set; }
        [DataMember]
        public string receiver_mobile { get; set; }
        [DataMember]
        public DateTime date_of_order { get; set; }
        [DataMember]
        public string status { get; set; }
    }
}
