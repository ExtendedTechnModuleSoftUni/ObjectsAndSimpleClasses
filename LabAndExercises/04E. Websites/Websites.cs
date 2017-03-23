namespace _04E.Websites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Website
    {
        public string Host { get; set; }

        public string Domain { get; set; }

        public List<string> Queries { get; set; }
    }

    public class Websites
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var websites = new List<Website>();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(new char[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var currentWebsite = new Website();

                if (tokens.Length > 2)
                {
                    currentWebsite = ReadWebsitesWithoutQueries(tokens);
                    websites.Add(currentWebsite);
                }
                else
                {
                    currentWebsite = ReadWensitesWithQueries(tokens);
                    websites.Add(currentWebsite);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var eachWebsite in websites)
            {
                var host = eachWebsite.Host;
                var domain = eachWebsite.Domain;

                if (eachWebsite.Queries != null)
                {
                    Console.Write($"https://www.{host}.{domain}/query?=");
                    Console.WriteLine("[" + string.Join("]&[", eachWebsite.Queries) + "]");
                }
                else
                {
                    Console.WriteLine($"https://www.{host}.{domain}");
                }

            }
        }

        public static Website ReadWensitesWithQueries(string[] tokens)
        {
            var currentWensite = new Website
            {
                Host = tokens[0],
                Domain = tokens[1]
            };

            return currentWensite;
        }

        public static Website ReadWebsitesWithoutQueries(string[] tokens)
        {
            var currentWebsite = new Website
            {
                Host = tokens[0],
                Domain = tokens[1],
                Queries = tokens.Skip(2).ToList()
            };

            return currentWebsite;
        }
    }
}
