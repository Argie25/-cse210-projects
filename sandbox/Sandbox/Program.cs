using System;

    public class Person
    {
        public string Name;
        
        public void Introduce(string to)
        {
            Console.WriteLine("Hi{0}, I am {1}", to, Name);
        }
    }

    public class Job
    {
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        public void JobInfo(string to)
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }

    public class Resume
        {
            public string _name;
            public List<Job> _jobs;
            
            public void Info(string to)
            {
                Console.WriteLine($"Name: {_name} Jobs: {_jobs}");
            }
        }
        
class Program
{


    static void Main(string[] args)
    {
        var person = new Person();
        person.Name = "Josh";
        person.Introduce("Mosh");
    }
}