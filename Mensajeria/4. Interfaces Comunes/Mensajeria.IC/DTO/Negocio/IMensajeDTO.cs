// ------------------------------------------------------------------------------------
// <copyright file="IMensajeDTO.cs">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.IC.DTO.Negocio
{
    /// <summary>
    /// Interface que define las propiedades de Mensaje
    /// </summary>
    public interface IMensajeDTO
    {
        /// <summary>
        /// Obtiene o establece el Id de la Sala
        /// </summary>
        string IdSala { get; set; }

        /// <summary>
        /// Obtiene o establece el TipoMensaje
        /// </summary>
        int TipoMensaje { get; set; }

        /// <summary>
        /// Obtiene o establece el Mensaje
        /// </summary>
        string Mensaje { get; set; }
    }
}