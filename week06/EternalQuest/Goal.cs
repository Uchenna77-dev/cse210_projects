abstract class Goal
{
    protected string name;
    protected int points;
    protected string description;

    public Goal(string Name, string Description, int Points)
    {
        name = Name;
        description = Description;
        points = Points;
        
    }

    public abstract int RecordEvent();

    public abstract bool IsCompleted();

    public virtual string GetDetailsString()
    {
        return $"{name} ({description})";
    }

    public virtual string DisplayGoals(){
        return $"{name}";
    }

    // Used for saving the goal to a file.
    public abstract string Serialize();

    // Factory method to create a Goal from a saved string.
    public static Goal Deserialize(string data)
    {
        // Data format: Type|Name|Description|Points|other fields...
        string[] parts = data.Split('|');
        string type = parts[0];
        switch (type)
        {
            case "SimpleGoal":
                // Format: SimpleGoal|Name|Description|Points|isComplete
                return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
            case "EternalGoal":
                // Format: EternalGoal|Name|Description|Points
                return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            case "ChecklistGoal":
                // Format: ChecklistGoal|Name|Description|Points|targetCount|bonusPoints|timesCompleted
                return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]),
                                         int.Parse(parts[5]), int.Parse(parts[6]));
            default:
                throw new Exception("Unknown goal type");
        }
    }
}
