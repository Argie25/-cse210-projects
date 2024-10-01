using System.Dynamic;

public class PromptGenerator

    {
        //Random prompt list
        public List<string> _prompts = new List<string>
        {
        "What inspires you the most?",
        "Describe your favorite childhood memory.",
        "What would you do if you had a million dollars?",
        "If you could travel anywhere, where would you go?",
        "What is your greatest accomplishment?"
        };

        public string GetRandomPrompt()
        {
            // Check if the list has any prompts
        if (_prompts.Count == 0)
        {
            return "No prompts available.";
        }

        // Generate a random index
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);

        // Return the prompt at the random index
        return _prompts[randomIndex];
        }
    }
    
    