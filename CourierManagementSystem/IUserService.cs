using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CourierManagementSystem
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        string register(string user_name, string email, string password, string mobile_no);

        [OperationContract]
        string login(string email,  string password);
    }
}
