using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem
{
    [ServiceContract]
    public interface ICourierService
    {
        [OperationContract]
        int placerequest(int sender_id, string sender_address, string src_city, string receiver_name, string receiver_address, string receiver_mobile, string dest_city);

        [OperationContract]
        string cancelrequest(int courier_id);
    }
}
