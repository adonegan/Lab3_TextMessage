using System.ComponentModel.DataAnnotations;

namespace Lab3TextMessage.Models
{
    public class TextMessage
    {
        [Required]
        [Display(Name = "To")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Number must be 10 digits")]
        public string DestinationPhone { get; set; }

        [Required(ErrorMessage = "Can't be blank!")]
        [MaxLength(140)]
        [Display(Name = "Content")]
        public string TextContent { get; set; }
    }

}
