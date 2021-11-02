using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApiProject
{
    //Model of cricketers with 3 fields
    public class Cricketer
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Cricketer Name")]
        public string CricketerName { get; set; }
        public string Team { get; set; }
        
    }
}
