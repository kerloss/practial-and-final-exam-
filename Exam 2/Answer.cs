using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int _answerId, string _answerText)
        {
            AnswerId = _answerId;
            AnswerText = _answerText;
        }

        public override string ToString()
        {
            return $"AnswerID : {AnswerId} , AnswerText : {AnswerText}";
        }
    }
}
