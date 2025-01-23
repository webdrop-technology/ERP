using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using WD.Tailoring.Core.Entities.Drivers;

namespace WD.Tailoring.Core.Entities.Students
{
    public class Student
    {
        //Personal Details
        public required string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }   
        public DateTime DOB { get; set; }
        public int Gender { get; set; }
        public Blob Photo { get; set; }     
        public string? MobileNumber { get; set; }
        public string? AlternateMobileNumber { get; set; }
        public string? Email { get; set; }
        public string Board { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }

        public DateTime EnrollmentDate { get; set; }
        public string Religion { get; set; }
        public string Nationality { get; set; }
        public string Caste { get; set; }
        public string? BloodGroup { get; set; }
        public bool IsPhysicallyChallenged { get; set; }
        public bool Status { get; set; }
        public bool? TC { get; set; }
        public bool? CC { get; set; }
        public bool? ReportCard { get; set; }
        public bool? DOBCertificate { get; set; }
        public int AcademicYearId { get; set; }
        public virtual AcademicYears? AcademicYears { get; set; }



        //Address 
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public string AddressTypeId{ get; set; }



        //Student Guardian Name
        public string? FatherName { get; set; }
        public DateTime? FatherDOB { get; set; }
        public string? FatherOccupation { get; set; }
        public string? FatherQualification { get; set; }
        public string? MotherName { get; set; }
        public DateTime? MotherDOB { get; set; }
        public string? MotherOccupation { get; set; }
        public string? MotherQualification { get; set; }
        public string? SpouseName { get; set; }
        public string? RelationToStudent { get; set; }

        
        //Bank Details
        public string? BankName { get; set; }
        public string? BranchName { get; set; }
        public string? IFSCCode { get; set; }
        public string? AadharNumber { get; set; }

        //Medical 
       
        //Previous Information
        

     

    }
}
