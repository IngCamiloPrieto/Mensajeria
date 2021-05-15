// ------------------------------------------------------------------------------------
// <copyright file="IMensajeDTO.cs" company="Camilo Prieto">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.IC.DTO.Repositorio
{
    using System;

    /// <summary>
    /// Interface que define las propiedades de Mensaje
    /// </summary>
    public interface IMensajeDTO
    {
        /// <summary>
        /// Obtiene o establece el Id Mensaje
        /// </summary>
        Guid IdMensaje { get; set; }

        /// <summary>
        /// Obtiene o establece el Id Sala
        /// </summary>
        Guid IdSala { get; set; }

        /// <summary>
        /// Obtiene o establece el Tipo Mensaje
        /// </summary>
        int TipoMensaje { get; set; }

        /// <summary>
        /// Obtiene o establece el Mensaje
        /// </summary>
        string Texto { get; set; }

        /// <summary>
        /// Obtiene o establece el Fecha
        /// </summary>
        DateTime Fecha { get; set; }

        /// <summary>
        /// Obtiene o establece el Creador
        /// </summary>
        string Creador { get; set; }
    }
}