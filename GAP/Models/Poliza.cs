using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GAP.Models
{
    public class Poliza
    {
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }

        [Required]
        [Display(Name = "Cobertura")]
        public int idTipoCobertura { get; set; }

        [Required]
        [Display(Name = "Riesgo")]
        public int idTipoRiesgo { get; set; }

        [Display(Name = "Estado")]
        [Required]
        public int idTipoEstado { get; set; }

        [Display(Name ="Nombre de la Poliza")]
        [Required]
        public string NombrePoliza { get; set; }

        [Display(Name = "Descripcion de la Poliza")]
        [Required]
        public string DescripcionPoliza { get; set; }

        [Display (Name = "Fecha de inicio")]
        [DataType(DataType.Date)]
        [Required]
        //[RegularExpression(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$", ErrorMessage ="Formato como dd/MM/yyyy")]
        public System.DateTime FechaInicio { get; set; }

        [Display(Name ="Número de meses cubiertos")]
        [Required]
        public Nullable<int> NumeroMesesCobertura { get; set; }

        [Display(Name ="Valor de la poliza")]
        [DataType(DataType.Currency)]
        [Required]
        public Nullable<decimal> Precio { get; set; }
        
    }
}