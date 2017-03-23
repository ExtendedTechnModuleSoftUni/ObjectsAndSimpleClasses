namespace _06E.Messages
{
    using System;
    using System.Collections.Generic;

    public class User
    {
        public string UserName { get; set; }

        public List<string> ReceivedMessages { get; set; }
    }

    public class Message
    {
        public List<string> Content { get; set; }

        public string Sender { get; set; }
    }

    public class Messages
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var senderDict = new Dictionary<string, Message>();
            var registeredUsers = new List<string>();

            while (inputLine != "exit")
            {
                var tokens = inputLine.Split();

                if (tokens.Length < 3)
                {
                    registeredUsers.Add(tokens[1]);
                }
                else
                {
                    var senderName = tokens[0];
                    var currentContent = tokens[3];
                    var recipientName = tokens[2];
                    var recepientUser = new User();
                    var senderUser = new Message();

                    if (registeredUsers.Contains(senderName) && registeredUsers.Contains(recipientName))
                    {
                        if (!senderDict.ContainsKey(senderName))
                        {
                            senderUser.Sender = senderName;
                            senderUser.Content = new List<string>();
                            senderDict.Add(senderUser.Sender, senderUser);
                        }
                        if (!senderDict.ContainsKey(recipientName))
                        {
                            var tempMessage = new Message { Sender = recipientName, Content = new List<string>() };
                            senderDict.Add(tempMessage.Sender, tempMessage);
                        }

                        senderDict[senderName].Content.Add(currentContent);
                    }
                }

                inputLine = Console.ReadLine();
            }

            var users = Console.ReadLine().Split();
            var firstUser = users[0];
            var secondUser = users[1];
            var isAnyMessage = false;

            if (senderDict.ContainsKey(firstUser) && senderDict.ContainsKey(secondUser))
            {
                var max = Math.Max(senderDict[firstUser].Content.Count, senderDict[secondUser].Content.Count);
                var firstUserCount = senderDict[firstUser].Content.Count;
                var secondUserCount = senderDict[secondUser].Content.Count;

                for (int i = 0; i < max; i++)
                {
                    if (senderDict.ContainsKey(firstUser) && firstUserCount > 0)
                    {
                        Console.WriteLine($"{senderDict[firstUser].Sender}: {senderDict[firstUser].Content[i]}");
                        isAnyMessage = true;
                    }
                    if (senderDict.ContainsKey(secondUser) && secondUserCount > 0)
                    {
                        Console.WriteLine($"{senderDict[secondUser].Content[i]} :{senderDict[secondUser].Sender}");
                        isAnyMessage = true;
                    }

                    firstUserCount--;
                    secondUserCount--;
                }
            }

            if (!isAnyMessage)
            {
                Console.WriteLine("No messages");
            }
        }
    }
}
