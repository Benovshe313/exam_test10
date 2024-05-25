namespace Exam10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] question1 = new string[]
            {
                "1. Capital of Austria is ...",
                "a. Vienna",
                "b. Bern",
                "c. Dublin"
            };

            string[] question2 = new string[]
            {
                "2. Select a European country:",
                "a. Malaysia",
                "b. Jordan",
                "c. Norway"
            };

            string[] question3 = new string[]
            {
                "3. Capital of Denmark is ...",
                "a. Stockholm",
                "b. Copenhagen",
                "c. Warsaw"
            };

            string[] question4 = new string[]
            {
                "4. Niagara waterfall in ...",
                "a. South America",
                "b. North America",
                "c. Africa"
            };

            string[] question5 = new string[]
            {
                "5. Capital of Germany is ...",
                "a. Budapest",
                "b. Berlin",
                "c. Tallinn"
            };

            string[] question6 = new string[]
            {
                "6. Red Square in ...",
                "a. India",
                "b. Japan",
                "c. Russia"
            };

            string[] question7 = new string[]
            {
                "7. Maiden Tower in ...",
                "a. Baku",
                "b. Shirvan",
                "c. Ganja"
            };

            string[] question8 = new string[]
            {
                "8. City in the United Arab Emirates:",
                "a. Amsterdam",
                "b. Barcelona",
                "c. Dubai"
            };

            string[] question9 = new string[]
            {
                "9. UK famous for:",
                "a. London Eye",
                "b. Eiffel Tower",
                "c. Old City"
            };

            string[] question10 = new string[]
            {
                "10. Flame Towers located in ...",
                "a. Kazakhstan",
                "b. Georgia",
                "c. Azerbaijan"
            };

            string[][] Questions = new string[][]
            {
                question1,
                question2,
                question3,
                question4,
                question5,
                question6,
                question7,
                question8,
                question9,
                question10
            };

            string[] Answers = new string[]
            {
                "a",
                "c",
                "b",
                "b",
                "b",
                "c",
                "a",
                "c",
                "a",
                "c"
            };

            Random variants = new Random();
            int score = 0;
            for (int a = 0; a < Questions.Length; a++)
            {
                var question = Questions[a];
                for (int i = 1; i < question.Length; i++)
                {
                    int j = variants.Next(i, question.Length);
                    string temp = question[i];
                    question[i] = question[j];
                    question[j] = temp;
                }
                Thread.Sleep(400);
                Console.Clear();

                Console.WriteLine(question[0]);
                for (int i = 1; i < question.Length; i++)
                {
                    Console.WriteLine(question[i]);
                }

                string userAnswer = GetUserAnswer();

                bool isCorrect = userAnswer == Answers[a];
                if (isCorrect)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    score += 10;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    score -= 10;
                }
                Console.Clear();
                if (isCorrect)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine(question[0]);
                Console.ResetColor();
                for (int i = 1; i < question.Length; i++)
                {
                    Console.WriteLine(question[i]);
                }
            }

            if (score < 0)
            {
                Console.WriteLine("Final Score: " + "0");
            }
            else
            {
                Console.WriteLine("Final Score: " + score);
            }

        }

        static string GetUserAnswer()
        {
            while (true)
            {
                Console.Write("Answer: ");
                string userInput = Console.ReadLine().Trim().ToLower();
                if (userInput == "a" || userInput == "b" || userInput == "c")
                {
                    return userInput;
                }
                Console.WriteLine("Invalid input");
            }
        }
    }
}
