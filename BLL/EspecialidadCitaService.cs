using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class EspecialidadCitaService : IService<EspecialidadCita>
    {
        EspecialidadCitaRepository especialidadCitaRepository = new EspecialidadCitaRepository();
        public EspecialidadCita BuscarId(int id)
        {
            return especialidadCitaRepository.BuscarPorId(id);
        }

        public List<EspecialidadCita> Consultar()
        {
            return especialidadCitaRepository.Consultar();
        }

        public List<string> ConsultarNombre()
        {
            return especialidadCitaRepository.consultarNombre();
        }
        public int ConsultarPorNombre(string nombre)
        {
            return  especialidadCitaRepository.consultarPorNombre(nombre);
        }

        public string Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Error... el id debe ser mayor a cero");
                }

                return especialidadCitaRepository.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar especie: {ex.Message}";
            }
        }

        public string Agregar(EspecialidadCita entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la especie no puede ser nula");
                }

                return especialidadCitaRepository.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar especie: {ex.Message}";
            }
        }

        public string Modificar(EspecialidadCita entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la especie no puede ser nula");
                }

                return especialidadCitaRepository.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al modificar especie: {ex.Message}";
            }
        }
    }
}
