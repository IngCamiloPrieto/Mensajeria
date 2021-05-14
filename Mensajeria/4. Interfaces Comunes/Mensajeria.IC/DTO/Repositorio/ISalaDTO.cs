// ------------------------------------------------------------------------------------
// <copyright file="ISalaDTO.cs" company="Camilo Prieto">
// Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.IC.DTO.Repositorio
{
	using System;

	/// <summary>
	/// Interface que define las propiedades de Sala
	/// </summary>
	public interface ISalaDTO
	{
		/// <summary>
		/// Obtiene o establece el Id Sala
		/// </summary>
		Guid IdSala { get; set; }

		/// <summary>
		/// Obtiene o establece el Nombre Sala
		/// </summary>
		string NombreSala { get; set; }

		/// <summary>
		/// Obtiene o establece el Codigo Sala
		/// </summary>
		string CodigoSala { get; set; }

		/// <summary>
		/// Obtiene o establece el Creador
		/// </summary>
		string Creador { get; set; }

		/// <summary>
		/// Obtiene o establece un valor que indica si esta activo o no Estado
		/// </summary>
		bool Estado { get; set; }
	}
}
