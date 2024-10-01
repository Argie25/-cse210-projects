using System.IO;
using System.Threading.Tasks.Dataflow;

public class Journal

    {
        public List<Entry> _entries;
        public PromptGenerator promptGenerator;

        public Journal()
        {
            _entries = new List<Entry>();
            promptGenerator = new PromptGenerator();
        }
        public void AddEntry(Entry newEntry)
        {
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            string prompt = promptGenerator.GetRandomPrompt();
            Console.Write($"{prompt} > ");
            string content = Console.ReadLine();

            // Populate the newEntry object
            newEntry._date = date;
            newEntry._promptText = prompt;
            newEntry._entryText = content;

            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            foreach (var entry in _entries)
            {
                Console.WriteLine($"Date: {entry._date}");
                Console.WriteLine($"Prompt: {entry._promptText}");
                Console.WriteLine($"Entry: {entry._entryText}");
                Console.WriteLine("-----------------------------");
            }
        }

        public void SaveToFile(string file)
        {
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    // Save each entry in the format: date|promptText|entryText
                    outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
        }

        public void LoadFromFile(string file)
        {
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };
                _entries.Add(entry);
            }
        }
    }