using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITTraleeCK
{
    class Rating
    {
        private int ratingID;
        private Question question;
        private Answer answer;
        private int rating;

        public int RatingID
        {
            get
            {
                return ratingID;
            }
            set
            {
                ratingID = value;
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
        public Answer Answer
        {
            get
            {
                return answer;
            }
            set
            {
                answer = value;
            }
        }

      public int RatingMark
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }
        public string ToString()
        {
            return "Rating id : " + RatingID +
                   "Question name : " + Question.QuestionText +
                   "Answer text : " + Answer.AnswerText +
                   "Rating : " + RatingMark;
        }
    }
}
