using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BLL
{
    public class PacienteService : IService<Paciente>
    {
        //private readonly EspecieRepository repoEspecie;
        DAL.PacienteRepository repoPaciente = new DAL.PacienteRepository();

        public PacienteService()
        {
            //repoEspecie = new EspecieRepository(Archivos.ARC_ESPECIE);
            //repoEspecie = new EspecieRepository(Archivos.ARC_ESPECIE);
        }

        public List<Paciente> Consultar()
        {
            return repoPaciente.Consultar();
        }

        public string Agregar(Paciente entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la especie no puede ser nula");
                }

                return repoPaciente.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar especie: {ex.Message}";
            }
        }

        public string Modificar(Paciente entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la especie no puede ser nula");
                }

                return repoPaciente.Modificar(entity);
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

                return repoPaciente.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar especie: {ex.Message}";
            }
        }

        public Paciente BuscarId(int id)
        {
            return repoPaciente.BuscarPorId(id);
        }
        public Paciente BuscarPorNumeroDocumento(string numeroDocumento)
        {
            return repoPaciente.BuscarPorNumeroDocumento(numeroDocumento);
        }

    }
}
