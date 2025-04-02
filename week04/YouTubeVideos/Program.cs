using System;


class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How To Podrace", "Anakin Skywalker", 210);

        Comment comment1 = new Comment("John Johnson", "Amazing Video!");
        Comment comment2 = new Comment("Tusken Raider", "I'm in that video!");
        Comment comment3 = new Comment("Sebulba", "Good racing kiddo.");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video1.GetDisplayText();

        Video video2 = new Video("How to spin a Lightsaber", "Ahsoka Tano", 280);

        Comment comment4 = new Comment("Joseph Smith", "Great Spinning!");
        Comment comment5 = new Comment("Darth Maul", "Showoff!");
        Comment comment6 = new Comment("Anakin Skywalker", "Awesome spinning Snips.");

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        video2.GetDisplayText();

        Video video3 = new Video("How to defeat a Sith Lord", "Obi Wan Kenobi", 360);

        Comment comment7 = new Comment("Count Dooku", "Twice the pride, double the fall.");
        Comment comment8 = new Comment("Darth Maul", "It took you two tries to get me!");
        Comment comment9 = new Comment("Luke Skywalker", "Great work Old Ben.");

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        video3.GetDisplayText();
    }
}