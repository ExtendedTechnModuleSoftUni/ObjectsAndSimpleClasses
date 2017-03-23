namespace _03E.Animals
{
    using System;
    using System.Collections.Generic;

    public class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    public class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int IntelligenceQuotient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    public class Snake
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CrueltyCoefficient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }

    public class Animals
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            while (inputLine != "I'm your Huckleberry")
            {
                var tokens = inputLine.Split();

                if (tokens.Length > 2)
                {
                    var currentClassName = tokens[0];
                    var currentAnimalName = tokens[1];
                    var currentAnimalAge = int.Parse(tokens[2]);
                    var currentAnimalParameter = int.Parse(tokens[3]);

                    switch (currentClassName)
                    {
                        case "Dog":
                            dogs[currentAnimalName] = new Dog
                            {
                                Name = currentAnimalName,
                                Age = currentAnimalAge,
                                NumberOfLegs = currentAnimalParameter
                            };
                            break;
                        case "Cat":
                            cats[currentAnimalName] = new Cat
                            {
                                Name = currentAnimalName,
                                Age = currentAnimalAge,
                                IntelligenceQuotient = currentAnimalParameter
                            };
                            break;
                        case "Snake":
                            snakes[currentAnimalName] = new Snake
                            {
                                Name = currentAnimalName,
                                Age = currentAnimalAge,
                                CrueltyCoefficient = currentAnimalParameter
                            };
                            break;
                    }
                }
                else
                {
                    var animalName = tokens[1];

                    if (dogs.ContainsKey(animalName))
                    {
                        dogs[animalName].ProduceSound();
                    }
                    else if (cats.ContainsKey(animalName))
                    {
                        cats[animalName].ProduceSound();
                    }
                    else if (snakes.ContainsKey(animalName))
                    {
                        snakes[animalName].ProduceSound();
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var dog in dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
            foreach (var cat in cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }
            foreach (var snake in snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
}
