namespace Entity
{
    public class Paciente:Person
    {
        private string historiaClinica {get; set;}
        private Doctor doctor { get; set; }

        private string estadoPago { get; set; }

        public Paciente(int id, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string numeroDocumento, string tipoDocumento, string fechaNacimiento, string sexo, string telefono, string direccion, string correoElectronico, string tipoDocumento1, decimal deuda, string historiaClinica, Doctor doctor) : base(id, primerNombre, segundoNombre, primerApellido, segundoApellido, numeroDocumento, tipoDocumento, fechaNacimiento, sexo, telefono, direccion, correoElectronico, deuda)
        {
            this.historiaClinica = historiaClinica;
            this.doctor = doctor;
        }

    }
}
