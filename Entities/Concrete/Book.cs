﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }
    }
}
