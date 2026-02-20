using System;
class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start() 
    {
        // This method will contain the main loop of the program, allowing the user to interact with the goal manager.
    }

    public void DisplayPlayerInfo()
    {
        // This method will display the player's current score and the list of goals with their completion status.
        Console.WriteLine($"The goals are:");
        for (int i = 0; i < _goals.Count; i++)        {
            string completionStatus = _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {completionStatus} {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalNames()
    {
        // This method will display the names of the goals to the user, allowing them to select a goal for recording an event.
        for (int i = 0; i < _goals.Count; i++)        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");

        }
    }
   
    public void ListGoalDetails()
    {
        // This method will display the list of goals to the user, along with their details and completion status.
        for (int i = 0; i < _goals.Count; i++)        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
     public void CreateGoal()
    {
        // This method will allow the user to create a new goal and add it to the list of goals.
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                // Code to create a Simple Goal
                Console.Write("Enter the name of the goal: ");
                string name = Console.ReadLine();
                Console.Write("Enter a description of the goal: ");
                string description = Console.ReadLine();
                Console.Write("Enter the points for completing the goal: ");
                int points = int.Parse(Console.ReadLine());
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);

                break;
            case "2":
                // Code to create an Eternal Goal
                Console.Write("Enter the name of the goal: ");
                string eternalName = Console.ReadLine();
                Console.Write("Enter a description of the goal: ");
                string eternalDescription = Console.ReadLine();
                Console.Write("Enter the points for completing the goal: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                EternalGoal eternalGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints);
                _goals.Add(eternalGoal);
                break;
            case "3":
                // Code to create a Checklist Goal
                Console.Write("What is the name Of your goal?: ");
                string checklistName = Console.ReadLine();
                Console.Write("What is a short description of it?: ");
                string checklistDescription = Console.ReadLine();
                Console.Write("What is the acount of points associated with this goal?: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int checklistTarget = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times?: ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(checklistName, checklistDescription, checklistPoints, 0, checklistTarget, bonus);
                _goals.Add(checklistGoal);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                CreateGoal();
                break;
        }
    }

    public void RecordEvent()
    {
        // This method will allow the user to record an event for a specific goal, updating the score and goal status accordingly.
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Select a goal to record an event for: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice >= 1 && choice <= _goals.Count)
        {
            Goal selectedGoal = _goals[choice - 1];
            selectedGoal.RecordEvent();
            _score += selectedGoal.GetPoints();
            if (selectedGoal.IsComplete()&& selectedGoal is ChecklistGoal checklistGoal)
            {
                 checklistGoal = (ChecklistGoal)selectedGoal;
                _score += checklistGoal.GetBonusPoints();
            }
            Console.WriteLine($"You have earned {selectedGoal.GetPoints()} points! Your total score is now {_score}.");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            RecordEvent();
        }


    }
    public void SaveGoals()
    {
        // This method will save the current list of goals and the score to a file.
        string filePath = "";
        Console.Write("Enter the file path to save the goals: ");
        filePath = Console.ReadLine();
       
            using (StreamWriter writer = new StreamWriter(filePath)){
                writer.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetstringRepresentation());
                        //Console.Write(goal.GetstringRepresentation());
                }
            }
    }
    
    public void LoadGoals()
    {
        // This method will load the list of goals and the score from a file, allowing the user to continue where they left off.
        string filePath = "";
        Console.Write("Enter the file path to load the goals: ");
        filePath = Console.ReadLine();
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string goalType = parts[0];
                    switch (goalType)
                    {
                        case "Simple":
                            SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                            _goals.Add(simpleGoal);
                            break;
                        case "Eternal":
                            EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                            _goals.Add(eternalGoal);
                            break;
                        case "Checklist":
                            ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found. Please try again.");
        }

    }

    public int GetScore()
    {
        return _score;
    }
}