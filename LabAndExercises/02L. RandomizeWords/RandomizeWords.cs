namespace _02L.RandomizeWords
{
    using System;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToArray();

            var randomGenerator = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int possition = randomGenerator.Next(words.Length);

                string prev = words[i];
                words[i] = words[possition];
                words[possition] = prev;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
