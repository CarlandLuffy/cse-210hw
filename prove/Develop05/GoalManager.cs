using System;
using System.Collections.Generic;
using System.IO;

namespace Develop05
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public int GetScore()
        {
            return _score;
        }

        public int GetLevel()
        {
            int level = (_score / 1000) + 1;
            return level;
        }

        public void ListGoals()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals yet. Try creating one.");
                return;
            }

            Console.WriteLine("Your goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                int number = i + 1;
                Goal goal = _goals[i];
                Console.WriteLine(number.ToString() + ". " + goal.GetStatusString());
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
              
                outputFile.WriteLine(_score.ToString());

               
                for (int i = 0; i < _goals.Count; i++)
                {
                    Goal goal = _goals[i];
                    string line = goal.GetStringRepresentation();
                    outputFile.WriteLine(line);
                }
            }

            Console.WriteLine("Goals saved to " + filename);
        }

        public void LoadFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(filename);
            if (lines.Length == 0)
            {
                Console.WriteLine("File is empty.");
                return;
            }

            _goals.Clear();

           
            string scoreLine = lines[0];
            _score = int.Parse(scoreLine);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                if (line.Trim().Length == 0)
                {
                    continue;
                }

                string[] parts = line.Split('|');
                string type = parts[0];

                if (type == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (type == "ChecklistGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int current = int.Parse(parts[6]);
                    bool isComplete = bool.Parse(parts[7]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points,
                                                           target, bonus, current, isComplete);
                    _goals.Add(goal);
                }
                else if (type == "NegativeGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);

                    NegativeGoal goal = new NegativeGoal(name, description, points, isComplete);
                    _goals.Add(goal);
                }
            }

            Console.WriteLine("Goals loaded from " + filename);
        }

        public void RecordEventOnGoal()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals available. Create a goal first.");
                return;
            }

            Console.WriteLine("Which goal did you accomplish?");
            for (int i = 0; i < _goals.Count; i++)
            {
                int number = i + 1;
                Console.WriteLine(number.ToString() + ". " + _goals[i].GetName());
            }

            Console.Write("Enter the number of the goal: ");
            string input = Console.ReadLine();

            int index = int.Parse(input) - 1;

            if (index < 0 || index >= _goals.Count)
            {
                Console.WriteLine("That goal number does not exist.");
                return;
            }

            Goal goalToRecord = _goals[index];
            int pointsEarned = goalToRecord.RecordEvent();
            _score = _score + pointsEarned;

            if (pointsEarned > 0)
            {
                Console.WriteLine("You earned " + pointsEarned + " points!");
            }
            else if (pointsEarned < 0)
            {
                Console.WriteLine("You lost " + (-pointsEarned) + " points.");
            }
            else
            {
                Console.WriteLine("No points were added or removed.");
            }

            Console.WriteLine("Your new score is: " + _score);
        }
    }
}
