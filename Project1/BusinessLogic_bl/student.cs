using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Project1.Models;
using System.Drawing;
namespace Project1.BusinessLogic_bl
{
    public class student
    {
        public static List<Model1> GetData1()
        {
            List<Model1> obj = new List<Model1>();
            var dbconfig = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_Displaydata_Project", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    obj.Add(new Model1
                    {
                        Sno = Convert.ToInt32(dr["Sno"].ToString()),
           
                        HallTicket = dr["HallTicket"].ToString(),
                        Name = dr["Name"].ToString(),
                        EmailID = dr["EmailID"].ToString(),
                        Dob = Convert.ToDateTime(dr["Dob"].ToString()),
                        Gender = dr["Gender"].ToString(),
                        StudentPHno = dr["StudentPHno"].ToString(),
                        SchoolName = dr["SchoolName"].ToString(),
                        SscPassYear = Convert.ToDateTime(dr["SscPassYear"].ToString()),
                        SscAggregate = Convert.ToInt32(dr["SscAggregate"].ToString()),
                        StudentAadhar = dr["StudentAadhar"].ToString(),
                        CollegeName = dr["CollegeName"].ToString(),
                        IntermediatePassYear = Convert.ToDateTime(dr["IntermediatePassYear"].ToString()),
                        IntermediateAggregate = Convert.ToInt32(dr["IntermediateAggregate"].ToString()),
                        EngineeringCollegeName = dr["EngineeringCollegeName"].ToString(),
                        Branch = dr["Branch"].ToString(),
                        EngineeringPassout = Convert.ToDateTime(dr["EngineeringPassout"].ToString()),
                        Backlog = Convert.ToInt32(dr["Backlog"].ToString()),
                        GraduationAggregate = Convert.ToInt32(dr["Backlog"].ToString()),

                        FathersName = dr["FathersName"].ToString(),
                        PermanentAddress = dr["PermanentAddress"].ToString(),
                        FathersMobileNo = dr["FathersMobileNo"].ToString(),
                        MothersName = dr["MothersName"].ToString(),

                        MothersOccupation = dr["MothersName"].ToString(),


                    });

                }
                return obj;
            }
        }
        public static List<Model1> checking()
        {
            List<Model1> obj = new List<Model1>();
            var dbconfig = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_Displaydata_Project_condition", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    obj.Add(new Model1
                    {
                        Sno = Convert.ToInt32(dr["Sno"].ToString()),

                        HallTicket = dr["HallTicket"].ToString(),
                        Name = dr["Name"].ToString(),
                        EmailID = dr["EmailID"].ToString(),
                        Dob = Convert.ToDateTime(dr["Dob"].ToString()),
                        Gender = dr["Gender"].ToString(),
                        StudentPHno = dr["StudentPHno"].ToString(),
                        SchoolName = dr["SchoolName"].ToString(),
                        SscPassYear = Convert.ToDateTime(dr["SscPassYear"].ToString()),
                        SscAggregate = Convert.ToInt32(dr["SscAggregate"].ToString()),
                        StudentAadhar = dr["StudentAadhar"].ToString(),
                        CollegeName = dr["CollegeName"].ToString(),
                        IntermediatePassYear = Convert.ToDateTime(dr["IntermediatePassYear"].ToString()),
                        IntermediateAggregate = Convert.ToInt32(dr["IntermediateAggregate"].ToString()),
                        EngineeringCollegeName = dr["EngineeringCollegeName"].ToString(),
                        Branch = dr["Branch"].ToString(),
                        EngineeringPassout = Convert.ToDateTime(dr["EngineeringPassout"].ToString()),
                        Backlog = Convert.ToInt32(dr["Backlog"].ToString()),
                        GraduationAggregate = Convert.ToInt32(dr["Backlog"].ToString()),

                        FathersName = dr["FathersName"].ToString(),
                        PermanentAddress = dr["PermanentAddress"].ToString(),
                        FathersMobileNo = dr["FathersMobileNo"].ToString(),
                        MothersName = dr["MothersName"].ToString(),

                        MothersOccupation = dr["MothersName"].ToString(),


                    });

                }
                return obj;
            }
        }
    }
}
