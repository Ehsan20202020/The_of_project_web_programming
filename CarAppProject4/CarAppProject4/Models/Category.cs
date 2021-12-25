using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarAppProject4.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        [Display(Name ="Mark Name")]
        [MaxLength(50)]
        public string MarkName { get; set; }
    }
}
