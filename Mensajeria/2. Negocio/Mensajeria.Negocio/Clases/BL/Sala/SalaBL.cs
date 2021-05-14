// ------------------------------------------------------------------------------------
// <copyright file="SalaBL.cs" company="Camilo Prieto">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.Negocio.Clases.BL
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mensajeria.IC.Acciones.Repositorio;
    using Mensajeria.IC.DTO.Repositorio;
    using Mensajeria.IC.Recursos;
    using UtilitariosNet.Clases.Comunes.Entidades;
    using Utilitarios.TransversalesNet.Clases.Comunes.Enumeraciones;
    using Utilitarios.TransaccionalNetNet.Mongo.Clases;
    using TransaccionalNet.Mongo.Interfaces;
    using Mensajeria.Datos.Clases.DAL.Repositorio;
    using MongoDB.Driver;

    /// <summary>
    /// Clase con las acciones de negocio de la entidad Sala
    /// </summary>
    public class SalaBL : AccesoComunBL, ISalaNegocioAccion
    {
        #region ATRIBUTOS

        /// <summary> Objeto para repositorio Sala <summary> Objeto para acciones Sala </summary>
        private Lazy<ISalaRepositorioAccion> salaRepositorioAccion;

        /// <summary>
        /// Objeto para entidad respuesta
        /// </summary>
        private Respuesta<ISalaDTO> respuesta;

        #endregion ATRIBUTOS

        #region CONSTRUCTORES

        /// <summary>
        /// Inicializa una nueva instancia de la clase SalaBL
        /// </summary>
        /// <param name="argSalaRepositorioAccion">Acciones entidad Sala</param>
        public SalaBL(IDatabaseSettings settings, Lazy<ISalaRepositorioAccion> argSalaRepositorioAccion = null) : base(settings)
        {
            this.respuesta = new Respuesta<ISalaDTO>();
            this.salaRepositorioAccion = argSalaRepositorioAccion ?? new Lazy<ISalaRepositorioAccion>(() => new SalaDAL(mongoDatabase, this.sessionHandle));
        }

        #endregion CONSTRUCTORES

        #region METODOS PUBLICOS

        /// <summary>
        /// Metodo consultar lista sala
        /// </summary>
        /// <returns>Respuesta tipo Sala</returns>
        public async Task<Respuesta<ISalaDTO>> ConsultarListaSalaAsync()
        {
            return await this.EjecutarTransaccionBDAsync<Respuesta<ISalaDTO>, SalaBL>(
            async () =>
            {
                respuesta = await this.salaRepositorioAccion.Value.ConsultarListaSalaAsync();
                respuesta.Resultado = true;
                respuesta.TipoNotificacion = TipoNotificacion.Exitoso;
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo consultar por llave sala
        /// </summary>
        /// <param name="sala">Entidad a consultar</param>
        /// <returns>Respuesta tipo Sala</returns>
        public async Task<Respuesta<ISalaDTO>> ConsultarSalaLlaveAsync(ISalaDTO sala)
        {
            return await this.EjecutarTransaccionBDAsync<Respuesta<ISalaDTO>, SalaBL>(
            async () =>
            {
                respuesta = await this.salaRepositorioAccion.Value.ConsultarSalaLlaveAsync(sala);
                respuesta.Resultado = true;
                respuesta.TipoNotificacion = TipoNotificacion.Exitoso;
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo editar sala
        /// </summary>
        /// <param name="sala">Entidad a editar</param>
        /// <returns>Respuesta tipo Sala</returns>
        public async Task<Respuesta<ISalaDTO>> EditarSalaAsync(ISalaDTO sala)
        {
            return await this.EjecutarTransaccionBDAsync<Respuesta<ISalaDTO>, SalaBL>(
            async () =>
            {
                respuesta = await this.salaRepositorioAccion.Value.EditarSalaAsync(sala);
                respuesta.Resultado = true;
                respuesta.TipoNotificacion = TipoNotificacion.Exitoso;
                respuesta.Mensajes.Add(rcsMensajesComunes.MensajeCreacionEdicionExitosa);
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo eliminar sala
        /// </summary>
        /// <param name="sala">Entidad a eliminar</param>
        /// <returns>Respuesta tipo Sala</returns>
        public async Task<Respuesta<ISalaDTO>> EliminarSalaAsync(ISalaDTO sala)
        {
            return await this.EjecutarTransaccionBDAsync<Respuesta<ISalaDTO>, SalaBL>(
            async () =>
            {
                respuesta = await this.salaRepositorioAccion.Value.EliminarSalaAsync(sala);
                respuesta.Resultado = true;
                respuesta.TipoNotificacion = TipoNotificacion.Exitoso;
                respuesta.Mensajes.Add(rcsMensajesComunes.MensajeEntidadEliminadaConExito);
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo guardar sala
        /// </summary>
        /// <param name="sala">Entidad a guardar</param>
        /// <returns>Respuesta tipo Sala</returns>
        public async Task<Respuesta<ISalaDTO>> GuardarSalaAsync(ISalaDTO sala)
        {
            return await this.EjecutarTransaccionBDAsync<Respuesta<ISalaDTO>, SalaBL>(
            async () =>
            {
                respuesta = await this.salaRepositorioAccion.Value.GuardarSalaAsync(sala);
                respuesta.Resultado = true;
                respuesta.TipoNotificacion = TipoNotificacion.Exitoso;
                respuesta.Mensajes.Add(rcsMensajesComunes.MensajeCreacionEdicionExitosa);
                return respuesta;
            });
        }

        #endregion METODOS PUBLICOS
    }
}