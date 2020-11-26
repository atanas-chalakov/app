using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace AppData
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            options.UseSqlServer("Data Source=DESKTOP-7TRC7N7\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //options.UseSqlite("Data Source=blogging.db");
        }
           
    }

    public class Blog
    {
        public int ID { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }

    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        //public int BlogId { get; set; }
        //public Blog Blog { get; set; }
    }
}