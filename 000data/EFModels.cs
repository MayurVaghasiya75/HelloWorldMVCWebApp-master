﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMVCWebApp._000data
{
    public class Book
    {
        public int BookId { get; set; }
        [StringLength(50)]
        [Required]

        public string Title { get; set; }

        public string PublisherTitle { get; set; }

        public string Author { get; set; }
    }

    /*public class Author
    {
        public int BookId { get; set; }
        [StringLength(50)]
        [Required]

        public string Title { get; set; }

        public string AuthorX { get; set; }

        public string PublisherTitle { get; set; }
    }*/
}
