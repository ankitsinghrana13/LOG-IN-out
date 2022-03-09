
using LOG_IN_out.Models;
using LOG_IN_out.Repository.Interface;
using LOG_IN_out.Utils.Enums;
using LOG_IN_out.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOG_IN_out.Repository.Services
{
    public class AccountService : IUsers
    {
        private MSDBContext dbContext;
        public AccountService()
        {
            dbContext = new MSDBContext();
        }

        public SignInEnum SignIn(SignInModel model)
        {
            var user = dbContext.TBL_Users.SingleOrDefault(e => e.Email == model.Email && e.Password == model.password);
                if (user!=null)
            {
                if (user.IsVerified)
                {

                    if (user.IsActive)
                    {

                        return SignInEnum.NotVerified;
                    }
                    else
                    {
                        return SignInEnum.InActive;

                    }
                }
                else
                {
                    return SignInEnum.NotVerified;
                }

            }
            else
            {
                return SignInEnum.WrongCredentials;
            }

        }
    
       public SignUpEnum SignUp(SignUpModel model)
        {
            throw new NotImplementedException();
        }
    }
}
