namespace Entity
{
    public class Paciente : Person
    {


        public string Ocupacion { get; set; }
        public string Religion { get; set; }


        public Paciente(
            int id,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            string numeroDocumento,
            string tipoDocumento,
            string correo,
            string telefono,
            string ocupacion,
            string religion,
            string sexo
            )
            : base(id, nombre, apellido, fechaNacimiento, numeroDocumento, tipoDocumento,correo, telefono, sexo)
        {

            Ocupacion = ocupacion;
            Religion = religion;
            
        }

 

        
    }
}
