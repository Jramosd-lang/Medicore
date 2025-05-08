using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Person
    {
        protected int id { get; set; }
        protected string nombre { get; set; }
        protected string tipoDeDocumento { get; set; }
        protected string numeroDocumento { get; set; }
        protected string fechaNacimiento { get; set; }
        protected string sexo { get; set; }
        protected string telefono { get; set; }
        protected string direccion { get; set; }
        protected string correoElectronico { get; set; }
        protected PersonaEmergencia personaEmergencia { get; set; }


        public Person(int id, string nombre, string numeroDocumento, string tipoDeDocumento, string fechaNacimiento, string sexo, 
            string telefono, string direccion, string correoElectronico, PersonaEmergencia personaEmergencia)
        {
            this.id = id;
            this.nombre = nombre;
            this.numeroDocumento = numeroDocumento;
            this.tipoDeDocumento = tipoDeDocumento;
            this.fechaNacimiento = fechaNacimiento;
            this.sexo = sexo;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
            this.personaEmergencia = personaEmergencia;
        }
    }

}
