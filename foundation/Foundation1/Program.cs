using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Video #1\n");
        var video1 = new Video("broCode", "Programming with Classes", 750);
        video1.AddComment("Gem", "Helpful");
        video1.AddComment("Mel", "Nice video");
        video1.AddComment("Shy", "Wonderful!");
        video1.AddComment("Gil", "lorem10");

        video1.DisplayAll();
        System.Console.WriteLine("Video #2\n");

        var video2 = new Video("broCode", "Programming with Classes", 750);
        video2.AddComment("Gem", "Helpful");
        video2.AddComment("Mel", "Nice video");
        video2.AddComment("Shy", "Wonderful!");
        video2.AddComment("Gil", "lorem10");

        video2.DisplayAll();

        System.Console.WriteLine("Video #3\n");
        var video3 = new Video("broCode", "Programming with Classes", 750);
        video3.AddComment("Gem", "Helpful");
        video3.AddComment("Mel", "Nice video");
        video3.AddComment("Shy", "Wonderful!");
        video3.AddComment("Gil", "lorem10");

        video3.DisplayAll();

        System.Console.WriteLine("Video #4\n");
        var video4 = new Video("broCode", "Programming with Classes", 750);
        video4.AddComment("Gem", "Helpful");
        video4.AddComment("Mel", "Nice video");
        video4.AddComment("Shy", "Wonderful!");
        video4.AddComment("Gil", "lorem10");

        video4.DisplayAll();

        
    }
}