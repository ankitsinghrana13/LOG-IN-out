using LOG_IN_out.Utils.Enums;
using LOG_IN_out.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOG_IN_out.Repository.Interface
{
    public interface IUsers
    {
        SignInEnum SignIn(SignInModel model);
        SignUpEnum SignUp(SignUpModel model);
    }
}
