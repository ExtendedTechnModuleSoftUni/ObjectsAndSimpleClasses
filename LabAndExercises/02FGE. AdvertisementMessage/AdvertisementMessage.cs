namespace _02FGE.AdvertisementMessage
{
    using System;
    using System.Linq;

    public class AdvertisementMessage
    {
        public static void Main()
        {
            var phrasesAsText = "Excellent product.,Such a great product.,I always use that product.,Best product of its category.,Exceptional product.,I can’t live without this product.";
            string[] phrases = phrasesAsText.Split(',').ToArray();
            var eventsAsText = "Now I feel good.*I have succeeded with this product.*Makes miracles. I am happy of the results!*I cannot believe but now I feel awesome.*Try it yourself, I am very satisfied.*I feel great!";
            string[] events = eventsAsText.Split('*').ToArray();
            var authorsAsText = "Diana,Petya,Stella,Elena,Katya,Iva,Annie,Eva";
            string[] authors = authorsAsText.Split(',').ToArray();
            var citiesAsText = "Burgas,Sofia,Plovdiv,Varna,Ruse";
            string[] cities = citiesAsText.Split(',').ToArray();

            var randomGenerator = new Random();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int phraseIndex = randomGenerator.Next(0, phrases.Length);
                int eventIndex = randomGenerator.Next(0, events.Length);
                int authorIndex = randomGenerator.Next(0, authors.Length);
                int cityIndex = randomGenerator.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} - {cities[cityIndex]}");
            }
        }
    }
}
