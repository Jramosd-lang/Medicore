using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class EventoHistorialService : IService<EventoHistorialMedico>
    {
        EventoHistorialRepository EventoRepo = new DAL.EventoHistorialRepository();

        public string Agregar(EventoHistorialMedico entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la especie no puede ser nula");
                }

                return EventoRepo.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar especie: {ex.Message}";
            }
        }

        public EventoHistorialMedico BuscarId(int id)
        {
            return EventoRepo.BuscarId(id);
        }

        public List<EventoHistorialMedico> Consultar()
        {
            return EventoRepo.Consultar();
        }

        public string Eliminar(int id)
        {
            return EventoRepo.Eliminar(id);
        }

        public string Modificar(EventoHistorialMedico entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la especie no puede ser nula");
                }
                return EventoRepo.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al modificar especie: {ex.Message}";
            }
        }
    }
}
