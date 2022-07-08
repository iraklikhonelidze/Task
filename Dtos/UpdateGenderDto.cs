using System.ComponentModel.DataAnnotations;
using CRUD.API.Models;

namespace Task.Dtos
{
    public class UpdateGenderDto
    {
        [Required]
        public int Gend { get; set; }
    }
}