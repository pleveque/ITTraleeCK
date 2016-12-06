using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITTraleeCK
{
    /**
     * This class allow to create a session for each member who connect in the application
     */ 
    class SessionUser
    {

        private static Member loggedInMember = null;

        /**
         * Method to log on a member
         * pass in argument a member
         */ 
        public static void LogOn(Member member)
        {
            loggedInMember = member;
        }

        /*
         * Method to know who is logged in
         * return a member
         */ 
        public static Member WhoIsLoggedIn()
        {
            return loggedInMember;
        }

        /*
         * Method to log out the member
         */ 
        public static void LogOut()
        {
            loggedInMember = null;
        }


    }
}
