public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    
    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Progress: {_amountCompleted}/{_target}";
    }   
    public override string GetstringRepresentation()
    {
        return $"Checklist,{base.GetstringRepresentation()},{_amountCompleted},{_target},{_bonus}";
    }
    public int GetBonusPoints()
    {
        if (IsComplete())
        {
            return _bonus;
        }
        return 0;
    }
}