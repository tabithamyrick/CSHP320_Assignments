using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CSHP320_Assignment6.Models
{
    public class BirthdayCardModel
    {
        [DisplayName("From: ")]
        [Required(ErrorMessage = "Please Enter From")]
        public string From { get; set; }
        [DisplayName("To: ")]
        [Required(ErrorMessage = "Please Enter To")]
        public string To { get; set; }
        [DisplayName("Message: ")]
        [Required(ErrorMessage = "Please Enter a Message")]
        public string Message { get; set; }
    }
}
