using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOG_IN_out.ViewModels
{
    public class SignInModel
    {
        public string Email { get; set; }
        public string password { get; set; }
        public bool Rememberme { get; set; }
    }
}
