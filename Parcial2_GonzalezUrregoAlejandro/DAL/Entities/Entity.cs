using System;
using System.ComponentModel.DataAnnotations;

namespace Parcial2_GonzalezUrregoAlejandro.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}

