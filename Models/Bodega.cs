using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    public class Bodega
    {
        [Key]
        public int CodigoIngreso { get; set; }


        [Display(Name = "Observacion")]
        public string Observacion { get; set; }

        [Display(Name = "Ubicación física")]
        public string Ubicacion { get; set; }

        [Display(Name = "Existencia Minima")]
        public double ExistenciaMinima { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha ingreso")]
        public DateTime? FechaIngreso { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha salida")]
        public DateTime? FechaSalida { get; set; }

        public bool Status { get; set; }

        [Required]
        public int ProductoId { get; set; }

        public Producto CodigoProducto { get; set; }
    }

    public class Salida
    {
        [Display(Name = "Cantidad")]
        public double Cantidad { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha salida")]
        public DateTime? FechaSalida { get; set; }
    }
}
