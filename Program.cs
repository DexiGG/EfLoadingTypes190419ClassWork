using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfLoadingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext())
            {
                //var author = new Author
                //{
                //    Name = "А.С.Лермонтов"
                //};

                //var book = new Book
                //{
                //    Name = "13 оттенков мгновений весны",
                //    Price = 10000,
                //    AuthorId = author.Id
                //};

                //context.Authors.Add(author);
                //context.Books.Add(book);
                //context.SaveChanges();
                //-------------------------------------------------
                                            //ЛЕНИВАЯ ЗАГРУЗКА
                //var books = context.Books.ToList();
                //var author = books.FirstOrDefault().Author;
                                            //ЖАДНАЯ ЗАГРУКА
                //var books = context.Books.Include("Author").ToList();
                //------------------------------------------------------
                                            //ЯВНАЯ ЗАГРУЗКА
                //var author = context.Authors.FirstOrDefault();
                //context.Entry(author).Collection("Books").Load();
            }
        }
    }
}
