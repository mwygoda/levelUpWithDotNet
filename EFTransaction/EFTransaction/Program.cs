using System;

namespace EFTransaction
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var db = new PostsContext())
            {
                using (var dbTransaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Posts.Add(new Post {Name = "New Post about EF", Content = "Lorem Ipsum..."});
                        db.SaveChanges();
                        db.Posts.Add(new Post {Name = "Transaction using EF", Content = "Works like a dream"});
                        db.SaveChanges();

                        dbTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        dbTransaction.Rollback();
                        Console.WriteLine(e);
                    }
                }

                foreach (var post in db.Posts)
                    Console.WriteLine(post.Name);
            }
            Console.WriteLine("Press any button to continue...");
            Console.ReadKey();
        }
    }
}