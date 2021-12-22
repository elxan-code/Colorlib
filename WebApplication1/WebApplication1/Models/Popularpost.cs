using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Popularpost
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Blog")]
        public int Blogid { get; set; }
        public Blog Blog { get; set; }
    }
}
