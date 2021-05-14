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
        /// Metodo consultar lista sala
        /// </summary>
        /// <returns>Respuesta tipo Sala</returns>
        [HttpGet]
        [Route("ConsultarListaSala")]
        public async Task<Respuesta<Sala>> ConsultarListaSala()
        {
            return await this.EjecutarTransaccionAPI<Task<Respuesta<Sala>>, SalaController>(async () =>
            {
                return Mapeador.MapearObjetoPorJson<Respuesta<Sala>>(await negocioSala.Value.ConsultarListaSalaAsync());
            });
        }

        /// <summary>
        /// Metodo consultar por llave sala
        /// </summary>
        /// <param name="sala">Entidad a consultar</param>
        /// <returns>Respuesta tipo Sala</returns>
        [HttpPost]
        [Route("ConsultarSalaLlave")]
        public async Task<Respuesta<Sala>> ConsultarSalaLlave(Sala sala)
        {
            return await this.EjecutarTransaccionAPI<Task<Respuesta<Sala>>, SalaController>(async () =>
            {
                return Mapeador.MapearObjetoPorJson<Respuesta<Sala>>(await negocioSala.Value.ConsultarSalaLlaveAsync(sala));
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
        /// Metodo editar sala
        /// </summary>
        /// <param name="sala">Entidad a editar</param>
        /// <returns>Respuesta tipo Sala</returns>
        [HttpPut]
        [Route("EditarSala")]
        public async Task<Respuesta<Sala>> EditarSala(Sala sala)
        {
            return await this.EjecutarTransaccionAPI<Task<Respuesta<Sala>>, SalaController>(async () =>
            {
                return Mapeador.MapearObjetoPorJson<Respuesta<Sala>>(await negocioSala.Value.EditarSalaAsync(sala));
            });
        }

        /// <summary>
        /// Metodo eliminar sala
        /// </summary>
        /// <param name="sala">Entidad a eliminar</param>
        /// <returns>Respuesta tipo Sala</returns>
        [HttpDelete]
        [Route("EliminarSala")]
        public async Task<Respuesta<Sala>> EliminarSala(Sala sala)
        {
            return await this.EjecutarTransaccionAPI<Task<Respuesta<Sala>>, SalaController>(async () =>
            {
                return Mapeador.MapearObjetoPorJson<Respuesta<Sala>>(await negocioSala.Value.EliminarSalaAsync(sala));
            });
        }
    }
}