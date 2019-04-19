﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfLoadingTypes
{
    public class Book : Entity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public /*virtual*/ Author Author { get; set; }
        public Guid AuthorId { get; set; }
    }
}
