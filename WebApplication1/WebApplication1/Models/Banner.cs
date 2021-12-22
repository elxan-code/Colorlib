using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Uptitle { get; set; }
        [MaxLength(30)]
        public string Title1 { get; set; }
        [MaxLength(30)]
        public string Title2 { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }
        [MaxLength(30)]
        public string Title3 { get; set; }

    }
}
