using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "Campo Requerido - Nombre")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ingrese Entre 3 a 50 Caracteres")]
        public string Nombre { get; set; }
        [StringLength(250)]
        [Display (Name ="Descripción") ]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
    }
}
