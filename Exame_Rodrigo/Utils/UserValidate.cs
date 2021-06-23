using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Utils
{
    public class UserValidate
    {
        public static bool Login(string username, string password)
        {
            bool answer = false;

            if (username.Equals("Rod") && password.Equals("12345"))
            {
                answer = true;
            }

            return answer;
        }
    }
}