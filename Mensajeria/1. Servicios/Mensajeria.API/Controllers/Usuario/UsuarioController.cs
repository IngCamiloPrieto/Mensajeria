// ------------------------------------------------------------------------------------
// <copyright file="UsuarioController.cs" company="Camilo Prieto">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.API.Controllers
{
    using Mensajeria.API.Models.Repositorio;
    using Mensajeria.IC.Acciones.Repositorio;
    using Mensajeria.Negocio.Clases.BL;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Threading.Tasks;
    using TransaccionalNet.Mongo.Interfaces;
    using Utilitarios.APINet.Clases.Ejecucion;
    using UtilitariosNet.Clases.Comunes.Entidades;
    using UtilitariosNet.Clases.Mapeador.Extensiones;

    /// <summary>
    /// Clase con las capaciades Rest de la entidad Usuario
    /// </summary>
    [Route("api/Usuario")]
    public class UsuarioController : AccesoComunAPI
    {
        /// <summary>
        /// Objeto para negocio Usuario
        /// </summary>
        private Lazy<IUsuarioNegocioAccion> negocioUsuario;

        /// <summary>
        /// Inicializa una nueva instancia de la clase UsuarioController
        /// </summary>
        public UsuarioController(IDatabaseSettings settings)
        {
            this.negocioUsuario = new Lazy<IUsuarioNegocioAccion>(
                                        () => new UsuarioBL(settings));
        }

        /// <summary>
        /// Metodo guardar usuario
        /// </summary>
        /// <param name="usuario">Entidad a guardar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        [HttpPost]
        [Route("GuardarUsuario")]
        public async Task<Respuesta<Usuario>> GuardarUsuario(Usuario usuario)
        {
            return await this.EjecutarTransaccionAPI<Task<Respuesta<Usuario>>, UsuarioController>(async () =>
            {
                return Mapeador.MapearObjetoPorJson<Respuesta<Usuario>>(await negocioUsuario.Value.GuardarUsuarioAsync(usuario));
            });
        }
    }
}