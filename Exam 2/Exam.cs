using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }
        //public Subject subject { get; set; }

        public Exam(int _timeOfExam,List<Question> _question)
        {
            TimeOfExam = _timeOfExam;
            Questions = _question;
            NumberOfQuestions = _question.Count;
        }

        //public Exam(TimeSpan _timeOfExam, int _numberOfQuestions, Subject _subject, List<Question> _question)
        //{
        //    TimeOfExam = _timeOfExam;
        //    NumberOfQuestions = _numberOfQuestions;
        //    //Questions = new List<Question>();
        //    Questions = _question;
        //    this.subject = _subject;
        //}

        public abstract void ShowExam();

        //public void AddQuestion(Question question)
        //{
        //    if (Questions.Count < NumberOfQuestions)
        //        Questions.Add(question);
        //}

        public override string ToString()
        {
            return $"Exam with {NumberOfQuestions} questions and a duration of exam is {TimeOfExam} .";
        }
    }
}
