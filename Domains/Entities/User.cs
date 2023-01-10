using System;
using System.Collections.Generic;

namespace Domains.Entities
{
    public class User
    {
        public int Userid { get; set; }
        public string? Firstname { get; set; }
        public string? Middlename { get; set; }
        public string? Lastname { get; set; }
        public decimal? Mobileno { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public DateTime? Dateofbirth { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
