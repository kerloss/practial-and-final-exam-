using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal class FinalExam : Exam
    {
        public FinalExam(int _timeOfExam, List<Question> _question)
            : base(_timeOfExam, _question)
        {
        }

        //display the format of exam
        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
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
                    Console.Write("Your answer : ");
                } while (!int.TryParse(Console.ReadLine(), out answerId));

                //check if the answer is correct
                if (question.AnswerList[answerId-1].AnswerId.Equals(question.CorrectAnswerID.AnswerId))
                {
                    Console.WriteLine("Correct!\n");
                    totalGradeCorrect += question.Mark;
                }
                else
                {
                    Console.WriteLine($"Wrong!\n");
                }
                totalGrade += question.Mark;
                ShowAnswer(answerId);
            }
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            string formattedTime = $"{elapsedTime.Hours}:{elapsedTime.Minutes}:{elapsedTime.TotalSeconds}";


            Console.WriteLine($"Your Grade is {totalGradeCorrect} from {totalGrade}");

            Console.WriteLine($"Time : {formattedTime}");
            Console.WriteLine("THANK YOU!!");
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
        //    Console.WriteLine("Final Exam");
        //    foreach (var question in Questions)
        //    {
        //        Console.WriteLine(question.ShowQuestion());
        //    }
        //}


        //public void ShowResult(int[] selectedAnswer)
        //{
        //    double totalGrade = 0;
        //    for (int i = 0; i < Questions.Count; i++)
        //    {
        //        var question = Questions[i];
        //        //if checkanswer method return answerID equal then it will return true
        //        bool isCorrect = question.CheckAnswer(selectedAnswer[i]);
        //        //ternairy operator if selectedanswerID true get question mark else put zero
        //        totalGrade += isCorrect ? question.Mark : 0;
        //        //if (isCorrect)
        //        //    totalGrade += question.Mark;
        //        //else
        //        //    question.Mark = 0;
        //        Console.WriteLine($"Question {i + 1}: {(isCorrect ? "Correct" : "Wrong")}");
        //    }

        //    Console.WriteLine($"Total Grade: {totalGrade}/{Questions.Count}");
        //}
    }
}
