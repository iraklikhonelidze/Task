using System.ComponentModel.DataAnnotations;

namespace Task.Dtos
{
    public class AddUserDto
    {
        [Required]
        public String FirstName { get; set; } = string.Empty;
        [Required]
        public String LastName { get; set; } = string.Empty;
        [Required]
        public int personalId { get; set; }
        public int YearOfBirth { get; set; }
        public AddGenderDto? Gend { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}