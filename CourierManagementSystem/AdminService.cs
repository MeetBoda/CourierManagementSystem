using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CourierManagementSystem
{
    public class AdminService : IAdminService
    {
        public AdminService() { 
            
           
        }

        public void assigndeliveryperson(int courier_id, int employee_id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            string query = "UPDATE [Courier] SET delivery_person_id = (@delivery_person_id) WHERE courier_id = (@courier_id)";
            try
            {
                using(SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@delivery_person_id", employee_id);
                    cmd.Parameters.AddWithValue("@courier_id", courier_id);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }

        public void changestatus(int courier_id, string new_status)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            string query = "UPDATE [Courier] SET status = (@status) WHERE courier_id = (@courier_id)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@status", new_status);
                    cmd.Parameters.AddWithValue("@courier_id", courier_id);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<AdminData> getData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            string query = "SELECT * FROM [Courier] WHERE status <> (@status)";
            List<AdminData> datalist = new List<AdminData>();
            try
            {
                using(SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@status", "Delivered");
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        AdminData d = new AdminData();
                        d.courier_id = reader.GetInt32(0);
                        d.sender_id = reader.GetInt32(1);
                        d.receiver_name = reader.GetString(4);
                        d.receiver_address = reader.GetString(5);
                        d.dest_city = reader.GetString(7);
                        d.status = reader.GetString(9);
                        if(reader.IsDBNull(10))
                        {
                            d.employee_id = 0;
                        }
                        else
                        {
                           d.employee_id = reader.GetInt32(10);
                        }
                        datalist.Add(d);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return datalist;
        }

        public List<int> getEmployeeList()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            string query = "SELECT employee_id FROM [Employee]";
            List<int> emplist = new List<int>();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int employee_id = reader.GetInt32(0);
                        emplist.Add(employee_id);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return emplist;
        }
    }
}
