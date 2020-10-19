using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DutchTreat.ViewModels
{
	public class ontactViewModel
    {
        [Required(ErrorMessage = "Name is required")] 
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message
        { get; set; }
    }
}