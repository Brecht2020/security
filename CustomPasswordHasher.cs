using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestToDo.Web
{
    public class CustomPasswordHasher : IPasswordHasher

    {

        public string HashPassword(string password)

        {

            return Encrypt.GetMD5Hash(password);
        }
        public PasswordVerificationResult verifyHashedPassword( string hashedPassword, string providedPassword )

        {

            if (hashedPassword == HashPassword(providedPassword))
                return PasswordVerificationResult.Success;
            else
                return PasswordVerificationResult.Failed;

        }

    }

}
