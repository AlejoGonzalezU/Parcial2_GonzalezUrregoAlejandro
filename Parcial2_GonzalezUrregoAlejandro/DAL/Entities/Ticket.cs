using System;
using System.ComponentModel.DataAnnotations;

namespace Parcial2_GonzalezUrregoAlejandro.DAL.Entities
{
	public class Ticket : Entity
	{
		[Display(Name = "Fecha de uso")]
		public DateTime? UseDate { get; set; }
        [Display(Name = "¿Boleta Usada?")]
        public Boolean IsUsed { get; set; }
        [Display(Name = "Puerta de ingreso")]
        public string? EntranceGate { get; set; }
    }
}

