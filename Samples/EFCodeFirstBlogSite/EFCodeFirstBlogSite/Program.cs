using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCodeFirstBlogSite.Models;
using EFCodeFirstBlogSite.Repositories;

namespace EFCodeFirstBlogSite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogContext())
            {
                Console.WriteLine("Enter a name for a new blog: ");
                var name = Console.ReadLine();

                var blog = new Blog();
                blog.Name = name;
                context.Blogs.Add(blog);
                context.SaveChanges();
                var query = from b in context.Blogs
                    orderby b.Name
                    select b;

                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

            }        
        }
    }
}
