using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EhEOnline.Shared
{
    public class ContactUs
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
        public string comment { get; set; }
    }
}
