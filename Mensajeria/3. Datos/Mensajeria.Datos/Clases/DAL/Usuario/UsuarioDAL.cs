// ------------------------------------------------------------------------------------
// <copyright file="UsuarioDAL.cs" company="Camilo Prieto">
//     Copyright (c) Camilo Prieto. All rights reserved.
// </copyright>
// <author>Camilo Prieto</author>
// ------------------------------------------------------------------------------------
namespace Mensajeria.Datos.Clases.DAL.Repositorio
{
    using Mensajeria.Datos.Contexto.Repositorio;
    using Mensajeria.IC.Acciones.Repositorio;
    using Mensajeria.IC.DTO.Repositorio;
    using MongoDB.Driver;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using TransaccionalNet.Mongo.Clases;
    using Utilitarios.TransaccionalNet.Mongo.Clases;
    using UtilitariosNet.Clases.Comunes.Entidades;
    using UtilitariosNet.Clases.Mapeador.Extensiones;

    /// <summary>
    /// Clase con las acciones de repositorio para la entidad Usuario
    /// </summary>
    public class UsuarioDAL : AccesoComunDAL, IUsuarioRepositorioAccion
    {
        /// <summary>
        /// Objeto para entidad respuesta
        /// </summary>
        private Respuesta<IUsuarioDTO> respuesta;

        /// <summary>
        /// Objeto para repositorio Usuario
        /// </summary>
        private RepositorioGenerico<Usuario> repositorio;

        /// <summary>
        /// Inicializa una nueva instancia de la clase UsuarioDAL
        /// </summary>
        public UsuarioDAL(IMongoDatabase database, IClientSessionHandle session)
        {
            this.respuesta = new Respuesta<IUsuarioDTO>();
            this.repositorio = new RepositorioGenerico<Usuario>(database, session);
        }

        /// <summary>
        /// Metodo editar usuario
        /// </summary>
        /// <param name="usuario">Entidad a editar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<IUsuarioDTO>> EditarUsuarioAsync(IUsuarioDTO usuario)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IUsuarioDTO>, UsuarioDAL>(async () =>
            {
                //Usuario UsuarioEntidad = repositorio.BuscarPor(entidad => entidad
                //    .IdUsuario == usuario.IdUsuario).FirstOrDefault();
                //Mapeador.MapearObjetosPorPropiedad(usuario, UsuarioEntidad);
                //repositorio.Editar(UsuarioEntidad);
                //repositorio.Guardar();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo editar usuario por filtro
        /// </summary>
        /// <param name="usuario">Entidad con los datos a editar</param>
        /// <param name="propiedades">Propiedades a modificar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<IUsuarioDTO>> EditarUsuarioPorFiltroAsync(IUsuarioDTO usuario, params string[] propiedades)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IUsuarioDTO>, UsuarioDAL>(async () =>
            {
                //Usuario usuarioEntidad = repositorio.BuscarPor(entidad => entidad
                //.IdUsuario == usuario.IdUsuario).FirstOrDefault();
                //Mapeador.MapearObjetosPorPropiedadPorFiltro(usuario, usuarioEntidad, propiedades);
                //repositorio.Editar(usuarioEntidad);
                //      repositorio.Guardar();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo editar usuario por query
        /// </summary>
        /// <param name="filtro">Filtro de las entidades</param>
        /// <param name="valor">Entidad a mofificar</param>
        /// <param name="propiedades">Propiedades a modificar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<IUsuarioDTO>> EditarPorQueryUsuarioAsync(Expression<Func<IUsuarioDTO, bool>> filtro, IUsuarioDTO valor, List<string> propiedades)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IUsuarioDTO>, UsuarioDAL>(async () =>
            {
                //Usuario UsuarioEntidad = Mapeador.MapearEntidadDTO(valor, new Usuario());
                //      Expression<Func<Usuario, bool>> filtros = Mapeador.MapearExpresion<IUsuarioDTO, Usuario>(filtro);
                //      await repositorio.EditarPorQueryAsync(filtros, UsuarioEntidad, propiedades);
                //      await repositorio.GuardarAsync();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo editar usuario lista
        /// </summary>
        /// <param name="lista">Lista con entidades a modificar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<IUsuarioDTO>> EditarListaUsuarioAsync(List<IUsuarioDTO> lista)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IUsuarioDTO>, UsuarioDAL>(async () =>
            {
                // List<Usuario> listaUsuario = new List<Usuario>();
                // listaUsuario = Mapeador.MapearALista<IUsuarioDTO, Usuario>(lista);
                //await repositorio.EditarListaAsync(listaUsuario);
                //await repositorio.GuardarAsync();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo eliminar usuario
        /// </summary>
        /// <param name="usuario">Entidad a eliminar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<IUsuarioDTO>> EliminarUsuarioAsync(IUsuarioDTO usuario)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IUsuarioDTO>, UsuarioDAL>(async () =>
            {
                //Usuario UsuarioEntidad = repositorio.BuscarPor(entidad => entidad
                //	.IdUsuario == usuario.IdUsuario).FirstOrDefault();
                //Mapeador.MapearObjetosPorPropiedad(usuario, UsuarioEntidad);
                //repositorio.Eliminar(UsuarioEntidad);
                //            repositorio.Guardar();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo eliminar lista usuario
        /// </summary>
        /// <param name="lista">Lista de entidad a eliminar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<IUsuarioDTO>> EliminarListaUsuarioAsync(List<IUsuarioDTO> lista)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IUsuarioDTO>, UsuarioDAL>(async () =>
            {
                // List<Usuario> listaUsuario = new List<Usuario>();
                // listaUsuario = Mapeador.MapearALista<IUsuarioDTO, Usuario>(lista);
                //await repositorio.EliminarListaAsync(listaUsuario);
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo guardar usuario
        /// </summary>
        /// <param name="usuario">Entidad a guardar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<IUsuarioDTO>> GuardarUsuarioAsync(IUsuarioDTO usuario)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IUsuarioDTO>, UsuarioDAL>(async () =>
            {
                Usuario UsuarioEntidad = Mapeador.MapearEntidadDTO(usuario, new Usuario());
                await repositorio.AgregarAsync(UsuarioEntidad);
                respuesta.Entidades.Add(UsuarioEntidad);
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo Guardar lista usuario
        /// </summary>
        /// <param name="listaUsuario">Lista de entidades a guardar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<IUsuarioDTO>> GuardarListaUsuarioAsync(List<IUsuarioDTO> listaUsuario)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IUsuarioDTO>, UsuarioDAL>(async () =>
            {
                List<Usuario> listaUsuarioEntidad = Mapeador.MapearALista<IUsuarioDTO, Usuario>(listaUsuario);
                await repositorio.AgregarListaAsync(listaUsuarioEntidad);
                respuesta.Entidades.AddRange(listaUsuarioEntidad);
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo consultar lista usuario
        /// </summary>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<IUsuarioDTO>> ConsultarListaUsuarioAsync()
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IUsuarioDTO>, UsuarioDAL>(async () =>
            {
                respuesta.Entidades = repositorio.BuscarTodos().ToList<IUsuarioDTO>();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo consultar lista usuario por filtro
        /// </summary>
        /// <param name="usuario">Entidad con los datos a filtrar</param>
        /// <param name="filtro">Filtro de las entidades</param>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<IUsuarioDTO>> ConsultarListaUsuarioPorFiltroAsync(Expression<Func<IUsuarioDTO, bool>> filtro)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IUsuarioDTO>, UsuarioDAL>(async () =>
            {
                //respuesta.Entidades = repositorio.BuscarPor(Mapeador.MapearExpresion<IUsuarioDTO, Usuario>(filtro)).ToList<IUsuarioDTO>();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo consultar por llave usuario
        /// </summary>
        /// <param name="usuario">Entidad a consultar</param>
        /// <returns>Respuesta tipo Usuario</returns>
        public async Task<Respuesta<IUsuarioDTO>> ConsultarUsuarioLlaveAsync(IUsuarioDTO usuario)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<IUsuarioDTO>, UsuarioDAL>(async () =>
            {
                //respuesta.Entidades = (from entidad in ContextoBD.Usuario
                //                       where entidad.IdUsuario == usuario.IdUsuario
                //                       select entidad).ToList<IUsuarioDTO>();

                return respuesta;
            });
        }
    }
}