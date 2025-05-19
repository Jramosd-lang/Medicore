using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EspecialidadCita
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public EspecialidadCita(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }


    }
}
