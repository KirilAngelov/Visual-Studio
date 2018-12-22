using System;

namespace FootbalFans
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            String category = Console.ReadLine();
            decimal people = decimal.Parse(Console.ReadLine());
            decimal razlika = 0;
            bool tickets = false;
            if (people <= 4)
            {

                money = money - ((money * 75) / 100);
                if (category == "VIP")
                {
                    if (tickets = (money > people * 499.99m))
                    {
                        tickets = true;

                        razlika = money - people * 499.99m;
                    }

                    else
                    {
                        razlika = (people * 499.99m) - money;

                    }
                }
                if (category == "Normal")
                {
                    if (tickets = (money > people * 249.99m))
                    {
                        tickets = true;

                        razlika = money - people * 249.99m;
                    }

                    else
                    {
                        razlika = (people * 249.99m) - money;

                    }
                }
            }
            if (people >= 5 && people <= 9)
            {

                money = money - ((money * 60) / 100);
                if (category == "VIP")
                {
                    if (tickets = (money > people * 499.99m))
                    {
                        tickets = true;

                        razlika = money - people * 499.99m;
                    }

                    else
                    {
                        razlika = (people * 499.99m) - money;

                    }
                }
                if (category == "Normal")
                {
                    if (tickets = (money > people * 249.99m))
                    {
                        tickets = true;

                        razlika = money - people * 249.99m;
                    }

                    else
                    {
                        razlika = (people * 249.99m) - money;

                    }
                }
            }
            if (people >= 10 && people <= 24)
            {

                money = money - ((money * 50) / 100);
                if (category == "VIP")
                {
                    if (tickets = (money > people * 499.99m))
                    {
                        tickets = true;

                        razlika = money - people * 499.99m;
                    }

                    else
                    {
                        razlika = (people * 499.99m) - money;

                    }
                }
                if (category == "Normal")
                {
                    if (tickets = (money > people * 249.99m))
                    {
                        tickets = true;

                        razlika = money - people * 249.99m;
                    }

                    else
                    {
                        razlika = (people * 249.99m) - money;

                    }
                }

            }
            if (people >= 25 && people <= 49)
            {

                money = money - ((money * 40) / 100);
                if (category == "VIP")
                {
                    if (tickets = (money > people * 499.99m))
                    {
                        tickets = true;

                        razlika = money - people * 499.99m;
                    }

                    else
                    {
                        razlika = (people * 499.99m) - money;

                    }
                }
                if (category == "Normal")
                {
                    if (tickets = (money > people * 249.99m))
                    {
                        tickets = true;

                        razlika = money - people * 249.99m;
                    }

                    else
                    {
                        razlika = (people * 249.99m) - money;

                    }
                }

            }
            if (people >= 50)
            {

                money = money - ((money * 25) / 100);
                if (category == "VIP")
                {
                    if (tickets = (money > people * 499.99m))
                    {
                        tickets = true;

                        razlika = money - people * 499.99m;
                    }

                    else
                    {
                        razlika = (people * 499.99m) - money;

                    }
                }
                if (category == "Normal")
                {
                    if (tickets = (money > people * 249.99m))
                    {
                        tickets = true;

                        razlika = money - people * 249.99m;
                    }

                    else
                    {
                        razlika = (people * 249.99m) - money;

                    }
                }

            }
            if (tickets == true)
            {
                Console.WriteLine($"Yes money left {razlika}");
            }
            else
            {
                Console.WriteLine($"Not enough you need {Math.Abs(razlika)}");
            }
        }

    }
}
