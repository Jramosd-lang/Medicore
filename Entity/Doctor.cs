using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Doctor:Trabajador
    {
        private string especialidad { get; set; }
        public Doctor(int id, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido,
                          string numeroDocumento, string tipoDocumento, string fechaNacimiento, string sexo, string telefono,
                          string direccion, string correoElectronico, decimal deuda, string cargo, string horaIngreso,
                          string horaSalida, string estado, string tipoDeContrato, decimal salario, string especialidad):base(
                          id, primerNombre, segundoNombre, primerApellido, segundoApellido,
                          numeroDocumento, tipoDocumento, fechaNacimiento, sexo, telefono,
                          direccion, correoElectronico, deuda, cargo, horaIngreso,
                          horaSalida, estado, tipoDeContrato, salario)
        {

        }
    }
}
