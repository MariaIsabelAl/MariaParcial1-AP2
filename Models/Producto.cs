using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MariaParcial1_AP2.Models
{
    public class Producto
    {
        [Key]
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        [Range(0,100000, ErrorMessage ="El rango es de 0 a 100000")]
        public int productoId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [Range(1,1000000, ErrorMessage ="El rango es de 1 a 100000")]
        public int existencia { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [Range(1, 1000000, ErrorMessage = "El rango es de 1 a 100000")]
        public decimal costo { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public decimal valorInventario { get; set; }

        public Producto()
        {
            productoId = 0;
            descripcion = string.Empty;
            existencia = 0;
            costo = 0;
            valorInventario = 0;
        }
    }
}