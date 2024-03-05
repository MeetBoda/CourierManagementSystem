using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem
{
   
    public class ProfileService : IProfileService
    {
        public ProfileService() { }

        public Profile getData(int user_id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            string query = "SELECT * FROM [User] WHERE user_id = (@user_id)";
            Profile profile = new Profile();
            try
            {
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        cmd.Connection = con;
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int uid = reader.GetInt32(0);
                            string user_name = reader.GetString(1);
                            string email = reader.GetString(2);
                            string mobile = reader.GetString(4);   
                            profile.user_id = uid;
                            profile.user_name = user_name;
                            profile.email = email;
                            profile.mobile = mobile;
                            List<History> hlist = new List<History>();
                            reader.Close();
                            query = "SELECT * FROM [Courier] WHERE sender_id = (@sender_id)";
                            try
                            {
                                using(SqlCommand cmd2 = new SqlCommand(query))
                                {
                                    cmd2.Parameters.AddWithValue("@sender_id", user_id);
                                    cmd2.Connection = con;
                                    //con.Open();
                                    reader = cmd2.ExecuteReader();
                                    while (reader.Read())
                                    {
                                        int cid = reader.GetInt32(0);
                                        string sdr_address = reader.GetString(2);
                                        string source_city = reader.GetString(3);
                                        string rec_name = reader.GetString(4);
                                        string rec_address  = reader.GetString(5);
                                        string rec_mobile = reader.GetString(6);
                                        string dst_city = reader.GetString(7);
                                        DateTime dateTime = reader.GetDateTime(8);
                                        string sts = reader.GetString(9);

                                        History h = new History();
                                        h.courier_id = cid;
                                        h.sender_address = sdr_address;
                                        h.src_city = source_city;
                                        h.receiver_name = rec_name;
                                        h.receiver_address = rec_address;
                                        h.receiver_mobile = rec_mobile;
                                        h.date_of_order = dateTime;
                                        h.dest_city = dst_city;
                                        h.status = sts;

                                        hlist.Add(h);
                                        Console.WriteLine(h);
                                    }
                                }
                                profile.history = hlist;
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return profile;
        }
    }

    
}
