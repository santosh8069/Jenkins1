using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.DTO
{
    public class CreateUserDTO
    {
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public decimal mobileno { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public DateTime dateofbirth { get; set; }
    }
}
