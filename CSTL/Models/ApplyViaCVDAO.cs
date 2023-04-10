using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSTL.Models
{
    public class ApplyViaCVDAO
    {
        public int CVId { get; set; }
        public int JobId { get; set; }
        public string Resume { get; set; }
        public DateTime? AppliedDate { get; set; }
    }
}