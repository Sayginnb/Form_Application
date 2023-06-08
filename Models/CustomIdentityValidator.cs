using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Form_Application.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "Parola en az 6 karakter olmalıdır"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Description = "Parola en az 1 büyük harf içermelidir.",
                Code = "PasswordRequiresUpper"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Description = "Parola en az 1 küçük harf içermelidir.",
                Code = "PasswordRequiresLower"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Description = "Parola en az 1 alfanümerik karakter içermelidir.",
                Code = "PasswordRequiresNonAlphanumeric"
            };
        }

    }
}
