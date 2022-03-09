using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOG_IN_out.ViewModels
{
    public class SignUpModel
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }
    }
}
