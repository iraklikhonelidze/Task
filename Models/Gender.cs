using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.API.Models
{
    public class Gender
    {
        [ForeignKey("User")]
        public int GenderId { get; set; }
        [Required]
        public int Gend { get; set; }
    }
}