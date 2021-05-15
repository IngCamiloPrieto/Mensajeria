// ------------------------------------------------------------------------------------
// <copyright file="MensajeDAL.cs" company="Camilo Prieto">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.Datos.Clases.DAL.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using Mensajeria.Datos.Contexto;
    using Mensajeria.Datos.Contexto.Repositorio;
    using Mensajeria.IC.Acciones.Repositorio;
    using Mensajeria.IC.DTO.Repositorio;
    using MongoDB.Driver;
    using TransaccionalNet.Mongo.Clases;
    using Utilitarios.TransaccionalNet.Mongo.Clases;
    using UtilitariosNet.Clases.Comunes.Entidades;
    using UtilitariosNet.Clases.Mapeador.Extensiones;

    /// <summary>
    /// Clase con las acciones de repositorio para la entidad Mensaje
    /// </summary>
    public class MensajeDAL : AccesoComunDAL, IMensajeRepositorioAccion
    {
        /// <summary>
        /// Objeto para entidad respuesta
        /// </summary>
        private Respuesta<IMensajeDTO> respuesta;

        /// <summary>
        /// Objeto para repositorio Mensaje
        /// </summary>
        private RepositorioGenerico<Mensaje> repositorio;

        /// <summary>
        /// Inicializa una nueva instancia de la clase MensajeDAL
        /// </summary>
        public MensajeDAL(IMongoDatabase database, IClientSessionHandle session)
        {
            this.respuesta = new Respuesta<IMensajeDTO>();
            this.repositorio = new RepositorioGenerico<Mensaje>(database, session);
        }

        /// <summary>
        /// Metodo editar mensaje
        /// </summary>
        /// <param name="mensaje">Entidad a editar</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        public async Task<Respuesta<IMensajeDTO>> EditarMensajeAsync(IMensajeDTO mensaje)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IMensajeDTO>, MensajeDAL>(async () =>
            {
                //Mensaje MensajeEntidad = repositorio.BuscarPor(entidad => entidad
                //    .IdMensaje == mensaje.IdMensaje).FirstOrDefault();
                //Mapeador.MapearObjetosPorPropiedad(mensaje, MensajeEntidad);
                //repositorio.Editar(MensajeEntidad);
                //repositorio.Guardar();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo editar mensaje por filtro
        /// </summary>
        /// <param name="mensaje">Entidad con los datos a editar</param>
        /// <param name="propiedades">Propiedades a modificar</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        public async Task<Respuesta<IMensajeDTO>> EditarMensajePorFiltroAsync(IMensajeDTO mensaje, params string[] propiedades)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IMensajeDTO>, MensajeDAL>(async () =>
            {
                //Mensaje mensajeEntidad = repositorio.BuscarPor(entidad => entidad
                //.IdMensaje == mensaje.IdMensaje).FirstOrDefault();
                //Mapeador.MapearObjetosPorPropiedadPorFiltro(mensaje, mensajeEntidad, propiedades);
                //repositorio.Editar(mensajeEntidad);
                //repositorio.Guardar();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo editar mensaje por query
        /// </summary>
        /// <param name="filtro">Filtro de las entidades</param>
        /// <param name="valor">Entidad a mofificar</param>
        /// <param name="propiedades">Propiedades a modificar</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        public async Task<Respuesta<IMensajeDTO>> EditarPorQueryMensajeAsync(Expression<Func<IMensajeDTO, bool>> filtro, IMensajeDTO valor, List<string> propiedades)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IMensajeDTO>, MensajeDAL>(async () =>
            {
                //Mensaje MensajeEntidad = Mapeador.MapearEntidadDTO(valor, new Mensaje());
                //Expression<Func<Mensaje, bool>> filtros = Mapeador.MapearExpresion<IMensajeDTO, Mensaje>(filtro);
                //await repositorio.EditarPorQueryAsync(filtros, MensajeEntidad, propiedades);
                //await repositorio.GuardarAsync();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo editar mensaje lista
        /// </summary>
        /// <param name="lista">Lista con entidades a modificar</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        public async Task<Respuesta<IMensajeDTO>> EditarListaMensajeAsync(List<IMensajeDTO> lista)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IMensajeDTO>, MensajeDAL>(async () =>
            {
                //List<Mensaje> listaMensaje = new List<Mensaje>();
                //listaMensaje = Mapeador.MapearALista<IMensajeDTO, Mensaje>(lista);
                //await repositorio.EditarListaAsync(listaMensaje);
                //await repositorio.GuardarAsync();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo eliminar mensaje
        /// </summary>
        /// <param name="mensaje">Entidad a eliminar</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        public async Task<Respuesta<IMensajeDTO>> EliminarMensajeAsync(IMensajeDTO mensaje)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IMensajeDTO>, MensajeDAL>(async () =>
            {
                //Mensaje MensajeEntidad = repositorio.BuscarPor(entidad => entidad
                //    .IdMensaje == mensaje.IdMensaje).FirstOrDefault();
                //Mapeador.MapearObjetosPorPropiedad(mensaje, MensajeEntidad);
                //repositorio.Eliminar(MensajeEntidad);
                //repositorio.Guardar();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo eliminar lista mensaje
        /// </summary>
        /// <param name="lista">Lista de entidad a eliminar</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        public async Task<Respuesta<IMensajeDTO>> EliminarListaMensajeAsync(List<IMensajeDTO> lista)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IMensajeDTO>, MensajeDAL>(async () =>
            {
                //List<Mensaje> listaMensaje = new List<Mensaje>();
                //listaMensaje = Mapeador.MapearALista<IMensajeDTO, Mensaje>(lista);
                //await repositorio.EliminarListaAsync(listaMensaje);
                //await repositorio.GuardarAsync();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo guardar mensaje
        /// </summary>
        /// <param name="mensaje">Entidad a guardar</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        public async Task<Respuesta<IMensajeDTO>> GuardarMensajeAsync(IMensajeDTO mensaje)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IMensajeDTO>, MensajeDAL>(async () =>
            {
                Mensaje MensajeEntidad = Mapeador.MapearEntidadDTO(mensaje, new Mensaje());
                await repositorio.AgregarAsync(MensajeEntidad);
                respuesta.Entidades.Add(MensajeEntidad);
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo Guardar lista mensaje
        /// </summary>
        /// <param name="listaMensaje">Lista de entidades a guardar</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        public async Task<Respuesta<IMensajeDTO>> GuardarListaMensajeAsync(List<IMensajeDTO> listaMensaje)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IMensajeDTO>, MensajeDAL>(async () =>
            {
                List<Mensaje> listaMensajeEntidad = Mapeador.MapearALista<IMensajeDTO, Mensaje>(listaMensaje);
                await repositorio.AgregarListaAsync(listaMensajeEntidad);
                respuesta.Entidades.AddRange(listaMensajeEntidad);
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo consultar lista mensaje
        /// </summary>
        /// <returns>Respuesta tipo Mensaje</returns>
        public async Task<Respuesta<IMensajeDTO>> ConsultarListaMensajeAsync()
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IMensajeDTO>, MensajeDAL>(async () =>
            {
                respuesta.Entidades = repositorio.BuscarTodos().ToList<IMensajeDTO>();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo consultar lista mensaje por filtro
        /// </summary>
        /// <param name="mensaje">Entidad con los datos a filtrar</param>
        /// <param name="filtro">Filtro de las entidades</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        public async Task<Respuesta<IMensajeDTO>> ConsultarListaMensajePorFiltroAsync(Expression<Func<IMensajeDTO, bool>> filtro)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IMensajeDTO>, MensajeDAL>(async () =>
            {
                //respuesta.Entidades = repositorio.BuscarPor(Mapeador.MapearExpresion<IMensajeDTO, Mensaje>(filtro)).ToList<IMensajeDTO>();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo consultar por llave mensaje
        /// </summary>
        /// <param name="mensaje">Entidad a consultar</param>
        /// <returns>Respuesta tipo Mensaje</returns>
        public async Task<Respuesta<IMensajeDTO>> ConsultarMensajeLlaveAsync(IMensajeDTO mensaje)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IMensajeDTO>, MensajeDAL>(async () =>
            {
                //respuesta.Entidades = (from entidad in ContextoBD.Mensaje
                //                       where entidad.IdMensaje == mensaje.IdMensaje
                //                       select entidad).ToList<IMensajeDTO>();

                return respuesta;
            });
        }
    }
}