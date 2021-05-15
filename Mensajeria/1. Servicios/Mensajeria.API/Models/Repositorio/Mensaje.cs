// ------------------------------------------------------------------------------------
// <copyright file="Mensaje.cs" company="Camilo Prieto">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.API.Models.Repositorio
{
    using Mensajeria.IC.DTO.Repositorio;
    using System;

    /// <summary>
    /// clase para las propiedades de la entidad Mensaje
    /// </summary>
    public class Mensaje : IMensajeDTO
    {
        /// <summary>
        /// Obtiene o establece el Id Mensaje
        /// </summary>
        public Guid IdMensaje { get; set; }

        /// <summary>
        /// Obtiene o establece el Id Sala
        /// </summary>
        public Guid IdSala { get; set; }

        /// <summary>
        /// Obtiene o establece el Tipo Mensaje
        /// </summary>
        public int TipoMensaje { get; set; }

        /// <summary>
        /// Obtiene o establece el Mensaje
        /// </summary>
        public string Texto { get; set; }

        /// <summary>
        /// Obtiene o establece el Fecha
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Obtiene o establece el Creador
        /// </summary>
        public string Creador { get; set; }
    }
}