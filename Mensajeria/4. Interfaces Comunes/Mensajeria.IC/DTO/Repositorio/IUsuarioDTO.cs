// ------------------------------------------------------------------------------------
// <copyright file="IUsuarioDTO.cs" company="Camilo Prieto">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.IC.DTO.Repositorio
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Interface que define las propiedades de Usuario
    /// </summary>
    public interface IUsuarioDTO
    {
        /// <summary>
        /// Obtiene o establece el Id Usuario
        /// </summary>
        Guid IdUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece el Celular
        /// </summary>
        string Celular { get; set; }

        /// <summary>
        /// Obtiene o establece el Apodo
        /// </summary>
        string Apodo { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica si esta activo o no Estado
        /// </summary>
        bool Estado { get; set; }

        /// <summary>
        /// Obtiene o establece las Salas
        /// </summary>
        List<ISalaDTO> Salas { get; set; }
    }
}