// ------------------------------------------------------------------------------------
// <copyright file="IMensajeAccion.cs" company="Camilo Prieto">
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
    /// Interface que define las acciones que se implmentara en todas las capas de IMensajeAccion
    /// </summary>
    public interface IMensajeAccion
    {
        /// <summary>
        /// Metodo guardar mensaje
        /// </summary>
        /// <param name="mensaje">Entidad a guardar</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        Task<Respuesta<IMensajeDTO>> GuardarMensajeAsync(IMensajeDTO mensaje);
    }

    /// <summary>
    /// Interface que define las acciones de la capa de repositorioIMensajeAccion
    /// </summary>
    public interface IMensajeRepositorioAccion : IMensajeAccion
    {
        /// <summary>
        /// Metodo consultar lista mensaje por filtro
        /// </summary>
        /// <param name="filtro">Filtro de las entidades</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        Task<Respuesta<IMensajeDTO>> ConsultarListaMensajePorFiltroAsync(Expression<Func<IMensajeDTO, bool>> filtro);

        /// <summary>
        /// Metodo consultar por llave mensaje
        /// </summary>
        /// <param name="mensaje">Entidad a consultar</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        Task<Respuesta<IMensajeDTO>> ConsultarMensajeLlaveAsync(IMensajeDTO mensaje);

        /// <summary>
        /// Metodo consultar lista mensaje
        /// </summary>
        /// <returns>Respuesta tipo Mensaje</returns>
        Task<Respuesta<IMensajeDTO>> ConsultarListaMensajeAsync();
    }

    /// <summary>
    /// Interface que define las acciones de la capa de negocioIMensajeAccion
    /// </summary>
    public interface IMensajeNegocioAccion : IMensajeAccion
    {
    }
}