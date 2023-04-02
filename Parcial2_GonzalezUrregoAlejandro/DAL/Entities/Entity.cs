using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial2_GonzalezUrregoAlejandro.DAL.Entities
{
    public class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Tiquete")]
        public int Id { get; set; }
        [Display(Name = "Fecha de creación")]
        public DateTime? CreatedDate { get; set; }
        [Display(Name = "Fecha de modificación")]
        public DateTime? ModifiedDate { get; set; }
    }
}

