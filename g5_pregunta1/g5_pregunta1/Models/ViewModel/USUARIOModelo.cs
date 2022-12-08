using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using g5_pregunta1.Models;

namespace g5_pregunta1.Models.ViewModel
{
    public class USUARIOModelo
    {
        [Required(ErrorMessage = "Debe digitar un id de usuario")]
        public int ID_USUARIO { get; set; }
        [Required(ErrorMessage = "Debe digitar un correo")]
        [StringLength(30, ErrorMessage = "El tamaño no debe superar los 30 caracteres")]
        [Display(Name = "Correo")]
        public string EMAIL { get; set; }
        [Required(ErrorMessage = "Debe digitar una contraseña")]
        [StringLength(20, ErrorMessage = "El tamaño no debe superar los 30 caracteres")]
        [Display(Name = "Contraseña")]
        public string PASS { get; set; }

        [Required(ErrorMessage = "Debe digitar una fecha")]
        [DataType(DataType.Date)]
        public System.DateTime FECHA_ULTIMO_ACCESO { get; set; }
    }
}