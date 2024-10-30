using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        // Menu system with options to manage goals
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.ShortName);
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.Write("Enter the number of your choice: ");
        
        string choice = Console.ReadLine();
        Goal newGoal = null;

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for achieving this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                // SimpleGoal
                newGoal = new SimpleGoal(name, description, points);
                break;
            
            case "2":
                // ChecklistGoal
                Console.Write("Enter the target number of completions: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing the checklist: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;

            case "3":
                // EternalGoal
                newGoal = new EternalGoal(name, description, points);
                break;
            
            default:
                Console.WriteLine("Invalid choice. Please select a valid goal type.");
                return; // Exit if the choice is invalid
        }

        _goals.Add(newGoal); // Add the created goal to the list
        Console.WriteLine($"Goal '{name}' has been created successfully.");
    }

    public void RecordEvent()
    {
            // Display the list of goals to the user
        Console.WriteLine("Select a goal to record an event for:");
        ListGoalNames(); // Assuming this method displays the names of the goals

        // Prompt user to select a goal by index
        Console.Write("Enter the number of the goal you want to record an event for: ");
        int goalIndex;
        
        // Validate user input
        if (int.TryParse(Console.ReadLine(), out goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            // Get the selected goal
            Goal selectedGoal = _goals[goalIndex - 1]; // Adjust for zero-based index

            // Record the event for the selected goal
            selectedGoal.RecordEvent(); // Assuming each Goal class has a RecordEvent method
            Console.WriteLine($"Event recorded for goal: {selectedGoal.ShortName}");
            
            // Increment the score if needed (for example, based on the goal's points)
            _score += selectedGoal.Points; // This will now work correctly
            Console.WriteLine($"Your current score is now: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid selection. Please select a valid goal.");
        }
    }

    public void SaveGoals()
    {
        try
        {
            // Prompt the user to enter the filename
            Console.Write("Enter the file name to save the goals (e.g., goals.txt): ");
            string file = Console.ReadLine(); // Get the file name from user input

            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var goal in _goals)
                {
                    // Use the GetStringRepresentation method to save each goal as a single line
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving goals: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        try
    {
        // Prompt the user to enter the filename
        Console.Write("Enter the file name to load the goals (e.g., goals.txt): ");
        string file = Console.ReadLine(); // Get the file name from user input

        if (File.Exists(file))
        {
            _goals.Clear(); // Clear the current list of goals before loading new ones

            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line data into parts
                    var parts = line.Split('|');
                    string goalType = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    Goal goal = null;

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(parts[4]);
                            goal = new SimpleGoal(name, description, points);
                            if (isComplete)
                            {
                                ((SimpleGoal)goal).RecordEvent(); // Mark as complete if necessary
                            }
                            break;

                        case "ChecklistGoal":
                            int amountCompleted = int.Parse(parts[4]);
                            int target = int.Parse(parts[5]);
                            int bonus = int.Parse(parts[6]);
                            goal = new ChecklistGoal(name, description, points, target, bonus);
                            ((ChecklistGoal)goal).AmountCompleted = amountCompleted; // Set completion count
                            break;

                        case "EternalGoal":
                            goal = new EternalGoal(name, description, points);
                            break;

                        default:
                            Console.WriteLine($"Unknown goal type: {goalType}");
                            continue; // Skip unknown goal types
                    }

                    _goals.Add(goal); // Add the goal to the list
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine($"File '{file}' not found.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while loading goals: {ex.Message}");
    }
    }
}
