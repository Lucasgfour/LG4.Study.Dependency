using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Study.Data.Models {
    public class Pessoa {

        public int id { get; set; }
        public string name { get; set; } = "";
        public string email { get; set; } = "";
        public string phone { get; set; } = "";

        public Pessoa() { }

    }
}
