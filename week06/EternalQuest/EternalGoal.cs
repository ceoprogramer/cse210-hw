public class EternalGoal : Goal
{
    private int _currentPoints;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _currentPoints = 0;
    }

    public override void RecordEvent()
    {
    
        _currentPoints += GetPoints();
    }

    public override bool IsComplete()
    {
        // Eternal goals are never complete, so this always returns false.
        return false;
    }

   
    public override string GetstringRepresentation()
    {
        return $"Eternal,{base.GetstringRepresentation()},{_currentPoints}";
    }
}
