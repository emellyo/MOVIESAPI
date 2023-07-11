using Microsoft.AspNetCore.Mvc.DataAnnotations.Internal;
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

    public class MOVIE
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal rating { get; set; }
        public string image { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class CREATEMOVIE
    {
        public int ID { get; set; } = 1;
        public string title { get; set; } = "";
        public string description { get; set; } = "";
        public decimal rating { get; set; } = 0;
        public string image { get; set; } = "";
        //public DateTime created_at { get; set;} = DateTime.Now;
        //public DateTime updated_at { get; set; } = DateTime.Now;
    }
}
