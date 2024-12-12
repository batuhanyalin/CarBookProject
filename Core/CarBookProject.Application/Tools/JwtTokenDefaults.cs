using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Tools
{
    public class JwtTokenDefaults
    {
        //const sabit anlamı taşıyor
        public const string ValidAudience = "https://localhost";
        public const string ValidIssuer = "https://localhost";
        public const string Key = "Car_book#pasS.%42pRo=jec*t01_42?16";
        public const int Expire = 3;

    }
}
