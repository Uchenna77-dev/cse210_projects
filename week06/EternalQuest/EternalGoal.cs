using System.Drawing;

class EternalGoal : Goal
{
    public EternalGoal(string Name, string Description, int Points) : base(Name,  Description, Points)
        {
            name = Name;
            description = Description;
            points = Points;
        }


    public override bool IsCompleted()
    {
        return false;
    }
    public override int RecordEvent()
        {
            // Always award the same number of points
            return points;
        }

    public override string GetDetailsString()
    {
        return $"2. [∞] {name} ({description})";
    }

    public override string DisplayGoals(){
        return $"{name}";
    }

    public override string Serialize()
    {
        // Format: EternalGoal|Name|Description|Points
        return $"EternalGoal|{name}|{description}|{points}";
    }
    }
    