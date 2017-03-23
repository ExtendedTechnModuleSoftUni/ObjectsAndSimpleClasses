namespace _01E.Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Exercises
    {
        public class MoreExersises
        {
            public string Topic { get; set; }

            public string CourseName { get; set; }

            public string JudgeContestLink { get; set; }

            public List<string> Problems { get; set; }
        }

        public static void Main()
        {
            var exercises = new List<MoreExersises>();
            var inputLine = Console.ReadLine();

            while (inputLine != "go go go")
            {
                string[] tokens = inputLine.Split(new char[] { ' ', '>', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                MoreExersises newExersises = new MoreExersises
                {
                    Topic = tokens[0],
                    CourseName = tokens[1],
                    JudgeContestLink = tokens[2],
                    Problems = tokens.Skip(3).ToList()
                };

                exercises.Add(newExersises);

                inputLine = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                var counter = 1;

                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{counter}. {problem}");
                    counter++;
                }
            }
        }
    }
}
