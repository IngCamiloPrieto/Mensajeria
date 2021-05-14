// ------------------------------------------------------------------------------------
// <copyright file="ISalaAccion.cs" company="Camilo Prieto">
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
    /// Interface que define las acciones que se implmentara en todas las capas de ISalaAccion
    /// </summary>
    public interface ISalaAccion
    {
        /// <summary>
        /// Metodo guardar sala
        /// </summary>
        /// <param name="sala">Entidad a guardar</param>
        /// <returns>Respuesta tipo Sala</returns>
        Task<Respuesta<ISalaDTO>> GuardarSalaAsync(ISalaDTO sala);

        /// <summary>
        /// Metodo editar sala
        /// </summary>
        /// <param name="sala">Entidad a editar</param>
        /// <returns>Respuesta tipo Sala</returns>
        Task<Respuesta<ISalaDTO>> EditarSalaAsync(ISalaDTO sala);

        /// <summary>
        /// Metodo consultar lista sala
        /// </summary>
        /// <returns>Respuesta tipo Sala</returns>
        Task<Respuesta<ISalaDTO>> ConsultarListaSalaAsync();

        /// <summary>
        /// Metodo consultar por llave sala
        /// </summary>
        /// <param name="sala">Entidad a consultar</param>
        /// <returns>Respuesta tipo Sala</returns>
        Task<Respuesta<ISalaDTO>> ConsultarSalaLlaveAsync(ISalaDTO sala);

        /// <summary>
        /// Metodo eliminar sala
        /// </summary>
        /// <param name="sala">Entidad a eliminar</param>
        /// <returns>Respuesta tipo Sala</returns>
        Task<Respuesta<ISalaDTO>> EliminarSalaAsync(ISalaDTO sala);
    }

    /// <summary>
    /// Interface que define las acciones de la capa de repositorioISalaAccion
    /// </summary>
    public interface ISalaRepositorioAccion : ISalaAccion
    {
        /// <summary>
        /// Metodo editar sala por query
        /// </summary>
        /// <param name="filtro">Filtro de las entidades</param>
        /// <param name="valor">Entidad a mofificar</param>
        /// <param name="propiedades">Propiedades a modificar</param>
        /// <returns>Respuesta tipo Sala</returns>
        Task<Respuesta<ISalaDTO>> EditarPorQuerySalaAsync(Expression<Func<ISalaDTO, bool>> filtro, ISalaDTO valor, List<string> propiedades);

        /// <summary>
        /// Metodo consultar lista sala por filtro
        /// </summary>
        /// <param name="filtro">Filtro de las entidades</param>
        /// <returns>Respuesta tipo Sala</returns>
        Task<Respuesta<ISalaDTO>> ConsultarListaSalaPorFiltroAsync(Expression<Func<ISalaDTO, bool>> filtro);

        /// <summary>
        /// Metodo editar sala por filtro
        /// </summary>
        /// <param name="sala">Entidad con los datos a editar</param>
        /// <param name="propiedades">Propiedades a modificar</param>
        /// <returns>Respuesta tipo Sala</returns>
        Task<Respuesta<ISalaDTO>> EditarSalaPorFiltroAsync(ISalaDTO sala, params string[] propiedades);

        /// <summary>
        /// Metodo eliminar lista sala
        /// </summary>
        /// <param name="lista">Lista de entidad a eliminar</param>
        /// <returns>Respuesta tipo Sala</returns>
        Task<Respuesta<ISalaDTO>> EliminarListaSalaAsync(List<ISalaDTO> lista);

        /// <summary>
        /// Metodo editar sala lista
        /// </summary>
        /// <param name="lista">Lista con entidades a modificar</param>
        /// <returns>Respuesta tipo Sala</returns>
        Task<Respuesta<ISalaDTO>> EditarListaSalaAsync(List<ISalaDTO> lista);
    }

    /// <summary>
    /// Interface que define las acciones de la capa de negocioISalaAccion
    /// </summary>
    public interface ISalaNegocioAccion : ISalaAccion
    {
    }
}