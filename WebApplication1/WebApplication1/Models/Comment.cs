using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; }
        [MaxLength(250)]
        public string Website { get; set; }
        [MaxLength(2000)]
        public string Content { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

       



    }
}
