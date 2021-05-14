// ------------------------------------------------------------------------------------
// <copyright file="SalaBO.cs" company="Camilo Prieto">
// Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.Negocio.Clases.BO.Repositorio
{
	using Mensajeria.IC.DTO.Repositorio;
	using System;

	/// <summary>
	/// clase para las propiedades de la entidad Sala
	/// </summary>
	public class SalaBO : ISalaDTO
	{
		/// <summary>
		/// Obtiene o establece el Id Sala
		/// </summary>
		public Guid IdSala { get; set; }

		/// <summary>
		/// Obtiene o establece el Nombre Sala
		/// </summary>
		public string NombreSala { get; set; }

		/// <summary>
		/// Obtiene o establece el Codigo Sala
		/// </summary>
		public string CodigoSala { get; set; }

		/// <summary>
		/// Obtiene o establece el Creador
		/// </summary>
		public string Creador { get; set; }

		/// <summary>
		/// Obtiene o establece un valor que indica si esta activo o no Estado
		/// </summary>
		public bool Estado { get; set; }

	}
}
