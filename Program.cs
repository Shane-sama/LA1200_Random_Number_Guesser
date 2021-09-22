using System;
using System.Threading;

namespace Random_number_guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string text0 = "Do you want to read the Dialogue?";
            foreach (char c in text0)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine("");
            Console.WriteLine("<Type yes to read, press enter to skip.>");
            string p = Console.ReadLine();
            string q = "yes";
            Console.Clear();

            if (p == q)
            {
                string text = "It's a beautiful day outside.";
                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(75);
                }
                Console.WriteLine("");
                Console.WriteLine("<press enter to continue>");
                Console.ReadLine();
                Console.Clear();

                string text2 = "Birds are singing, flowers are blooming...";
                foreach (char c in text2)
                {
                    Console.Write(c);
                    Thread.Sleep(75);
                }
                Console.WriteLine("");
                Console.WriteLine("<press enter to continue>");
                Console.ReadLine();
                Console.Clear();

                string text3 = "On days like these, kids like you...";
                foreach (char c in text3)
                {
                    Console.Write(c);
                    Thread.Sleep(90);
                }
                Console.WriteLine("");
                Console.WriteLine("<press enter to continue>");
                Console.ReadLine();
                Console.Clear();

                string text4 = "SHOULD BE BURNING IN HE-";
                foreach (char c in text4)
                {
                    Console.Write(c);
                    Thread.Sleep(150);
                }
                Console.WriteLine("");

                string text5 = "...";
                foreach (char c in text5)
                {
                    Console.Write(c);
                    Thread.Sleep(450);
                }
                Console.WriteLine("");
                Console.WriteLine("<press enter to continue>");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("");
                string text6 = "...";
                foreach (char c in text6)
                {
                    Console.Write(c);
                    Thread.Sleep(550);
                }
                Console.WriteLine("");
                Console.WriteLine("<press enter to continue>");
                Console.ReadLine();
                Console.Clear();

                string text7 = "...";
                foreach (char c in text7)
                {
                    Console.Write(c);
                    Thread.Sleep(700);
                }
                Console.WriteLine("");
                Console.WriteLine("<press enter to continue>");
                Console.ReadLine();
                Console.Clear();

                string text8 = "*cough";
                foreach (char c in text8)
                {
                    Console.Write(c);
                    Thread.Sleep(50);
                }
                Console.WriteLine("");
                Console.WriteLine("<press enter to continue>");
                Console.ReadLine();
                Console.Clear();

                string text9 = "Oh, sorry kid, I seemingly mixed you up...";
                foreach (char c in text9)
                {
                    Console.Write(c);
                    Thread.Sleep(75);
                }
                Console.WriteLine("");
                Console.WriteLine("<press enter to continue>");
                Console.ReadLine();
                Console.Clear();
            }

            string text10 = "I guess you're here to guess some numbers?";
            foreach (char c in text10)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
            Console.WriteLine("");
            Console.WriteLine("<press enter to continue>");
            Console.ReadLine();
            Console.Clear();

            int k = -1;

            label1:
            int ü = -1;
            string[] NoU = { "Stop it kid, only numbers from 1 to 100!",
                    "Already told you, only numbers from 1 to 100!", 
                    "You didn't understand me? Only numbers from 1 to 100!", 
                    "Listen kid, you dont have to go too crazy with this, just use numbers from 1 to 100!", 
                    "Seriously, 5 times? C'mon kid, play this game like it's supposed to be played! ", 
                    "Welp, you didn't want to listen!" };
            int tries = 0;
            int x = new Random().Next(1, 100);
            int guess = 0;

            if (k <= 4)
            {
                k++;
            }
            string[] j = { "Make a first guess!",
            "Second round, here we go!",
            "You really like this game, don't you, kid?",
            "We're gonna be here all day? I'm in!",
            "Make your guess, kid!",};
            string text11 = j[k];
            foreach (char c in text11)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
            Console.WriteLine("");
            while (guess != x)
            {
                try
                {
                    Console.WriteLine("<type in a number from 1 to 100>");
                    guess = Convert.ToInt32(Console.ReadLine());
                    if(guess < 0 || guess > 100)
                    {
                        throw new Exception(); 
                    }

                    if (guess == x)
                    {
                        string text12 = "Good job, you actually got it!";
                        foreach (char c in text12)
                        {
                            Console.Write(c);
                            Thread.Sleep(75);
                        }
                        Console.WriteLine("");
                        string text13 = "Only took you " + tries + " tries";
                        foreach (char c in text13)
                        {
                            Console.Write(c);
                            Thread.Sleep(75);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("<press enter to continue>");
                        Console.Clear();

                        string text18 = "Wanna go again?";
                        foreach (char c in text18)
                        {
                            Console.Write(c);
                            Thread.Sleep(75);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("<Type yes to go again, press enter to end program.>");
                        string n = Console.ReadLine();
                        string m = "yes";
                        Console.Clear();
                        if (n == m)
                        {
                            goto label1;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        if (guess > x)
                        {
                            tries++;

                            string[] TooBig = { "I think you're overestimating the size of the number.",
                                "Too Big, go lower!",
                                "C'mon kid, i know you can think smaller!",
                                "What's the difference between quantums and your guess? Quantums aren't big!",
                                "You gotta think smaller, kid!",};
                            int ö = new Random().Next(0, 4);

                            string text14 = TooBig[ö];
                            foreach (char c in text14)
                            {
                                Console.Write(c);
                                Thread.Sleep(40);
                            }
                            Console.WriteLine("");
                            string text15 = "Try again!";
                            foreach (char c in text15)
                            {
                                Console.Write(c);
                                Thread.Sleep(40);
                            }
                            Console.WriteLine("");
                        }
                        else 
                        {
                            if (guess < x)
                            {
                                tries++;

                                string[] TooLow = { "Too Low, next time go higher!",
                                "I know your brain is able to think bigger!",
                                "My brother Papyrus is taller then I, your guesses should be able to reach further up too!",
                                "Think Big, kid!",
                                "You're thinking too low, kid, you can go way higher than this!",};
                                int ä = new Random().Next(0, 4);

                                string text16 = TooLow[ä];
                                foreach (char c in text16)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(40);
                                }
                                Console.WriteLine("");
                                string text17 = "Try again!";
                                foreach (char c in text17)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(40);
                                }
                                Console.WriteLine("");
                            }
                        }
                    }
                }
                catch
                {
                    ü++;
                    string text17 = NoU[ü];
                    foreach (char c in text17)
                    {
                        Console.Write(c);
                        Thread.Sleep(50);
                    }
                    Console.WriteLine("");

                    if (ü == 5)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
