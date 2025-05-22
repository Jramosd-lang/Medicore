using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EventoHistorialMedico
    {
        public int Id_evento { get; set; }
        public int Id_historial_medico { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Medicamentos { get; set; }
        public string Recomendaciones { get; set; }
        public string Examenes { get; set; }

        public EventoHistorialMedico(int id_evento,
            int id_historial,
            DateTime fecha,
            string descripcion,
            string observacioes,
            string diagnostico,
            string tratamiento,
            string medicamentos,
            string recomendaciones,
            string examenes
            )
        {
            Id_evento = id_evento;
            Id_historial_medico = id_historial;
            Fecha = fecha;
            Descripcion = descripcion;
            Observaciones = observacioes;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            Medicamentos = medicamentos;
            Recomendaciones = recomendaciones;
            Examenes = examenes;        

        }


    }
}
