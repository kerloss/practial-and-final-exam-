using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int _timeOfExam, List<Question> _question)
            : base(_timeOfExam, _question)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam ");
            double totalGradeCorrect = 0;
            double totalGrade = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (var question in Questions)
            {
                int answerId;
                do
                {
                    question.ShowQuestion();
                    Console.WriteLine("Your Answer : ");
                } while (!int.TryParse(Console.ReadLine(), out answerId));

                //display feedback for answer(show correct answer)
                if (question.AnswerList[answerId - 1].AnswerId.Equals(question.CorrectAnswerID.AnswerId))
                {
                    Console.WriteLine("Correct!\n"); 
                    totalGradeCorrect += question.Mark;
                }

                else
                    Console.WriteLine($"Wrong!\n");

                totalGrade += question.Mark;
                ShowAnswer(answerId);
            }
            stopwatch.Stop();
            //TimeSpan elapsedTime = stopwatch.Elapsed;
            //Console.WriteLine($"{elapsedTime.Hours:D2}:{elapsedTime.Minutes:D2}:{elapsedTime.Seconds:D2}");
            Console.WriteLine($"Your Grade is {totalGradeCorrect} from {totalGrade}");

            Console.WriteLine($"{stopwatch.Elapsed.Hours}:{stopwatch.Elapsed.Minutes}:{stopwatch.Elapsed.TotalSeconds}");
        }

        public void ShowAnswer(int answerId)
        {
            int count = 0;
            foreach (var item in Questions)
            {
                count++;
                Console.WriteLine($"Question {count}: {item.Body}");
                Console.WriteLine($"Your answer => {item.AnswerList[answerId - 1].AnswerText}");
                Console.WriteLine($"Right answer => {item.CorrectAnswerID.AnswerText}");
            }
        }

        //public override void ShowExam()
        //{
        //    Console.WriteLine("Practical Exam");
        //    foreach (var question in Questions)
        //    {
        //        Console.WriteLine(question.ShowQuestion());
        //    }
        //}

        //public void ShowCorrectAnswer()
        //{
        //    foreach (var question in Questions)
        //    {
        //        Console.WriteLine(question.ShowQuestion());
        //        Console.WriteLine($"Correct Answer : {question.AnswerList[question.CorrectAnswerId - 1].AnswerText}");
        //    }
        //}
    }
}
