using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApplication.Models
{
    //Model of Cricketer representing 3 fields
    public class Cricketer
    {
        [DisplayName("Cricketer Name")]
        public string CricketerName { get; set; }
        public string  Team { get; set; }
    }
}
