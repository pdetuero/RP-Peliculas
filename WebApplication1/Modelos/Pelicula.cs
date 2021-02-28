using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Modelos
{
    public class Pelicula
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal Precio { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        public string Descripcion { get; set; }
    }
}
