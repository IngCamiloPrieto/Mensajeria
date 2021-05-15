// ------------------------------------------------------------------------------------
// <copyright file="MensajeController.cs" company="Camilo Prieto">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.API.Controllers
{
    using Mensajeria.API.Hubs;
    using Mensajeria.API.Models.Repositorio;
    using Mensajeria.IC.Acciones;
    using Mensajeria.IC.Acciones.Repositorio;
    using Mensajeria.Negocio.Clases.BL;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.SignalR;
    using Newtonsoft.Json;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using TransaccionalNet.Mongo.Interfaces;
    using Utilitarios.APINet.Clases.Ejecucion;
    using UtilitariosNet.Clases.Comunes.Entidades;
    using UtilitariosNet.Clases.Mapeador.Extensiones;

    /// <summary>
    /// Clase con las capaciades Rest de la entidad Mensaje
    /// </summary>
    [Route("api/Mensajeria")]
    public class MensajeController : AccesoComunAPI
    {
        /// <summary>
        /// Objeto para negocio Mensaje
        /// </summary>
        private Lazy<IMensajeNegocioAccion> negocioMensaje;

        /// <summary>
        /// Hub de notificación de mensajes
        /// </summary>
        public IHubContext<MensajeriaHub, IMensajeriaAccionCliente> mensajeria { get; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase MensajeController
        /// </summary>
        public MensajeController(IHubContext<MensajeriaHub, IMensajeriaAccionCliente> argMensajeria, IDatabaseSettings settings)
        {
            this.negocioMensaje = new Lazy<IMensajeNegocioAccion>(
                                        () => new MensajeBL(settings));

            this.mensajeria = argMensajeria;
        }

        /// <summary>
        /// Metodo guardar mensaje
        /// </summary>
        /// <param name="mensaje">Entidad a guardar</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        [HttpPost]
        [Route("EnviarMensaje")]
        public async Task<Respuesta<Mensaje>> GuardarMensaje(Mensaje mensaje)
        {
            return await this.EjecutarTransaccionAPI<Task<Respuesta<Mensaje>>, MensajeController>(async () =>
            {
                Respuesta<Mensaje> respuesta = Mapeador.MapearObjetoPorJson<Respuesta<Mensaje>>(await negocioMensaje.Value.GuardarMensajeAsync(mensaje));
                await mensajeria.Clients.Group(mensaje.IdSala.ToString()).RecibirMensaje(JsonConvert.SerializeObject(respuesta.Entidades.FirstOrDefault()));
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo de validación del servicio
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<bool> Index()
        {
            return true;
        }
    }
}