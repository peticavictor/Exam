using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Answer> answers1 = new List<Answer>();
            answers1.Add(new Answer(1, "Atlantic", false));
            answers1.Add(new Answer(2, "Pacific", true));
            answers1.Add(new Answer(3, "Indian", false));

            List<Answer> answers2 = new List<Answer>();
            answers2.Add(new Answer(1, "H2SO4", false));
            answers2.Add(new Answer(2, "NaCl", false));
            answers2.Add(new Answer(3, "H2O", true));

            List<Answer> answers3 = new List<Answer>();
            answers3.Add(new Answer(1, "Da", false));
            answers3.Add(new Answer(2, "Nu", true));

            List<Question> questions = new List<Question>();

            questions.Add(new Question(1, "Care este cel mai mare ocean", answers1));
            questions.Add(new Question(2, "Care este formula chimica a apei", answers2));
            questions.Add(new Question(3, "Este Luna o planeta", answers3));

            int counter = 0;
            foreach(Question question in questions)
            {
                Console.WriteLine($"{question.id}. {question.value} ?" );
                foreach (Answer answer in question.answers)
                {
                    Console.WriteLine($"    {answer.id}. {answer.value}");
                }
                try
                {
                    int ans = int.Parse(Console.ReadLine());
                    if (question.answers[ans - 1].isTrue)
                    {
                        counter++;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Wrong answer");
                }
                Console.WriteLine($"================= Raspunsuri corecte : {counter}");
            }
        }
    }

    class Question
    {
        public int id { get; set; }
        public string value { get; set; }
        public List<Answer> answers { get; set; }

        public Question(int id, string value, List<Answer> answers)
        {
            this.id=id;
            this.value=value;
            this.answers=answers;
        }
    }

    class Answer
    {
        public int id { get; set; }
        public string value { get; set; }
        public bool isTrue { get; set; } = false;

        public Answer(int id, string value, bool isTrue)
        {
            this.id=id;
            this.value=value;
            this.isTrue=isTrue;
        }
    }
}
