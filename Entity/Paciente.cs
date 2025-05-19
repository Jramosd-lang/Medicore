namespace Entity
{
    public class Paciente : Person
    {
        public string RutaHistorialPdf { get; private set; }

     
        public Paciente(
            int id,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            string numeroDocumento,
            string tipoDocumento,
            string correo,
            string telefono,
            string rutaHistorialPdf)
            : base(id, nombre, apellido, fechaNacimiento, numeroDocumento, tipoDocumento,correo, telefono)
        {
            if (string.IsNullOrWhiteSpace(rutaHistorialPdf))
                throw new ArgumentException("La ruta del historial médico no puede estar vacía", nameof(rutaHistorialPdf));

            RutaHistorialPdf = rutaHistorialPdf;
        }

 
        public void ActualizarRutaHistorialPdf(string nuevaRuta)
        {
            if (string.IsNullOrWhiteSpace(nuevaRuta))
                throw new ArgumentException("La ruta del historial médico no puede estar vacía", nameof(nuevaRuta));

            RutaHistorialPdf = nuevaRuta;
        }

        
    }
}
