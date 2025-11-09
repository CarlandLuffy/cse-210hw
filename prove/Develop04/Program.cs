using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        bool loop = true;

        while (loop)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing b = new Breathing();
                b.Run();
                File.AppendAllText("log.txt", DateTime.Now.ToString("s") + " Breathing\n");
            }
            else if (choice == "2")
            {
                Reflection r = new Reflection();
                r.Run();
                File.AppendAllText("log.txt", DateTime.Now.ToString("s") + " Reflection\n");
            }
            else if (choice == "3")
            {
                Listing l = new Listing();
                l.Run();
                File.AppendAllText("log.txt", DateTime.Now.ToString("s") + " Listing\n");
            }
            else if (choice == "4")
            {
                loop = false;
            }
            else
            {
                Console.WriteLine("Please choose 1-4. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}
