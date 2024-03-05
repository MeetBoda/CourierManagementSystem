using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem
{
    public class CourierClass : ICourierService
    {
        public CourierClass() { }

        public int placerequest(int sender_id, string sender_address, string src_city, string receiver_name, string receiver_address, string receiver_mobile, string dest_city)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            DateTime date_of_order = DateTime.Now;
            string query = "INSERT INTO [Courier] (sender_id, sender_address, src_city, receiver_name, receiver_address, receiver_mobile, dest_city, date_of_order) VALUES(@sender_id, @sender_address, @src_city, @receiver_name, @receiver_address, @receiver_mobile, @dest_city, @date_of_order); SELECT SCOPE_IDENTITY();";
            int courier_id = 0;
            try
            {
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@sender_id", sender_id);
                        cmd.Parameters.AddWithValue("@sender_address", sender_address);
                        cmd.Parameters.AddWithValue("@src_city", src_city);
                        cmd.Parameters.AddWithValue("@receiver_name", receiver_name);
                        cmd.Parameters.AddWithValue("@receiver_address", receiver_address);
                        cmd.Parameters.AddWithValue("@receiver_mobile", receiver_mobile);
                        cmd.Parameters.AddWithValue("@dest_city", dest_city);
                        cmd.Parameters.AddWithValue("@date_of_order", date_of_order);
                        cmd.Connection = con;
                        con.Open();
                        courier_id = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return courier_id;
        }

        public string cancelrequest(int courier_id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;

            string query = "DELETE FROM [Courier] WHERE courier_id = (@courier_id)";

            try
            {
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@courier_id", courier_id);
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
            return "Order Cancelled";
        }
    }
}
