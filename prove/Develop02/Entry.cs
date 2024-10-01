public class Entry
    {
        public string _date;
        public string _promptText;
        public string _entryText;   
        public PromptGenerator promptGenerator;
        public void Display()
        {
            // Display the entry's date, prompt, and text
            Console.WriteLine($"{_date} {_promptText} {_entryText}");

        }
    }

