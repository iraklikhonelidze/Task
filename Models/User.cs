using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CRUD.API.Models;

namespace CRUD.API
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String FirstName { get; set; } = string.Empty;
        [Required]
        public String LastName { get; set; } = string.Empty;
        [Required]
        public int personalId { get; set; }
        public int YearOfBirth { get; set; }
        public Gender Gend { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}