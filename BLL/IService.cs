using Microsoft.Win32.SafeHandles;

namespace BLL
{
    public interface IService<T>
    {
        string Agregar(T entity);
        List<T> Consultar();
        string Modificar(T entity);
        string Eliminar(int id);
        T BuscarId(int id);
    }
}