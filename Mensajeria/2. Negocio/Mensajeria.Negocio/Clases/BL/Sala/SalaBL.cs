// ------------------------------------------------------------------------------------
// <copyright file="SalaBL.cs" company="Camilo Prieto">
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
    using System.Linq;
    using System.Threading.Tasks;
    using TransaccionalNet.Mongo.Interfaces;
    using Utilitarios.TransaccionalNetNet.Mongo.Clases;
    using Utilitarios.TransversalesNet.Clases.Comunes.Enumeraciones;
    using UtilitariosNet.Clases.Comunes.Entidades;

    /// <summary>
    /// Clase con las acciones de negocio de la entidad Sala
    /// </summary>
    public class SalaBL : AccesoComunBL, ISalaNegocioAccion
    {
        #region ATRIBUTOS

        /// <summary>
        /// Objeto para repositorio Sala
        /// </summary>
        private Lazy<ISalaRepositorioAccion> salaRepositorioAccion;

        /// <summary>
        /// Objeto para repositorio Usuario
        /// </summary>
        private Lazy<IUsuarioRepositorioAccion> usuarioRepositorioAccion;

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
        public SalaBL(
            IDatabaseSettings settings,
            Lazy<ISalaRepositorioAccion> argSalaRepositorioAccion = null,
            Lazy<IUsuarioRepositorioAccion> argUsuarioRepositorioAccion = null) : base(settings)
        {
            this.respuesta = new Respuesta<ISalaDTO>();
            this.salaRepositorioAccion = argSalaRepositorioAccion ?? new Lazy<ISalaRepositorioAccion>(() => new SalaDAL(mongoDatabase, this.sessionHandle));
            this.usuarioRepositorioAccion = argUsuarioRepositorioAccion ?? new Lazy<IUsuarioRepositorioAccion>(() => new UsuarioDAL(mongoDatabase, this.sessionHandle));
        }

        #endregion CONSTRUCTORES

        #region METODOS PUBLICOS

        /// <summary>
        /// Metodo consultar salas por usuario
        /// </summary>
        /// <param name="usuario">usuario a filtrar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<ISalaDTO>> ConsultarSalasPorUsuarioAsync(string usuario)
        {
            return await this.EjecutarTransaccionBDAsync<Respuesta<ISalaDTO>, SalaBL>(
           async () =>
           {
               respuesta.Entidades = (await this.usuarioRepositorioAccion.Value.ConsultarListaUsuarioAsync()).Entidades.FirstOrDefault().Salas;
               respuesta.Resultado = true;
               respuesta.TipoNotificacion = TipoNotificacion.Exitoso;
               respuesta.Mensajes.Add(rcsMensajesComunes.MensajeCreacionEdicionExitosa);
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

        /// <summary>
        /// Metodo Unirse a Sala
        /// </summary>
        /// <param name="sala">Identificador de la sala</param>
        /// <param name="usuario">Identificador del usuario</param>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<IUsuarioDTO>> UnirseASalaAsync(string sala, string usuario)
        {
            return await this.EjecutarTransaccionBDAsync<Respuesta<IUsuarioDTO>, SalaBL>(
            async () =>
            {
                Respuesta<IUsuarioDTO> respuesta = new Respuesta<IUsuarioDTO>
                {
                    Resultado = true,
                    TipoNotificacion = TipoNotificacion.Exitoso
                };
                respuesta.Mensajes.Add(rcsMensajesComunes.MensajeCreacionEdicionExitosa);
                return respuesta;
            });
        }

        #endregion METODOS PUBLICOS
    }
}