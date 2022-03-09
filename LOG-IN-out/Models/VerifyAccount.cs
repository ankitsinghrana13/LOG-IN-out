using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOG_IN_out.Models
{
    public class VerifyAccount
    {
        public int Id { get; set; }
        public string Otp { get; set; }
        public int Userid { get; set; }
        public DateTime? SendTime { get; set; }

    }
}
