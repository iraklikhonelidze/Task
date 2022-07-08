using System.ComponentModel.DataAnnotations;

namespace Task.Dtos
{
    public class UpdateUserDto
    {

        [Required]
        public int Id { get; set; }
        [Required]
        public String FirstName { get; set; } = string.Empty;
        [Required]
        public String LastName { get; set; } = string.Empty;
        [Required]
        public int personalId { get; set; }
        public int YearOfBirth { get; set; }
        public UpdateGenderDto Gend { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}