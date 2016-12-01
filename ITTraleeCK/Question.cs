using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITTraleeCK
{
    class Question
    {
        private int questionID;
        private Member memberID;
        private Category categoryID;
        private string questionText;
        private string questionDate;

        public int QuestionID
        {
            get
            {
                return questionID;
            }
            set
            {
                questionID = value;
            }
        }
        public Member MemberID
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
        public Category CategoryID
        {
            get
            {
                return categoryID;
            }
            set
            {
                categoryID = value;
            }
        }
        public string QuestionText
        {
            get
            {
                return questionText;
            }
            set
            {
                questionText = value;
            }
        }
        public string QuestionDate
        {
            get
            {
                return questionDate;
            }
            set
            {
                questionDate = value;
            }
        }

    }
}
