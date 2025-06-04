using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.Models
{
    public class CitaDto
    {
        public DateTime Fecha { get; set; }
        public string? Hora { get; set; }
        public string? NombreDoctor { get; set; }
        public string? Motivo { get; set; }
        public string? Estado { get; set; }
    }
}
