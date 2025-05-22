using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class HistorialMedicoService : IService<HistorialMedico>
    {
        HistorialMedicoRepository historialMedicoRepository = new HistorialMedicoRepository();

        public string Agregar(HistorialMedico entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la especie no puede ser nula");
                }

                return historialMedicoRepository.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar especie: {ex.Message}";
            }
        }

        public HistorialMedico BuscarId(int id)
        {
            return historialMedicoRepository.BuscarId(id);
        }

        public List<HistorialMedico> Consultar()
        {
            return historialMedicoRepository.Consultar();
        }

        public string Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Error... el id debe ser mayor a cero");
                }

                return historialMedicoRepository.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar especie: {ex.Message}";
            }
        }

        public string Modificar(HistorialMedico entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la especie no puede ser nula");
                }

                return historialMedicoRepository.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al modificar especie: {ex.Message}";
            }
        }
    }
}
