// ------------------------------------------------------------------------------------
// <copyright file="IMensajeDTO.cs">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------

namespace Mensajeria.API.Models.Negocio
{
    using Mensajeria.IC.DTO.Negocio;

    /// <summary>
    /// Clase que define las propiedades de Mensaje
    /// </summary>
    public class MensajeModel : IMensajeDTO
    {
        /// <summary>
        /// Obtiene o establece el Id de la Sala
        /// </summary>
        public string IdSala { get; set; }

        /// <summary>
        /// Obtiene o establece el TipoMensaje
        /// </summary>
        public int TipoMensaje { get; set; }

        /// <summary>
        /// Obtiene o establece el Mensaje
        /// </summary>
        public string Mensaje { get; set; }
    }
}