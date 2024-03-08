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
    public interface IAdminService
    {

        [OperationContract]
        List<AdminData> getData();

        [OperationContract]
        void assigndeliveryperson(int courier_id, int employee_id);

        [OperationContract]
        void changestatus(int courier_id, string new_status);

        [OperationContract]
        List<int> getEmployeeList();

    }

    [DataContract]
    public class AdminData
    {
        [DataMember]
        public int courier_id { get; set; }

        [DataMember]
        public int sender_id { get; set; }

        [DataMember]
        public string receiver_name { get; set; }

        [DataMember]
        public string receiver_address { get; set; }

        [DataMember]
        public string dest_city { get; set; }

        [DataMember]
        public int? employee_id { get; set; }

        [DataMember]
        public string status { get; set; }
    }

    [DataContract]
    public class EmployeeList
    {
        [DataMember]
        public List<int> empList { get; set; }
    }
}
