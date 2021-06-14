﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tabloid.Models
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public List<Post> Post { get; set; }
    }
}



