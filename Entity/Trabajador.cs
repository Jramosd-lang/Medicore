using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Trabajador:Person
    {
        private string cargo { get; set; }
        private string estado { get; set; }
        private string tipoContrato { get; set; }
        private decimal salario { get; set; }
        
        public Trabajador(int id, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, 
                          string numeroDocumento, string tipoDocumento, string fechaNacimiento, string sexo, string telefono, 
                          string direccion, string correoElectronico, decimal deuda, string cargo, string horaIngreso, 
                          string horaSalida, string estado, string tipoDeContrato, decimal salario):base(
                              id, primerNombre, segundoNombre, primerApellido, 
                              segundoApellido, numeroDocumento, tipoDocumento, 
                              fechaNacimiento, sexo, telefono, direccion, 
                              correoElectronico, deuda) 

        {
            this.cargo = cargo;
            this.horaIngreso = horaIngreso;
            this.horaSalida = horaSalida;
            this.estado = estado;
            this.tipoContrato = tipoDeContrato;
            this.salario = salario;

        }
    }
}
