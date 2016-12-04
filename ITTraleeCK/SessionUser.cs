using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITTraleeCK
{
    class SessionUser
    {

        private static Member loggedInMember = null;

        public static void LogOn(Member member)
        {
            loggedInMember = member;
        }

        public static Member WhoIsLoggedIn()
        {
            return loggedInMember;
        }

        public static void LogOut()
        {
            loggedInMember = null;
        }


    }
}
