using Project1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Project1.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Xml.Linq;

namespace Project1.BusinessLogic_bl
{
    public class StudentADD
    {
        public static bool Insertdata(GenericInfo obj)
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


                    SqlCommand cmd = new SqlCommand("SP_INSERT_TBL_GenericInfo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HTDID", obj.HTDID);
                    cmd.Parameters.AddWithValue("@Sno", obj.Sno);
                    cmd.Parameters.AddWithValue("@HallTicket", obj.HallTicket);
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@EmailID", obj.EmailID);
                    cmd.Parameters.AddWithValue("@Dob", Convert.ToDateTime(obj.Dob));
                    cmd.Parameters.AddWithValue("@Gender", obj.Gender);

                    cmd.Parameters.AddWithValue("@StudentPHno", obj.StudentPHno);
                    cmd.Parameters.AddWithValue("@StudentAadhar", obj.StudentAadhar);

                   
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
        public static bool InsertSsc(Schooling obj)
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


                    SqlCommand cmd = new SqlCommand("SP_TBL_Schooling", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HTDID", obj.HTDID);
                    cmd.Parameters.AddWithValue("@SchoolName", obj.SchoolName);
                    cmd.Parameters.AddWithValue("@SscPassYear", Convert.ToDateTime(obj.SscPassYear));
                    cmd.Parameters.AddWithValue("@SscAggregate", obj.SscAggregate);
                    

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
        public static bool InsertIntermediate(Intermediate obj)
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


                    SqlCommand cmd = new SqlCommand("SP_TBL_Intermediate", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HTDID", obj.HTDID);
                    cmd.Parameters.AddWithValue("@CollegeName", obj.CollegeName);
                    cmd.Parameters.AddWithValue("@IntermediatePassYear", Convert.ToDateTime(obj.IntermediatePassYear));
                    cmd.Parameters.AddWithValue("@IntermediateAggregate", obj.IntermediateAggregate);


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
        public static bool InsertGraduation(Graduation obj)
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


                    SqlCommand cmd = new SqlCommand("SP_Graduation", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HTDID", obj.HTDID);
                    cmd.Parameters.AddWithValue("@EngineeringCollegeName", obj.EngineeringCollegeName);
                    cmd.Parameters.AddWithValue("@Branch", obj.Branch);
                    cmd.Parameters.AddWithValue("@EngineeringPassout", Convert.ToDateTime(obj.EngineeringPassout));
                    cmd.Parameters.AddWithValue("@Backlog", obj.Backlog);
                    cmd.Parameters.AddWithValue("@GraduationAggregate", obj.GraduationAggregate);


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
        public static bool InsertFamily(Family obj)
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


                    SqlCommand cmd = new SqlCommand("SP_Family", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HTDID", obj.HTDID);
                    cmd.Parameters.AddWithValue("@FathersName", obj.FathersName);
                    cmd.Parameters.AddWithValue("@PermanentAddress", obj.PermanentAddress);
                    cmd.Parameters.AddWithValue("@FathersMobileNo", obj.FathersMobileNo);
                    cmd.Parameters.AddWithValue("@MothersName", obj.MothersName);
                   
                    cmd.Parameters.AddWithValue("@MothersOccupation", obj.MothersOccupation);


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
