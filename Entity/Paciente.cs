using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Paciente : Persona
    {
        public string allergies { get; set; }

        public String medicalHistory { get; set; }

        public String bloodType { get; set; }
        public Paciente(int id, string name, string surname, string address, string typeDocument, int document, string phone, DateOnly dateOfBirth, string sex, string allergies, string medicalHistory, string bloodType ) : base(id, name, surname, address, typeDocument, document, phone, dateOfBirth, sex)
        {
            this.allergies = allergies;
            this.medicalHistory = medicalHistory;
            this.bloodType = bloodType;
        }

        public override void showData()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Nombres: " + Name);
            Console.WriteLine("Apellidos: " + Surname);
            Console.WriteLine("Direccion: " + Address);
            Console.WriteLine("Tipo de documento: " + typeDocument);
            Console.WriteLine("Documento: " + Document);
            Console.WriteLine("Numero de celular: " + Phone);
            string mensaje = CalcularEdad(DateOfBirth);
            Console.WriteLine(mensaje);
            Console.WriteLine("Sexo: "+Sex);
            Console.WriteLine("Alergias: " + allergies);
            Console.WriteLine("Historia clinica: " + medicalHistory);
            Console.WriteLine("Grupo sanguineo: " + bloodType); 
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
