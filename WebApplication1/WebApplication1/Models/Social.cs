﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Social
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [MaxLength(250)]
        public string Link { get; set; }
        public DateTime CreateDate { get; set; }
        [ForeignKey("Blog")]
        public int Blogid { get; set; }
        public Blog Blog { get; set; }


    }
}
