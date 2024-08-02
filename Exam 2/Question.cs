using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer CorrectAnswerID { get; set; }  //ID of correct answer

        //public Question(string _header, string _body, double _mark, Answer[] _answers, Answer _correctAnswer)
        //{
        //    Header = _header;
        //    Body = _body;
        //    Mark = _mark;
        //    AnswerList = _answers;
        //    CorrectAnswerID = _correctAnswer;
        //}

        public Question(string _header, string _body, double _mark)
        {
            Header = _header;
            Body = _body;
            Mark = _mark;
        }

        public abstract void ShowQuestion();  //abstract method to display the question

        public override string ToString()
        {
            return $"Header : {Header} , Body : {Body} , Mark : {Mark}";
        }

        public bool CheckAnswer(Answer selectAnswerId)
        {
            return selectAnswerId == CorrectAnswerID;
        }
    }
}
