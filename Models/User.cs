using System.ComponentModel.DataAnnotations;

namespace CRUD.API
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public String FirstName { get; set; } = string.Empty;
        [Required]
        public String LastName { get; set; } = string.Empty;
        [Required]
        public int personalId { get; set; }
        public int YearOfBirth { get; set; }
        [Required]
        public int Gender { get; set; }
        [Required]
        public bool IsActive { get; set; }

    }
}