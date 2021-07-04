using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B4.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Required field")]
        [MaxLength(80, ErrorMessage = "Name must be less than 80 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required field")]
        [MaxLength(100, ErrorMessage = "Name must be less than 100 characters")]
        [EmailAddress(ErrorMessage = "Provide a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required field")]
        [MaxLength(150, ErrorMessage = "Subject must be less than 150 characters")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Required field")]
        [MaxLength(500, ErrorMessage = "Message must be less than 500 characters")]
        public string Message { get; set; }

        public string RecaptchaSiteKey { get; set; }
    }
}
