// ------------------------------------------------------------------------------------
// <copyright file="UsuarioDO.cs" company="Camilo Prieto">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.Datos.Contexto.Repositorio
{
    using Mensajeria.IC.DTO.Repositorio;
    using MongoDB.Bson.Serialization.Attributes;
    using MongoDB.Bson.Serialization.IdGenerators;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// clase para las propiedades de la entidad Usuario
    /// </summary>
    public partial class Usuario : IUsuarioDTO
    {
        /// <summary>
        /// Obtiene o establece el Id Usuario
        /// </summary>
        [BsonId(IdGenerator = typeof(CombGuidGenerator))]
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