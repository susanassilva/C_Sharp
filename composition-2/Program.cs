using System;
using composition_2.Entities;

namespace composition_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comment = new Comment("Have a nice trip!");
            Comment comment2 = new Comment("WOW, that's awesome!");
            Post post = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travelling to New Zealand",
                "I'm going to visit this wonderful country",
                12);
            
            post.AddComment(comment);
            post.AddComment(comment2);

            Console.WriteLine(post);
        }
    }
}
