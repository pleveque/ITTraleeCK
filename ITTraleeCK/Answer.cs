using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITTraleeCK
{
    class Answer
    {
        private int answerID;
        private Question questionID;
        private Member memberID;
        private string answerText;
        private string answerDate;

        public int AnswerID
        {
            get
            {
                return answerID;
            }
            set
            {
                answerID = value;
            }
        }
        public Question QuestionID
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
        public string AnswerText
        {
            get
            {
                return answerText;
            }
            set
            {
                answerText = value;
            }
        }
        public string AnswerDate
        {
            get
            {
                return answerDate;
            }
            set
            {
                answerDate = value;
            }
        }

    }
}
