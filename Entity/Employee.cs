using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Employee : Persona
    {
        

        public string Rol { get; set; }
        public float Salary { get; set; }

        public string IncapacityDays { get; set; }

        public Employee(int id, string name, string surname, string address, string typeDocument, int document, string phone, DateOnly dateOfBirth, string sex, string rol, float salary, string IncapacityDays) : base(id, name, surname, address, typeDocument, document, phone, dateOfBirth, sex)
        {
            this.Rol = rol;
            this.Salary = salary;
            this.IncapacityDays = IncapacityDays;

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
            Console.WriteLine("Sexo: " + Sex);
            Console.WriteLine("rol: " + Rol);
            Console.WriteLine("Salario: " + Salary);
            Console.WriteLine("Dias de incapacidad: " + IncapacityDays);
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
