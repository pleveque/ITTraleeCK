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
        private Question question;
        private Member member;
        private string answerText;
        private DateTime answerDate;

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
        public Question Question
        {
            get
            {
                return question;
            }
            set
            {
                question = value;
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
        public DateTime AnswerDate
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
        public string ToString()
        {
            return "Answer ID : " + this.AnswerID +
                   "Question Name : " + this.Question.QuestionText +
                   "Member username : " + this.Member.Username +
                   "Answer text : " + this.answerText +
                   "Answer date : " + this.AnswerDate.ToString();
        }
    }
}
