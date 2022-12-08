using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using g5_pregunta1.Models;

namespace g5_pregunta1.Clases
{
    public class Usuario
    {
        public int ID_USUARIO { get; set; }
        public string EMAIL { get; set; }
        public string PASS { get; set; }
        public System.DateTime FECHA_ULTIMO_ACCESO { get; set; }

        G5_CASO3Entities db = new G5_CASO3Entities();
        public bool Autenticar()
        {
            return db.USUARIO.Where(u => u.EMAIL == this.EMAIL
            && u.PASS == this.PASS)
            .FirstOrDefault() != null;
        }
    }
}