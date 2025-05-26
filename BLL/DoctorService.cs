using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class DoctorService : IService<Doctor>
    {
        //private readonly EspecieRepository repoEspecie;
         DoctorRepository repoDoctor = new DoctorRepository();

        public DoctorService()
        {
            //repoEspecie = new EspecieRepository(Archivos.ARC_ESPECIE);
            //repoEspecie = new EspecieRepository(Archivos.ARC_ESPECIE);
        }

        public List<Doctor> Consultar()
        {
            return repoDoctor.Consultar();
        }

        public string Agregar(Doctor entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la especie no puede ser nula");
                }

                return repoDoctor.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar especie: {ex.Message}";
            }
        }

  

        public string Modificar(Doctor entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la especie no puede ser nula");
                }

                return repoDoctor.Modificar(entity);
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

                return repoDoctor.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar especie: {ex.Message}";
            }
        }

        public Doctor BuscarId(int id)
        {
            return repoDoctor.BuscarPorId(id);
        }

        public bool ValidarCredenciales(string numeroDoc, string password)
        {
            return repoDoctor.ValidarCredenciales(numeroDoc, password);
        }

        public Doctor BuscarPorDocumento(string documento)
        {
            return repoDoctor.BuscarPorNumeroDocumento(documento);
        }

       
    }

}
