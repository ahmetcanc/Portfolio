using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolyom.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public int Name_Surname { get; set; }
        public int Subject { get; set; }
        public int Message { get; set; }
    }
}