// ------------------------------------------------------------------------------------
// <copyright file="SalaController.cs" company="Camilo Prieto">
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
    /// Clase con las capaciades Rest de la entidad Sala
    /// </summary>
    [Route("api/Sala")]
    public class SalaController : AccesoComunAPI
    {
        /// <summary>
        /// Objeto para negocio Sala
        /// </summary>
        private Lazy<ISalaNegocioAccion> negocioSala;

        /// <summary>
        /// Inicializa una nueva instancia de la clase SalaController
        /// </summary>
        public SalaController(IDatabaseSettings settings)
        {
            this.negocioSala = new Lazy<ISalaNegocioAccion>(
                                        () => new SalaBL(settings));
        }

        /// <summary>
        /// Metodo consultar salas por usuario
        /// </summary>
        /// <param name="usuario">Identificador del usuario</param>
        /// <returns>Respuesta tipo Usuario</returns>
        [HttpGet]
        [Route("ConsultarSalasPorUsuario")]
        public async Task<Respuesta<Usuario>> ConsultarSalasPorUsuario(string usuario)
        {
            return await this.EjecutarTransaccionAPI<Task<Respuesta<Usuario>>, SalaController>(async () =>
            {
                return Mapeador.MapearObjetoPorJson<Respuesta<Usuario>>(await negocioSala.Value.ConsultarSalasPorUsuarioAsync(usuario));
            });
        }

        /// <summary>
        /// Metodo guardar sala
        /// </summary>
        /// <param name="sala">Entidad a guardar</param>
        /// <returns>Respuesta tipo Sala</returns>
        [HttpPost]
        [Route("GuardarSala")]
        public async Task<Respuesta<Sala>> GuardarSala(Sala sala)
        {
            return await this.EjecutarTransaccionAPI<Task<Respuesta<Sala>>, SalaController>(async () =>
            {
                return Mapeador.MapearObjetoPorJson<Respuesta<Sala>>(await negocioSala.Value.GuardarSalaAsync(sala));
            });
        }

        /// <summary>
        /// Metodo Unirse a Sala
        /// </summary>
        /// <param name="sala">Identificador de la sala</param>
        /// <param name="usuario">Identificador del usuario</param>
        /// <returns>Respuesta tipo Usuario</returns>
        [HttpPost]
        [Route("UnirseASala")]
        public async Task<Respuesta<Usuario>> UnirseASala(string sala, string usuario)
        {
            return await this.EjecutarTransaccionAPI<Task<Respuesta<Usuario>>, SalaController>(async () =>
            {
                return Mapeador.MapearObjetoPorJson<Respuesta<Usuario>>(await negocioSala.Value.UnirseASalaAsync(sala, usuario));
            });
        }
    }
}