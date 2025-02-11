class ChecklistGoal : Goal
{
        private int completedCount;
        private int requiredCount;
        private int bonusPoints;

        public ChecklistGoal(string Name, string Description, int Points, int ReqiuredCount, int BonusPoints, int CompletedCount = 0) : base(Name, Description, Points)
        {
            name = Name;
            description = Description;
            points = Points;
            requiredCount = ReqiuredCount;
            bonusPoints = BonusPoints;
            completedCount = CompletedCount;
        }

    public override bool IsCompleted()
    {
        return false;
    }
    public override int RecordEvent()
        {
            completedCount++;
            int earned = points;
            if (completedCount >= requiredCount)
            {
                earned += bonusPoints;
                Console.WriteLine("Checklist goal complete! Bonus awarded.");
            }
            return earned;
        }

        public override string GetDetailsString()
        {
            string status = completedCount >= requiredCount ? "[X]" : "[ ]";
            return $"3. {status} {name} ({description}) -- Currently Completed {completedCount}/{requiredCount} times";
        }

        public override string DisplayGoals(){
        return $"{name}";
    }

        public override string Serialize()
        {
            // Format: ChecklistGoal|Name|Description|Points|targetCount|bonusPoints|timesCompleted
            return $"ChecklistGoal|{name}|{description}|{points}|{requiredCount}|{bonusPoints}|{completedCount}";
        }
    }

