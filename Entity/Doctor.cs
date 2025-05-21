using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Doctor : Person
    {
        

        public string Especialidad { get; private set; }
        public string NumeroLicencia { get; private set; }
        public string Password { get; private set; }

    
        public Doctor(
            int id,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            string numeroDocumento,
            string tipoDocumento,
            string correo,
            string telefono,
            string especialidad,
            string numeroLicencia,
            string password,
            string sexo)
            : base(id, nombre, apellido, fechaNacimiento, numeroDocumento, tipoDocumento, correo, telefono, sexo)
        {
            if (string.IsNullOrWhiteSpace(especialidad))
                throw new ArgumentException("Especialidad no puede estar vacía", nameof(especialidad));
            if (string.IsNullOrWhiteSpace(numeroLicencia))
                throw new ArgumentException("Número de licencia no puede estar vacío", nameof(numeroLicencia));

            Especialidad = especialidad;
            NumeroLicencia = numeroLicencia;
            Password = Password;
        }



        public void ValidarLicencia()
        {
            const int LongitudMinima = 5;
            if (NumeroLicencia.Length < LongitudMinima)
                throw new InvalidOperationException($"Número de licencia debe tener al menos {LongitudMinima} caracteres.");
        }

      
    }
}

