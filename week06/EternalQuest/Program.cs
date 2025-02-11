using System;
using System.IO;
using System.IO.Enumeration;

class Program
{
    static string filename = "";
    static int totalScore = 0;
    static List<Goal> goals = new List<Goal>();
    static List<string> achievements = new List<string>();
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

            //LoadData();

            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                int level = (totalScore / 1000) + 1;
                Console.WriteLine($"You have {totalScore} points   |   Level: {level}");
                if (achievements.Count > 0)
                {
                    Console.WriteLine("Achievements Unlocked: " + string.Join(", ", achievements));
                }
                else
                {
                    Console.WriteLine("No achievements unlocked yet.");
                }
                Console.Clear();
                
                Console.WriteLine($"You have {totalScore} points");
                Console.WriteLine("Menu Options: ");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. Record an Event");
                Console.WriteLine("3. Display Goals");
                Console.WriteLine("4. Save Data");
                Console.WriteLine("5. Load Data");
                Console.WriteLine("6. Exit");
                Console.Write("Select a choice from menu: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        CreateNewGoal();
                        break;
                    case "2":
                        RecordEvent();
                        break;
                    case "3":
                        DisplayGoals();
                        break;
                    case "4":
                        SaveData();
                        break;
                    case "5":
                        LoadData();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }

        static void CreateNewGoal()
        {
            Console.WriteLine("Select Goal Type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create?: ");
            string typeChoice = Console.ReadLine();

            Console.Write("Whats the name of your Goal: ");
            string name = Console.ReadLine();
            Console.Write("Enter Goal Description: ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this Goal?: ");
            int points = int.Parse(Console.ReadLine());

            Goal newGoal = null;
            switch (typeChoice)
            {
                case "1":
                    newGoal = new SimpleGoal(name, description, points);
                    break;
                case "2":
                    newGoal = new EternalGoal(name, description, points);
                    break;
                case "3":
                    Console.Write("Enter number of completions required: ");
                    int requiredCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points on completion: ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    newGoal = new ChecklistGoal(name, description, points, requiredCount, bonusPoints);
                    break;
                default:
                    Console.WriteLine("Invalid goal type selected.");
                    return;
            }
            goals.Add(newGoal);
            Console.WriteLine("Goal created successfully!");
        }

        static void RecordEvent()
        {
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals available to record an event.");
                return;
            }

            Console.WriteLine("Select a goal to record an event:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].DisplayGoals()}");
            }
            Console.Write("Which goal did you accomplish?: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index < 0 || index >= goals.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }
            int earned = goals[index].RecordEvent();
            totalScore += earned;
            Console.WriteLine($"Event recorded! Points earned: {earned}");

            UpdateAchievements();
        }

        static void DisplayGoals()
        {
            Console.WriteLine("Your Goals are:");
            foreach (Goal goal in goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        static void SaveData()
        {
            try
            {
                Console.WriteLine("What is the file name?");
                filename = Console.ReadLine();
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(totalScore);
                    foreach (Goal goal in goals)
                    {
                        writer.WriteLine(goal.Serialize());
                    }
                }
                Console.WriteLine("Data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
            }
        }

        static void LoadData()
        {
            if (string.IsNullOrWhiteSpace(filename))
    {
                Console.WriteLine("Enter the file name to load data:");
                filename = Console.ReadLine();
    }
            if (!File.Exists(filename))
            {
                Console.WriteLine("No saved data found.");
                return;
            }
            try
            {
                string[] lines = File.ReadAllLines(filename);
                if (lines.Length > 0)
                {
                    totalScore = int.Parse(lines[0]);
                    goals.Clear();
                    for (int i = 1; i < lines.Length; i++)
                    {
                        Goal goal = Goal.Deserialize(lines[i]);
                        goals.Add(goal);
                    }
                }
                Console.WriteLine("Data loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
            }
        }

        static void UpdateAchievements()
        {
            if (totalScore >= 200 && !achievements.Contains("200 Points Achievement"))
            {
                achievements.Add("200 Points Achievement");
                Console.WriteLine("Achievement Unlocked: 200 Points!");
            }
            if (totalScore >= 500 && !achievements.Contains("500 Points Achievement"))
            {
                achievements.Add("500 Points Achievement");
                Console.WriteLine("Achievement Unlocked: 500 Points!");
            }
            if (totalScore >= 1000 && !achievements.Contains("1000 Points Achievement"))
            {
                achievements.Add("1000 Points Achievement");
                Console.WriteLine("Achievement Unlocked: 1000 Points!");
            }
        }
    
}
