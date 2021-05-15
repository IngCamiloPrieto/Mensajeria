// ------------------------------------------------------------------------------------
// <copyright file="MensajeBL.cs" company="Camilo Prieto">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.Negocio.Clases.BL
{
    using Mensajeria.Datos.Clases.DAL.Repositorio;
    using Mensajeria.IC.Acciones.Repositorio;
    using Mensajeria.IC.DTO.Repositorio;
    using Mensajeria.IC.Recursos;
    using System;
    using System.Threading.Tasks;
    using TransaccionalNet.Mongo.Interfaces;
    using Utilitarios.TransaccionalNetNet.Mongo.Clases;
    using Utilitarios.TransversalesNet.Clases.Comunes.Enumeraciones;
    using UtilitariosNet.Clases.Comunes.Entidades;

    /// <summary>
    /// Clase con las acciones de negocio de la entidad Mensaje
    /// </summary>
    public class MensajeBL : AccesoComunBL, IMensajeNegocioAccion
    {
        #region ATRIBUTOS

        /// <summary>
        /// Objeto para repositorio Mensaje
        /// </summary>
        private Lazy<IMensajeRepositorioAccion> mensajeRepositorioAccion;

        /// <summary>
        /// Objeto para entidad respuesta
        /// </summary>
        private Respuesta<IMensajeDTO> respuesta;

        #endregion ATRIBUTOS

        #region CONSTRUCTORES

        /// <summary>
        /// Inicializa una nueva instancia de la clase MensajeBL
        /// </summary>
        /// <param name="argMensajeRepositorioAccion">Acciones entidad Mensaje</param>
        public MensajeBL(IDatabaseSettings settings, Lazy<IMensajeRepositorioAccion> argMensajeRepositorioAccion = null) : base(settings)
        {
            this.respuesta = new Respuesta<IMensajeDTO>();
            this.mensajeRepositorioAccion = argMensajeRepositorioAccion ?? new Lazy<IMensajeRepositorioAccion>(() => new MensajeDAL(mongoDatabase, this.sessionHandle));
        }

        #endregion CONSTRUCTORES

        #region METODOS PUBLICOS

        /// <summary>
        /// Metodo guardar mensaje
        /// </summary>
        /// <param name="mensaje">Entidad a guardar</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        public async Task<Respuesta<IMensajeDTO>> GuardarMensajeAsync(IMensajeDTO mensaje)
        {
            return await this.EjecutarTransaccionBDAsync<Respuesta<IMensajeDTO>, MensajeBL>(
            async () =>
            {
                respuesta = await this.mensajeRepositorioAccion.Value.GuardarMensajeAsync(mensaje);
                respuesta.Resultado = true;
                respuesta.TipoNotificacion = TipoNotificacion.Exitoso;
                respuesta.Mensajes.Add(rcsMensajesComunes.MensajeCreacionEdicionExitosa);
                return respuesta;
            });
        }

        #endregion METODOS PUBLICOS
    }
}