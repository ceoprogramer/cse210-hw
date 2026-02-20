public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        // This method will be overridden in derived classes to record the event and update points accordingly.
        
    }
    public virtual bool IsComplete()
    {
        // This method will be overridden in derived classes to determine if the goal is complete.
        return false;
    }
        public virtual string GetShortName()
    {
        // This method will be overridden in derived classes to return a string  the goal's short name.
        return $"{_shortName}"; 
    }
    public virtual string GetDetailsString()
    {
        // This method will be overridden in derived classes to return a string representation of the goal's details.
        return $"{_shortName}: ({_description} )";
    }
    public virtual string GetstringRepresentation()
    {
        // This method will be overridden in derived classes to return a string representation of the goal for saving/loading purposes.
        return $"{_shortName},{_description},{_points}";
        
    }

    public int GetPoints()
    {
        return _points;
    }
}
