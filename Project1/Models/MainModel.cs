using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class MainModel
    {
        
        public int userid { get; set; }
        [Required(ErrorMessage = "What's ur Name*")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "What's ur Name*")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required*")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        
        public string EmailID { get; set; }

        [Required(ErrorMessage = "Please enter password*")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character")]

        public string Password { get; set; }

        [Required(ErrorMessage = "Select Gender*")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Select DOB*")]
        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "Select Role*")]

        public string Role { get; set; }
        [Required(ErrorMessage = " Status is required*")]
        public bool Status { get; set; }

        [Required(ErrorMessage = " InsertionDate is Required*")]
        public DateTime InsertionDate { get; set; }

    }
}
public class AdminLogin
{
    [Required(ErrorMessage = "Email is required*")]
    [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
   
    public string EmailID { get; set; }


    [Required(ErrorMessage = "Please enter password*")]
    [DataType(DataType.Password)]
    [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 8)]
    [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character")]
   
    public string Password { get; set; }

}
public class USER
{
    public string ADDUser { get; set; }
}
public class GenericInfo
{
    public int Sno { get; set; }

    public int  HTDID { get; set; }
    public string HallTicket { get; set; }
    [Required(ErrorMessage = "What's ur Name*")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Email is required*")]
    [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
    public string EmailID { get; set; }
    [Required(ErrorMessage = "select Dob*")]
    public DateTime Dob { get; set; }
    [Required(ErrorMessage = " Gender is requried*")]
    public string Gender { get; set; }

    [Required(ErrorMessage = "Mobile is required*")]
    [RegularExpression(@"\d{10}", ErrorMessage = "Please enter 10 digit Mobile No.")]
    public string StudentPHno { get; set; }
    [Required(ErrorMessage = "Mobile is required*")]
    [RegularExpression(@"\d{12}", ErrorMessage = "Please enter 12 digit Aadhar  No.")]
    public string StudentAadhar { get; set; }

}
public class Schooling
{
    public int HTDID { get; set; }
    public string SchoolName { get; set; }
    public DateTime SscPassYear { get; set; }
    public float SscAggregate { get; set; }
}
public class Intermediate
{
    public int HTDID { get; set; }
    public string CollegeName { get; set; }
    public DateTime IntermediatePassYear { get; set; }
    public float IntermediateAggregate { get; set; }
}


public class Graduation
{
    public int HTDID { get; set; }
    public string EngineeringCollegeName { get; set; }
    public string Branch { get; set; }
    public DateTime EngineeringPassout { get; set; }

    public int Backlog { get; set; }
    public float GraduationAggregate { get; set; }


}
public class Family
{
    public int HTDID { get; set; }
    public string FathersName { get; set; }
public string PermanentAddress { get; set; }
    public string FathersMobileNo { get; set; }
    public string MothersName { get; set; }
    public string MothersOccupation { get; set; }


}

public class HTDID1
{
    public int HTDID { get; set; }
    public int Sno { get; set; }

   
    public string HallTicket { get; set; }
    [Required(ErrorMessage = "What's ur Name*")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Email is required*")]
    [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
    public string EmailID { get; set; }
    [Required(ErrorMessage = "select Dob*")]
    public DateTime Dob { get; set; }
    [Required(ErrorMessage = " Gender is requried*")]
    public string Gender { get; set; }

    [Required(ErrorMessage = "Mobile is required*")]
    [RegularExpression(@"\d{10}", ErrorMessage = "Please enter 10 digit Mobile No.")]
    public string StudentPHno { get; set; }
    [Required(ErrorMessage = "Mobile is required*")]
    [RegularExpression(@"\d{12}", ErrorMessage = "Please enter 12 digit Aadhar  No.")]
    public string StudentAadhar { get; set; }
   
    public string SchoolName { get; set; }
    public DateTime SscPassYear { get; set; }
    public float SscAggregate { get; set; }
   
    public string CollegeName { get; set; }
    public DateTime IntermediatePassYear { get; set; }
    public float IntermediateAggregate { get; set; }
   
    public string EngineeringCollegeName { get; set; }
    public string Branch { get; set; }
    public DateTime EngineeringPassout { get; set; }

    public int Backlog { get; set; }
    public float GraduationAggregate { get; set; }
 
    public string FathersName { get; set; }
    public string PermanentAddress { get; set; }
    public string FathersMobileNo { get; set; }
    public string MothersName { get; set; }
    public string MothersOccupation { get; set; }

}








