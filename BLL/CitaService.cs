using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class CitaService : IService<Cita>
    {
        //private readonly EspecieRepository repoEspecie;
        CitaRepository repoCita = new CitaRepository();

        public CitaService()
        {
            //repoEspecie = new EspecieRepository(Archivos.ARC_ESPECIE);
            //repoEspecie = new EspecieRepository(Archivos.ARC_ESPECIE);
        }

        public List<Cita> Consultar()
        {
            return repoCita.Consultar();
        }

        public string Agregar(Cita entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la especie no puede ser nula");
                }

                return repoCita.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar especie: {ex.Message}";
            }
        }

        public string Modificar(Cita entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la especie no puede ser nula");
                }

                return repoCita.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al modificar especie: {ex.Message}";
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Error... el id debe ser mayor a cero");
                }

                return repoCita.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar especie: {ex.Message}";
            }
        }

        public Cita BuscarId(int id)
        {
            return repoCita.BuscarPorId(id);
        }

        public void modificarEstado(int id)
        {
            repoCita.ModificarEstado(id);
        }
    }
}
