using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITTraleeCK
{
    class Member
    {

        private int memberID;
        private string username;
        private string memberPassword;
        private int age;
        private string email;
        private string gender;
        private string nationality;
        private string categoryOfKnowledge;
        private string newsletter;
        private string typeOfMember;

        public int MemberID
        {
            get
            {
                return memberID;
            }
            set
            {
                memberID = value;
            }
        }

        public String Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string MemberPassword
        {
            get
            {
                return memberPassword;
            }
            set
            {
                memberPassword = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public string Nationality
        {
            get
            {
                return nationality;
            }
            set
            {
                nationality = value;
            }
        }
        public string CategoryOfKnowledge
        {
            get
            {
                return categoryOfKnowledge;
            }
            set
            {
                categoryOfKnowledge = value;
            }
        }
        public string Newsletter
        {
            get
            {
                return newsletter;
            }
            set
            {
                newsletter = value;
            }
        }
        public string TypeOfMember
        {
            get
            {
                return typeOfMember;
            }
            set
            {
                typeOfMember = value;
            }
        }

       override
       public string ToString()
        {
            return this.MemberID + " " + this.Username;
        }

    }
}
