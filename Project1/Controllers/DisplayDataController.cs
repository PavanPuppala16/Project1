using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Dynamic;
using Project1.Models;

namespace Project1.Controllers
{
    public class DisplayDataController : Controller
    {
        public ActionResult Index()
        {
            dynamic model = new ExpandoObject();
            model.GenericInfo = GetGenericInfo();
            model.Schooling = GetSchooling();
            model.Intermediate = GetIntermediate();
            model.Graduation = GetGraduation();
            model.Family = GetFamily();
            return View(model);
        }

        private static List<GenericInfo> GetGenericInfo()
        {
            List<GenericInfo> CUSTOMER = new List<GenericInfo>();
            var dbconfig = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                SqlCommand cmd = new SqlCommand("SP_DISPLAY_TBL_GenericInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        CUSTOMER.Add(new GenericInfo
                        {
                            HTDID = Convert.ToInt32(sdr["HTDID"].ToString()),
                            Sno = Convert.ToInt32(sdr["Sno"].ToString()),
                            HallTicket = sdr["HallTicket"].ToString(),
                            Name = sdr["Name"].ToString(),
                            EmailID = sdr["EmailID"].ToString(),
                            Dob = Convert.ToDateTime(sdr["Dob"].ToString()),
                            Gender = sdr["Gender"].ToString(),
                            StudentPHno =sdr["StudentPHno"].ToString(),
                            StudentAadhar = sdr["StudentAadhar"].ToString(),
                        });
                    }
                }
                con.Close();
                return CUSTOMER;
            }
        }
        private static List<Schooling> GetSchooling()
        {
            List<Schooling> Schooling = new List<Schooling>();
            var dbconfig = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                SqlCommand cmd = new SqlCommand("SP_DISPLAY_TBL_Schooling", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader adr = cmd.ExecuteReader())
                {
                    while (adr.Read())
                    {
                        Schooling.Add(new Schooling
                        {
                            HTDID = Convert.ToInt32(adr["HTDID"].ToString()),
                            SchoolName = adr["SchoolName"].ToString(),
                            SscPassYear =Convert.ToDateTime(adr["SscPassYear"].ToString()),
                            SscAggregate = Convert.ToInt32(adr["SscAggregate"].ToString()),

                        });
                    }
                    con.Close();
                    return Schooling;
                }

            }
        }
        private static List<Intermediate> GetIntermediate()
        {
            List<Intermediate> Obj2 = new List<Intermediate>();
            var dbconfig = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                SqlCommand cmd = new SqlCommand("SP_DISPLAY_TBL_Intermediate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader bdr = cmd.ExecuteReader())
                {
                    while (bdr.Read())
                    {
                        Obj2.Add(new Intermediate
                        {

                            HTDID = Convert.ToInt32(bdr["HTDID"].ToString()),
                            CollegeName = bdr["CollegeName"].ToString(),
                            IntermediatePassYear = Convert.ToDateTime(bdr["IntermediatePassYear"].ToString()),
                            IntermediateAggregate =Convert.ToInt32( bdr["IntermediateAggregate"].ToString()),
                        });
                    }
                    con.Close();
                    return Obj2;
                }

            }
        }
        private static List<Graduation> GetGraduation()
        {
            List<Graduation> Obj3 = new List<Graduation>();
            var dbconfig = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                SqlCommand cmd = new SqlCommand("SP_DISPLAY_Graduation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader cdr = cmd.ExecuteReader())
                {
                    while (cdr.Read())
                    {
                        Obj3.Add(new Graduation
                        {

                            HTDID = Convert.ToInt32(cdr["HTDID"].ToString()),
                            EngineeringCollegeName = cdr["EngineeringCollegeName"].ToString(),
                            Branch = cdr["Branch"].ToString(),
                            EngineeringPassout = Convert.ToDateTime(cdr["EngineeringPassout"].ToString()),
                            Backlog = Convert.ToInt32(cdr["Backlog"].ToString()),
                            GraduationAggregate = Convert.ToInt32(cdr["Backlog"].ToString())
                        });
                    }
                    con.Close();
                    return Obj3;
                }

            }
        }
        private static List<Family> GetFamily()
        {
            List<Family> obj4 = new List<Family>();
            var dbconfig = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                SqlCommand cmd = new SqlCommand("SP_DISPLAY_Family", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader ddr = cmd.ExecuteReader())
                {
                    while (ddr.Read())
                    {
                        obj4.Add(new Family
                        {

                            HTDID = Convert.ToInt32(ddr["HTDID"].ToString()),
                            FathersName = ddr["FathersName"].ToString(),
                            PermanentAddress = ddr["PermanentAddress"].ToString(),
                            FathersMobileNo = ddr["FathersMobileNo"].ToString(),
                            MothersName = ddr["MothersName"].ToString(),

                            MothersOccupation = ddr["MothersName"].ToString(),

                        });
                    }
                    con.Close();
                    return obj4;
                }

            }
        }
    }
}
