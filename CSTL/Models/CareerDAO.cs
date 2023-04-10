using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSTL.Models
{
    public class CareerDAO
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobShortDescription { get; set; }
        public string JobFullDescription { get; set; }
        public DateTime? JobEntryDate { get; set; }
        public DateTime? JobApplyLastDate { get; set; }
        public string UploadBy { get; set; }
        public string EditedBy { get; set; }
        public string JobFeaturedImage { get; set; }
        public bool HotJob { get; set; }
        public int JobCatId { get; set; }
    }
}