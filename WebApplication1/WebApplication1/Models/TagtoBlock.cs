using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TagtoBlock
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("BlogCategory")]
        public int BlogCategorid { get; set; }
        public BlogCategory BlogCategory { get; set; }


        [ForeignKey("Tag")]
        public int Tagid { get; set; }
        public Tag Tag { get; set; }


    }
}
