using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal class McqQestion : Question
    {
        public McqQestion(string _header, string _body, double mark, Answer[] _answers, Answer _correctAnswer)
            : base(_header, _body, mark)
        {
            CorrectAnswerID = _correctAnswer;
            AnswerList = _answers;
        }

        //public override string ShowQuestion()
        //{
        //    //Display MCQ question format
        //    string question = $"{Header}\n{Body}\n";
        //    for (int i = 0; i < AnswerList.Length; i++)
        //    {
        //        question += $"{i + 1}. {AnswerList[i].AnswerText}\n";
        //    }
        //    return question;
        //}

        public override void ShowQuestion()
        {
            //Display MCQ question format
            Console.WriteLine($"(MCQ Question)    Mark {Mark}\nHeader: {Header}\nBody: {Body}");
            foreach (var answer in AnswerList)
            {
                Console.WriteLine($"{answer.AnswerId} , {answer.AnswerText}");
            }
        }
    }
}
