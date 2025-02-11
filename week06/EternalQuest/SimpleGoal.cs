class SimpleGoal : Goal
{
    private bool isCompleted;
    public SimpleGoal(string Name, string Description, int Points, bool IsCompleted=false) : base(Name, Description, Points) {
        name = Name;
        description = Description;
        points = Points;
        isCompleted = IsCompleted;
     }

    public override int RecordEvent()
    {
         if (!isCompleted)
            {
                isCompleted = true;
                return points;
            }
            else
            {
                Console.WriteLine("This goal is already complete.");
                return 0;
            }
    }

    public override bool IsCompleted()
    {
        return true;
    }
    
    public override string GetDetailsString()
    {
        string status = IsCompleted()  ? "[X]" : "[ ]";
        return $"1. {status} {name} ({description}) ";
    }

    public override string DisplayGoals(){
        return $"{name}";
    }

    public override string Serialize()
        {
            // Format: SimpleGoal|Name|Description|Points|isComplete
            return $"SimpleGoal|{name}|{description}|{points}|{isCompleted}";
        }
}
