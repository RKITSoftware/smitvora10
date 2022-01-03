using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Module_7ApiDatabase.Models
{
    public class Cricketer
    {
        [DisplayName("Cricketer Name")]

        public int CricketerId { get; set; }
        public string CricketerName { get; set; }
        public string Team { get; set; }
        public int Runs { get; set; }
    }
}