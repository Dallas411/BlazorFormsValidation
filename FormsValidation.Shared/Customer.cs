using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FormsValidation.Shared
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(8,ErrorMessage = "Code invalid length: range from 0 to 8 characters.")]
        public string Code { get; set; }

        [Required]
        [StringLength(16, ErrorMessage = "Name invalid length: range from 0 to 8 characters.")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(1, 10, ErrorMessage = "Rating out of range, from 1 to 10 is the valid range.")]
        public int Rating { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true",
            ErrorMessage = "Active not valid value.")]
        public bool Active { get; set; }

        [Required]
        public DateTime NextVisitDate { get; set; }
    }
}
