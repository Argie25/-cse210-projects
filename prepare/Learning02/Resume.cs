public class Resume
        {
            public string _name;
            public List<Job> _jobs = new List<Job>();
            
            public void Info()
            {
                Console.WriteLine($"Name: {_name}");
                Console.WriteLine($"Jobs:");

                foreach (Job job in _jobs)
                {
                    job.JobInfo();
                }
            }
        }