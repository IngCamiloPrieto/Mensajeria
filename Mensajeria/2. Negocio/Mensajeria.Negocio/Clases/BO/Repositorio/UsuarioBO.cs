// ------------------------------------------------------------------------------------
// <copyright file="UsuarioBO.cs" company="Camilo Prieto">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.Negocio.Clases.BO.Repositorio
{
    using Mensajeria.IC.DTO.Repositorio;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// clase para las propiedades de la entidad Usuario
    /// </summary>
    public class UsuarioBO : IUsuarioDTO
    {
        /// <summary>
        /// Obtiene o establece el Id Usuario
        /// </summary>
        public Guid IdUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece el Celular
        /// </summary>
        public string Celular { get; set; }

        /// <summary>
        /// Obtiene o establece el Apodo
        /// </summary>
        public string Apodo { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica si esta activo o no Estado
        /// </summary>
        public bool Estado { get; set; }

        /// <summary>
        /// Obtiene o establece el Salas
        /// </summary>
        public List<ISalaDTO> Salas { get; set; }
    }
}