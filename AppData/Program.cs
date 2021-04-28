using System;
using System.Linq;
using DataLibrary;
using Microsoft.EntityFrameworkCore;

namespace AppData
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppDbContext())
            {
                db.Database.MigrateAsync();
                // Create
                //var date = new DateTime();
                Console.WriteLine("Inserting a new blog");
                //db.Add(new Blog { Url = "www.google.com"}); ;
                db.Add(new Student { FirstMidName = "Atanas", LastName = "TEST"});
                db.SaveChanges();

                // Read
                //Console.WriteLine("Querying for a blog");
                //var blog = db.Blogs
                //    .OrderBy(b => b.ID)
                //    .First();

                // Update
                //Console.WriteLine("Updating the blog and adding a post");
                //blog.Url = "https://devblogs.microsoft.com/dotnet";
                //blog.Posts.Add(
                //    new Post
                //    {
                //        Title = "Hello World",
                //        Content = "I wrote an app using EF Core!"
                //    });
                //db.SaveChanges();

                // Delete
                //Console.WriteLine("Delete the blog");
                //db.Remove(blog);
                //db.SaveChanges();
            }
        }
    }
}
