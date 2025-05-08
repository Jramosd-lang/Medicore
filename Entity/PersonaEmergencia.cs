namespace Entity
{
    public  class PersonaEmergencia
    {
        private string nombre { get; set; }
        private string parentesco { get; set; }
        private string telefono { get; set; }

        public PersonaEmergencia(string nombre, string parentesco, string telefono)
        {
            this.nombre = nombre;
            this.parentesco = parentesco;
            this.telefono = telefono;
        }

    }
}