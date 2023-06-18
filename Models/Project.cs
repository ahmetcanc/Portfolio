using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolyom.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Project_Name { get; set; }
        public string Project_Image { get; set; }
        public string Project_Url { get; set; }
        public string Project_Info { get; set; }
    }
}