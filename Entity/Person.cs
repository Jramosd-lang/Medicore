using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Person
    {
      
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
        public string NumeroDocumento { get; private set; }
        public string TipoDocumento { get; private set; }
        public string Correo { get; private set; }
        public string Telefono { get; private set; }
        public string Sexo { get; private set; }



        protected Person(
            int id,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            string numeroDocumento,
            string tipoDocumento,
            string correo,
            string telefono,
            string sexo)
        {
            if (id < 0)
                throw new ArgumentException("Id no puede estar vacío", nameof(id));
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Nombre no puede estar vacío", nameof(nombre));
            if (string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("Apellido no puede estar vacío", nameof(apellido));
            if (fechaNacimiento > DateTime.Today)
                throw new ArgumentException("Fecha de nacimiento no puede ser en el futuro", nameof(fechaNacimiento));
            if (string.IsNullOrWhiteSpace(numeroDocumento))
                throw new ArgumentException("Número de documento no puede estar vacío", nameof(numeroDocumento));
            if (string.IsNullOrWhiteSpace(tipoDocumento))
                throw new ArgumentException("Tipo de documento no puede estar vacío", nameof(tipoDocumento));
            if (string.IsNullOrWhiteSpace(correo))
                throw new ArgumentException("Correo no puede estar vacío", nameof(correo));
            if (string.IsNullOrWhiteSpace(telefono))
                throw new ArgumentException("Teléfono no puede estar vacío", nameof(telefono));
            if (string.IsNullOrWhiteSpace(sexo))
                throw new ArgumentException("Sexo no puede estar vacío", nameof(sexo));

            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            NumeroDocumento = numeroDocumento;
            TipoDocumento = tipoDocumento;
            Correo = correo;
            Telefono = telefono;
            Sexo = sexo;
        }
    }

}
