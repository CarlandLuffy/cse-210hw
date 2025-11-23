using System;

namespace Develop05
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("==== Eternal Quest ====");
                Console.WriteLine("Current score: " + manager.GetScore() + " points");
                Console.WriteLine("Current level: " + manager.GetLevel());
                Console.WriteLine();

                Console.WriteLine("Menu Options:");
                Console.WriteLine(" 1. Create new goal");
                Console.WriteLine(" 2. List goals");
                Console.WriteLine(" 3. Save goals");
                Console.WriteLine(" 4. Load goals");
                Console.WriteLine(" 5. Record event");
                Console.WriteLine(" 6. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    CreateGoalMenu(manager);
                }
                else if (choice == "2")
                {
                    manager.ListGoals();
                }
                else if (choice == "3")
                {
                    Console.Write("Enter filename to save (for example goals.txt): ");
                    string filename = Console.ReadLine();
                    manager.SaveToFile(filename);
                }
                else if (choice == "4")
                {
                    Console.Write("Enter filename to load (for example goals.txt): ");
                    string filename = Console.ReadLine();
                    manager.LoadFromFile(filename);
                }
                else if (choice == "5")
                {
                    manager.RecordEventOnGoal();
                }
                else if (choice == "6")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Please choose a valid option.");
                }
            }

            Console.WriteLine("Goodbye. Keep working on your eternal quest!");
        }

        private static void CreateGoalMenu(GoalManager manager)
        {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            Console.WriteLine(" 4. Negative Goal (lose points for bad habits)");
            Console.Write("Which type of goal would you like to create? ");

            string typeChoice = Console.ReadLine();
            Console.WriteLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string pointsText = Console.ReadLine();
            int points = int.Parse(pointsText);

            if (typeChoice == "1")
            {
                SimpleGoal goal = new SimpleGoal(name, description, points);
                manager.AddGoal(goal);
            }
            else if (typeChoice == "2")
            {
                EternalGoal goal = new EternalGoal(name, description, points);
                manager.AddGoal(goal);
            }
            else if (typeChoice == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string targetText = Console.ReadLine();
                int targetCount = int.Parse(targetText);

                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonusText = Console.ReadLine();
                int bonusPoints = int.Parse(bonusText);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                manager.AddGoal(goal);
            }
            else if (typeChoice == "4")
            {
                Console.WriteLine("This goal will subtract points each time you record it.");
                NegativeGoal goal = new NegativeGoal(name, description, points);
                manager.AddGoal(goal);
            }
            else
            {
                Console.WriteLine("Unknown goal type. No goal created.");
            }
        }
    }
}
