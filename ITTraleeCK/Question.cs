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
        private Member member;
        private Category category;
        private string questionText;
        private DateTime questionDate;

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
        public Member Member
        {
            get
            {
                return member;
            }
            set
            {
                member = value;
            }
        }
        public Category Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
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
        public DateTime QuestionDate
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
