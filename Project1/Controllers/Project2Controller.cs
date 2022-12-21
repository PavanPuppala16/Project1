using Microsoft.AspNetCore.Mvc;
using Project1.Models;
using System.Data.SqlClient;
using System.Data;

namespace Project1.Controllers
{
    public class Project2Controller : Controller
    {
        [HttpGet]
        public IActionResult ManageSTD()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ManageSTD(List<IFormFile> PostedFiles, HiringSTD obj)
        {
            foreach (IFormFile PostedFile in PostedFiles)
            {
                string fileName = Path.GetFileName(PostedFile.FileName);
                string type = PostedFile.ContentType;
                byte[] bytes = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    PostedFile.CopyTo(ms);
                    bytes = ms.ToArray();
                }
                var dbconfig = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
                string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
                using (SqlConnection con = new SqlConnection(dbconnectionstr))
                {
                    SqlCommand cmd = new SqlCommand("sp_hiringSTD", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Hall_ticket_no", obj.Hall_ticket_no);
                    cmd.Parameters.AddWithValue("@Name_of_the_student", obj.Name_of_the_student);
                    cmd.Parameters.AddWithValue("@Emailid", obj.Emailid);
                    cmd.Parameters.AddWithValue("@Dob", Convert.ToDateTime(obj.Dob));
                    cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                    cmd.Parameters.AddWithValue("@PH_No", Convert.ToInt64(obj.PH_No));
                    cmd.Parameters.AddWithValue("@Aadhar_no", Convert.ToInt64(obj.Aadhar_no));
                    cmd.Parameters.AddWithValue("@School_Name", obj.School_Name);
                    cmd.Parameters.AddWithValue("@ssc_Year_of_Pass_out", Convert.ToInt32(obj.ssc_Year_of_Pass_out));
                    cmd.Parameters.AddWithValue("@Ssc_Aggregate", obj.Ssc_Aggregate);
                    cmd.Parameters.AddWithValue("@Junior_College_Name", obj.Junior_College_Name);
                    cmd.Parameters.AddWithValue("@inter_Year_of_Pass_out", Convert.ToInt32(obj.inter_Year_of_Pass_out));
                    cmd.Parameters.AddWithValue("@inter_Aggregate", obj.inter_Aggregate);
                    cmd.Parameters.AddWithValue("@Engineering_College_Name", obj.Engineering_College_Name);
                    cmd.Parameters.AddWithValue("@Branch", obj.Branch);
                    cmd.Parameters.AddWithValue("@Btech_Year_of_Pass_out", Convert.ToInt32(obj.Btech_Year_of_Pass_out));

                    cmd.Parameters.AddWithValue("@Total_backlogs", Convert.ToInt32(obj.Total_backlogs));
                    cmd.Parameters.AddWithValue("@Graduation_Aggregate", obj.Graduation_Aggregate);
                    cmd.Parameters.AddWithValue("@Fathers_name", obj.Fathers_name);
                    cmd.Parameters.AddWithValue("@Fathers_occupation", obj.Fathers_occupation);
                    cmd.Parameters.AddWithValue("@Permanent_address", obj.Permanent_address);
                    cmd.Parameters.AddWithValue("@Present_address", obj.Present_address);
                    cmd.Parameters.AddWithValue("@Fathers_Mobile_No", obj.Fathers_Mobile_No);
                    cmd.Parameters.AddWithValue("@Mothers_Name", obj.Mothers_Name);
                    cmd.Parameters.AddWithValue("@Mothers_Occupation", obj.Mothers_Occupation);
                    cmd.Parameters.AddWithValue("@Name", fileName);
                    cmd.Parameters.AddWithValue("@ContentType", type);
                    cmd.Parameters.AddWithValue("@Data", bytes);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            return View();
        }
    }
}
