using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Project1.Models;

namespace Project1.BusinessLogic_bl
{
    public class MainLogic
    {
        public static bool Insertdata(MainModel obj)
        {
            bool res = false;
            var dbconfig = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                try
                {
                    con.Open();


                    SqlCommand cmd = new SqlCommand("SP_INSERT_TBL_ADMIN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userid", obj.userid);
                    cmd.Parameters.AddWithValue("@FirstName", obj.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", obj.LastName);
                    cmd.Parameters.AddWithValue("@EmailID", obj.EmailID);
                    cmd.Parameters.AddWithValue("@Password", obj.Password);
                    cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                    
                    cmd.Parameters.AddWithValue("@Dob", Convert.ToDateTime(obj.Dob));
                    cmd.Parameters.AddWithValue("@Role", obj.Role);

                    cmd.Parameters.AddWithValue("@Status", obj.Status);
                    cmd.Parameters.AddWithValue("@InsertionDate", Convert.ToDateTime(obj.InsertionDate));

                    
         int x = cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        return res = true;
                    }
                    else
                    {
                        return res = false;
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    con.Close();
                }
                return res = true;
            }

        }
        public static DataTable login(AdminLogin obj)
        {
            var dbconfig = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                SqlCommand cmd = new SqlCommand("SP_Login_TBL_ADMIN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmailID", obj.EmailID);
                cmd.Parameters.AddWithValue("@Password", obj.Password);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
       
            public static bool DeleteData(int id)
            {
                bool res = false;
                var dbconfig = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json").Build();
                string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
                using (SqlConnection con = new SqlConnection(dbconnectionstr))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_delete_UploadFile", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", id);
                        int x = cmd.ExecuteNonQuery();
                        if (x > 0)
                        {
                            return res = true;
                        }
                        else
                        {
                            return res = false;
                        }
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        con.Close();
                    }
                    return res = true;
                }
            }
        }
        
}
