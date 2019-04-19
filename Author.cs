using System.Collections.Generic;

namespace EfLoadingTypes
{
    public class Author : Entity
    {
        public string Name { get; set; }
        public /*virtual*/ ICollection<Book> Books { get; set; }
    }
}