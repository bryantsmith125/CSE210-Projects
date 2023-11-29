using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Foundation Program 1 - Abstraction with YouTube Videos\n");
        Console.Write("------------------------------------------------------\n");
        Console.WriteLine("(Abstraction: The process of turning complex ideas into simple ones.)\n");


        Comment comment1 = new Comment();
        comment1._name = "Nick Fury";
        comment1._commentText = "Nice to see you are blowing off my calls for this...";
        Comment comment2 = new Comment();
        comment2._name = "Thor of Asguard";
        comment2._commentText = "If you want to see real talent, check out my channel!";
        Comment comment3 = new Comment();
        comment3._name = "Steve Rogers";
        comment3._commentText = "Language!";
        Comment comment4 = new Comment();
        comment4._name = "Pepper Potts";
        comment4._commentText = "I thought you were at a business meeting!";
        Comment comment5 = new Comment();
        comment5._name = "Shuri";
        comment5._commentText = "I need to make some modifications to your suit.";
        Comment comment6 = new Comment();
        comment6._name = "Eric Killmonger";
        comment6._commentText = "I'm coming back to take what's mine cuz!";
        Comment comment7 = new Comment();
        comment7._name = "M'Baku";
        comment7._commentText = "Why do we leave the fate of Wakanda to T'Challa? He will lead us to ruin!";
        Comment comment8 = new Comment();
        comment8._name = "Black Widow";
        comment8._commentText = "Hey big guy. The sun is getting real low.";
        Comment comment9 = new Comment();
        comment9._name = "Tony Stark";
        comment9._commentText = "I must say, I am a huge fan of your work! Especially when you turn into a big green rage monster!";
        Comment comment10 = new Comment();
        comment10._name = "Loki";
        comment10._commentText = "Enough! I am a god. I will not be bullied by the likes of you!";
        Comment comment11 = new Comment();
        comment11._name = "Abomination";
        comment11._commentText = "I could do it better.";
        Comment comment12 = new Comment();
        comment12._name = "Thor of Asguard";
        comment12._commentText = "I am still the strongest Avenger!";

        Video video1 = new Video();
        video1._title = "I am Ironman";
        video1._author = "Tony Stark";
        video1._videoLength = 42;
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        video1._comments.Add(comment4);
        

        Video video2 = new Video();
        video2._title = "Wakanda Forever";
        video2._author = "T'Challa Udaku";
        video2._videoLength = 37;
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        video2._comments.Add(comment7);
        

        Video video3 = new Video();
        video3._title = "Hulk Smash";
        video3._author = "Dr. Bruce Banner";
        video3._videoLength = 112;
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);
        video3._comments.Add(comment11);
        video3._comments.Add(comment12);

        video1.DisplayVideoDetails();
        video2.DisplayVideoDetails();
        video3.DisplayVideoDetails();

    }
}