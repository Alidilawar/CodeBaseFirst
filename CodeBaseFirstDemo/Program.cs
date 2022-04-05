using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBaseFirstDemo
{
    public class Posts
    {
       [key]
       public int ID { get; set; }

       public DateTime DatePublisher { get; set; }

       public string Body { get; set; }

       public string Title { get; set; }
    }

    public class BlogDBContext : DbContext
    {
        public DbSet<Posts> Posts { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
