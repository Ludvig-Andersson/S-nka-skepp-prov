using System;

namespace SänkaSkepp
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Välkommen till sänka skepp!!");
            System.Console.WriteLine("Välj ett nummer mellan 1-10");
            string svar1 = Console.ReadLine();


            if (svar1 == "10")
            {
                System.Console.WriteLine("Hit!");
            }

            else if (svar1 == "9")
            {
                System.Console.WriteLine("Near hit!");
            }

            else if (svar1 == "8")
            {
                System.Console.WriteLine("Near hit!");
            }

            else if (svar1 == "7")
            {
                System.Console.WriteLine("Miss!");
            }

            else if (svar1 == "6")
            {
                System.Console.WriteLine("Miss!");
            }

            else if (svar1 == "5")
            {
                System.Console.WriteLine("Miss!");
            }

            else if (svar1 == "4")
            {
                System.Console.WriteLine("Miss!");
            }

            else if (svar1 == "3")
            {
                System.Console.WriteLine("Miss!");
            }

            else if (svar1 == "2")
            {
                System.Console.WriteLine("Miss!");
            }

            else if (svar1 == "1")
            {
                System.Console.WriteLine("Miss!");
            }

            else
            {
                System.Console.WriteLine("Du skrev inte in något nummer mellan 1-10");
                System.Console.WriteLine("Vill du börja om? ja eller nej");
                string svar2 = Console.ReadLine();

                if (svar2 == "nej")
                {
                    Environment.Exit(0);
                }

                if (svar2 == "ja")
                {

                    Console.Clear();
                    Console.WriteLine("Välkommen till sänka skepp!!");
                    System.Console.WriteLine("Välj ett nummer mellan 1-10");
                    string svar11 = Console.ReadLine();


                    if (svar11 == "10")
                    {
                        System.Console.WriteLine("Hit!");
                    }

                    else if (svar11 == "9")
                    {
                        System.Console.WriteLine("Near hit!");
                    }

                    else if (svar11 == "8")
                    {
                        System.Console.WriteLine("Near hit!");
                    }

                    else if (svar11 == "7")
                    {
                        System.Console.WriteLine("Miss!");
                    }

                    else if (svar11 == "6")
                    {
                        System.Console.WriteLine("Miss!");
                    }

                    else if (svar11 == "5")
                    {
                        System.Console.WriteLine("Miss!");
                    }

                    else if (svar11 == "4")
                    {
                        System.Console.WriteLine("Miss!");
                    }

                    else if (svar11 == "3")
                    {
                        System.Console.WriteLine("Miss!");
                    }

                    else if (svar11 == "2")
                    {
                        System.Console.WriteLine("Miss!");
                    }

                    else if (svar11 == "1")
                    {
                        System.Console.WriteLine("Miss!");
                    }

                    else
                    {
                        System.Console.WriteLine("Du skrev inte in något nummer mellan 1-10");
                        System.Console.WriteLine("Vill du börja om? ja eller nej");
                        string svar22 = Console.ReadLine();

                        if (svar22 == "nej")
                        {
                            Environment.Exit(0);
                        }

                        if (svar22 == "ja")
                        {

                        }
                    }

                }
            }

        }
    }
}
