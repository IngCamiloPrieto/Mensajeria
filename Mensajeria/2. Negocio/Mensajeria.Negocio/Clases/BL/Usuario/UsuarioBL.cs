// ------------------------------------------------------------------------------------
// <copyright file="UsuarioBL.cs" company="Camilo Prieto">
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
    /// Clase con las acciones de negocio de la entidad Usuario
    /// </summary>
    public class UsuarioBL : AccesoComunBL, IUsuarioNegocioAccion
    {
        #region ATRIBUTOS

        /// <summary> Objeto para repositorio Usuario <summary> Objeto para acciones Usuario </summary>
        private Lazy<IUsuarioRepositorioAccion> usuarioRepositorioAccion;

        /// <summary>
        /// Objeto para entidad respuesta
        /// </summary>
        private Respuesta<IUsuarioDTO> respuesta;

        #endregion ATRIBUTOS

        #region CONSTRUCTORES

        /// <summary>
        /// Inicializa una nueva instancia de la clase UsuarioBL
        /// </summary>
        /// <param name="argUsuarioRepositorioAccion">Acciones entidad Usuario</param>
        public UsuarioBL(IDatabaseSettings settings, Lazy<IUsuarioRepositorioAccion> argUsuarioRepositorioAccion = null) : base(settings)
        {
            this.respuesta = new Respuesta<IUsuarioDTO>();
            this.usuarioRepositorioAccion = argUsuarioRepositorioAccion ?? new Lazy<IUsuarioRepositorioAccion>(() => new UsuarioDAL(mongoDatabase, this.sessionHandle));
        }

        #endregion CONSTRUCTORES

        #region METODOS PUBLICOS

        /// <summary>
        /// Metodo guardar usuario
        /// </summary>
        /// <param name="usuario">Entidad a guardar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<IUsuarioDTO>> GuardarUsuarioAsync(IUsuarioDTO usuario)
        {
            return await this.EjecutarTransaccionBDAsync<Respuesta<IUsuarioDTO>, UsuarioBL>(
            async () =>
            {
                respuesta = await this.usuarioRepositorioAccion.Value.GuardarUsuarioAsync(usuario);
                respuesta.Resultado = true;
                respuesta.TipoNotificacion = TipoNotificacion.Exitoso;
                respuesta.Mensajes.Add(rcsMensajesComunes.MensajeCreacionEdicionExitosa);
                return respuesta;
            });
        }

        #endregion METODOS PUBLICOS
    }
}