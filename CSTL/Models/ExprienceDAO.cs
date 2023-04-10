using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSTL.Models
{
    public class ExprienceDAO
    {
        public int ExprienceId { get; set; }
        public int ApplicantId { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public string Duration { get; set; }
    }
}