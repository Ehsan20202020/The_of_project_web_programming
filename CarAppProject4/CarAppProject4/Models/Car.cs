using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarAppProject4.Models
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }

        [Required(ErrorMessage = "Mark name is required")]
        [Display(Name = "Mark")]
        [MaxLength(50)]
        public int Marks { get; set; }

        [Required(ErrorMessage = "Model is required")]
        [Display(Name = "Model")]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Details")]
        [MaxLength]
        public string Details { get; set; }
    }
}
