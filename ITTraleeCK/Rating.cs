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
        private Question questionID;
        private Answer answerID;
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
        public Answer AnswerID
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

    }
}
