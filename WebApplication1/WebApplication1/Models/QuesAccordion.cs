using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class QuesAccordion
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string TitleQuestion { get; set; }
        [MaxLength(250)]
        public string Answer { get; set; }



    }
}
