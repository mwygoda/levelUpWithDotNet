using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFTransaction;

namespace EFTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PostsContext())
            {
                db.Posts.Add(new Post { Name = "New Post", Content = "Lorem Ipsum..."});
                db.SaveChanges();

                foreach (var post in db.Posts)
                {
                    Console.WriteLine(post.Name);
                }
            }
            Console.WriteLine("Press any button to continue...");
            Console.ReadKey();
        }
    }
}