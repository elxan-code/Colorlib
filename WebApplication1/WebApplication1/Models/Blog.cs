using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [ForeignKey("BlogCategory")]
        public int BlogCategorid { get; set; }
        public BlogCategory BlogCategory { get; set; }
        [ForeignKey("User")]
        public int Userid { get; set; }
        public User User { get; set; }





    }
}
