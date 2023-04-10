using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSTL.Models
{
    public class JobApplicationDAO
    {
        public int ApplicantId { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }
        public DateTime? AppliedDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string SSCResult { get; set; }
        public string HSCResult { get; set; }
        public int UniversityId { get; set; }
        public string UniversityResult { get; set; }
        public int MastarsId { get; set; }
        public string MastarsResult { get; set; }
        public string Picture { get; set; }
        public string JobExperienceF { get; set; }
        public string JobExperienceS { get; set; }
        public string JobExperienceT { get; set; }
        public string JobExperienceFth { get; set; }
        public int SSCBoardId { get; set; }
        public int HSCBoardId { get; set; }
        public int ExprienceId { get; set; }
        public int JobId { get; set; }
        public string SchoolName { get; set; }
        public string CollegeName { get; set; }
        public string NID { get; set; }
        public string UniversityName { get; set; }
        public string MscDegree { get; set; }
        public string DegreeName { get; set; }
        public string MUniversityName { get; set; }
        public DateTime? SSCPassDate { get; set; }
        public DateTime? HSCPassDate { get; set; }
        public DateTime? UniversityPassDate { get; set; }
        public DateTime? MastarsPassDate { get; set; }
    }
}