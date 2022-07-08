using System.ComponentModel.DataAnnotations;

namespace Task.Dtos
{
    public class AddGenderDto
    {
        [Required]
        public int Gend { get; set; }
    }
}