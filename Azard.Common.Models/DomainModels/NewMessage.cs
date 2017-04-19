using System.ComponentModel.DataAnnotations;

namespace Azard.Common.Models.DomainModels
{
    public class NewMessage
    {
        [Required]
        [MaxLength(50)]
        public string Author { get; set; }

        [Required]
        [MinLength(1)]
        public string Message { get; set; }
    }
}