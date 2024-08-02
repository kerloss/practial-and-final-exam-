using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string _header, string _body, double _mark, Answer _correctAnswer)
            : base(_header, _body, _mark)
        {
            CorrectAnswerID = _correctAnswer;
            AnswerList = new Answer[]
            {
                new Answer(1,"True"),
                new Answer(2,"False")
            };
        }

        //public override string ShowQuestion()
        //{
        //    //Display true/false question format
        //    return $"(True/False) {Header}\n{Body}\n1. True/n2. False";
        //}

        public override void ShowQuestion()
        {
            //Display true/false question format
            Console.WriteLine($"(True/False)    Mark {Mark}\n Header: {Header}\n Body: {Body}");
            foreach (var answer in AnswerList)
            {
                Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
            }
        }
    }
}
