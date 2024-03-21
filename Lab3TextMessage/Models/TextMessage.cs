using System.ComponentModel.DataAnnotations;

namespace Lab3TextMessage.Models
{
    public class TextMessage
    {
        [Required]
        [Display(Name = "Phone Number:")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string DestinationPhone { get; set; }

        [MaxLength(140)]
        [Display(Name = "Content")]
        public string TextContent { get; set; }
    }

}
