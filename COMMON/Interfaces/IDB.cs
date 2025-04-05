using COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Interfaces
{
    /// <summary>
    /// Interfaz genérica para operaciones básicas de base de datos
    /// </summary>
    /// <typeparam name="T">Tipo de entidad que debe heredar de CamposControl</typeparam>
    public interface IDB<T> where T : CamposControl
    {
        /// <summary>
        /// Mensaje de error de la última operación realizada
        /// </summary>
        string Error { get; }

        /// <summary>
        /// Obtiene todos los registros de la entidad
        /// </summary>
        /// <returns>Lista de entidades</returns>
        List<T> ObtenerTodos();

        /// <summary>
        /// Obtiene una entidad por su ID (versión para IDs enteros)
        /// </summary>
        T ObtenerPorId(int id);

        /// <summary>
        /// Obtiene una entidad por su ID (versión para IDs string)
        /// </summary>
        T ObtenerPorId(string id);

        /// <summary>
        /// Elimina una entidad
        /// </summary>
        bool Eliminar(T entidad);

        /// <summary>
        /// Inserta una nueva entidad
        /// </summary>
        T Insertar(T entidad);

        /// <summary>
        /// Actualiza una entidad existente
        /// </summary>
        T Actualizar(T entidad);

        /// <summary>
        /// Ejecuta un procedimiento almacenado
        /// </summary>
        /// <typeparam name="M">Tipo de resultado esperado</typeparam>
        List<M> EjecutarProcedimiento<M>(string nombre, Dictionary<string, string> parametros) where M : class;
    }
}