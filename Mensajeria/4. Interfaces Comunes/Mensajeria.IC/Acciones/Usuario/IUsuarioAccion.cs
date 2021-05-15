// ------------------------------------------------------------------------------------
// <copyright file="IUsuarioAccion.cs" company="Camilo Prieto">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.IC.Acciones.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using UtilitariosNet.Clases.Comunes.Entidades;
    using Mensajeria.IC.DTO.Repositorio;

    /// <summary>
    /// Interface que define las acciones que se implmentara en todas las capas de IUsuarioAccion
    /// </summary>
    public interface IUsuarioAccion
    {
        /// <summary>
        /// Metodo guardar usuario
        /// </summary>
        /// <param name="usuario">Entidad a guardar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        Task<Respuesta<IUsuarioDTO>> GuardarUsuarioAsync(IUsuarioDTO usuario);
    }

    /// <summary>
    /// Interface que define las acciones de la capa de repositorioIUsuarioAccion
    /// </summary>
    public interface IUsuarioRepositorioAccion : IUsuarioAccion
    {
        /// <summary>
        /// Metodo editar usuario
        /// </summary>
        /// <param name="usuario">Entidad a editar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        Task<Respuesta<IUsuarioDTO>> EditarUsuarioAsync(IUsuarioDTO usuario);

        /// <summary>
        /// Metodo consultar lista usuario
        /// </summary>
        /// <returns>Respuesta tipo Usuario</returns>
        Task<Respuesta<IUsuarioDTO>> ConsultarListaUsuarioAsync();

        /// <summary>
        /// Metodo consultar por llave usuario
        /// </summary>
        /// <param name="usuario">Entidad a consultar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        Task<Respuesta<IUsuarioDTO>> ConsultarUsuarioLlaveAsync(IUsuarioDTO usuario);

        /// <summary>
        /// Metodo editar usuario por query
        /// </summary>
        /// <param name="filtro">Filtro de las entidades</param>
        /// <param name="valor">Entidad a mofificar</param>
        /// <param name="propiedades">Propiedades a modificar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        Task<Respuesta<IUsuarioDTO>> EditarPorQueryUsuarioAsync(Expression<Func<IUsuarioDTO, bool>> filtro, IUsuarioDTO valor, List<string> propiedades);

        /// <summary>
        /// Metodo consultar lista usuario por filtro
        /// </summary>
        /// <param name="filtro">Filtro de las entidades</param>
        /// <returns>Respuesta tipo Usuario</returns>
        Task<Respuesta<IUsuarioDTO>> ConsultarListaUsuarioPorFiltroAsync(Expression<Func<IUsuarioDTO, bool>> filtro);

        /// <summary>
        /// Metodo editar usuario por filtro
        /// </summary>
        /// <param name="usuario">Entidad con los datos a editar</param>
        /// <param name="propiedades">Propiedades a modificar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        Task<Respuesta<IUsuarioDTO>> EditarUsuarioPorFiltroAsync(IUsuarioDTO usuario, params string[] propiedades);

        /// <summary>
        /// Metodo eliminar lista usuario
        /// </summary>
        /// <param name="lista">Lista de entidad a eliminar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        Task<Respuesta<IUsuarioDTO>> EliminarListaUsuarioAsync(List<IUsuarioDTO> lista);

        /// <summary>
        /// Metodo editar usuario lista
        /// </summary>
        /// <param name="lista">Lista con entidades a modificar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        Task<Respuesta<IUsuarioDTO>> EditarListaUsuarioAsync(List<IUsuarioDTO> lista);
    }

    /// <summary>
    /// Interface que define las acciones de la capa de negocioIUsuarioAccion
    /// </summary>
    public interface IUsuarioNegocioAccion : IUsuarioAccion
    {
    }
}