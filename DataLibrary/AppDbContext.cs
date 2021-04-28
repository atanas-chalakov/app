using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace DataLibrary
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            //options.UseSqlServer("Data Source=DESKTOP-7TRC7N7\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //options.UseSqlite("Data Source=F:\\C#\\App\\AppData\\blogging.db");
            options.UseMySQL("server=127.0.0.1;database=test;user=root;");
        }
    }
}
