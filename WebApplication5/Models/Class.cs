using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class User
    {
        public string USERID { get; set; }
        public string USERNAME { get; set; }
        public string NAMA { get; set; }
        public string NAMA_PANGGILAN { get; set; }
    }

    public class CreateUser
    {
        public string USERID { get; set; } = "";
        public string NAMA { get; set; } = "";
        public string NAMA_PANGGILAN { get; set; } = "";
    }
}
