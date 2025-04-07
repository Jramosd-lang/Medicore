using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Persona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Address { get; set; }

        public String typeDocument { get; set; }

        public int Document { get; set; }

        public string Phone { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public String Sex { get; set; }



        public Persona(int id, string name, string surname, string address, string typeDocument, int document, string phone, DateOnly dateOfBirth, string sex)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Address = address;
            this.typeDocument = typeDocument;
            this.Document = document;
            this.Phone = phone;
            this.DateOfBirth = dateOfBirth;
            this.Sex = sex;
        }

        public static string CalcularEdad(DateOnly fechaNacimiento)
        {
            DateOnly hoy = DateOnly.FromDateTime(DateTime.Today);
            int edad = hoy.Year - fechaNacimiento.Year;


            if (hoy < new DateOnly(hoy.Year, fechaNacimiento.Month, fechaNacimiento.Day))
            {
                edad--;
            }

            return "Edad: "+edad;
        }



        public abstract void showData();

    }
}
