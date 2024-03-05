using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Runtime.Remoting.Messaging;

namespace CourierManagementSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string register(string user_name, string email, string password, string mobile_no)
        {
            SqlConnection con = new SqlConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"]?.ConnectionString;
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            if (!string.IsNullOrEmpty(connectionString))
            {
                con.ConnectionString = connectionString;
            }
            string query = "INSERT INTO [User] (user_name, email, password, mobile_no) VALUES(@user_name, @email, @password, @mobile_no)";

            try
            {
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@user_name", user_name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@mobile_no", mobile_no);
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return "Working";
        }
    }
}
