using System;
using System.Data.SqlClient;
using System.Configuration;

namespace CourierManagementSystem
{
    public class UserService : IUserService
    {
        public string register(string user_name, string email, string password, string mobile_no)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            string query = "SELECT user_id, password FROM [User] WHERE email= (@email)"; 

            try
            {
                using (con)
                {
                    using(SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Connection = con;
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (!reader.HasRows)
                        {
                            reader.Close();
                            query = "INSERT INTO [User] (user_name, email, password, mobile_no) VALUES(@user_name, @email, @password, @mobile_no)";
                            using (SqlCommand cmd1 = new SqlCommand(query))
                            {
                                cmd1.Parameters.AddWithValue("@user_name", user_name);
                                cmd1.Parameters.AddWithValue("@email", email);
                                cmd1.Parameters.AddWithValue("@password", password);
                                cmd1.Parameters.AddWithValue("@mobile_no", mobile_no);
                                cmd1.Connection = con;
                                cmd1.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        else
                        {
                            return "User already exist";
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return "User Registered Successfully";
        }

        public string login(string email, string password)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            string query = "SELECT user_id, password FROM [User] WHERE email= (@email)";
            try
            {
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Connection = con;
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int uid = reader.GetInt32(0);
                                string pass = reader.GetString(1);

                                if (pass == password)
                                {
                                   // Session["uid"] = uid;
                                    //Response.Redirect("Home_Teacher.aspx");
                                }
                                else
                                {
                                    return "Incorrect Password";
                                    //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Password is incorrect.');", true);
                                }
                            }
                        }
                        else
                        {
                            return "Invalid User";
                            //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Teacher ID is not Registered. Please SignUp First');", true);
                            //Response.Redirect("Signup_Teacher.aspx");
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return "Login Successful";
        }
    }
}
