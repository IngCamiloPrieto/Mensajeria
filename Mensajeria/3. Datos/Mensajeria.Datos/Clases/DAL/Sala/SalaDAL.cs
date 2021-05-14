// ------------------------------------------------------------------------------------
// <copyright file="SalaDAL.cs" company="Camilo Prieto">
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
    /// Clase con las acciones de repositorio para la entidad Sala
    /// </summary>
    public class SalaDAL : AccesoComunDAL, ISalaRepositorioAccion
    {
        /// <summary>
        /// Objeto para entidad respuesta
        /// </summary>
        private Respuesta<ISalaDTO> respuesta;

        /// <summary>
        /// Objeto para repositorio Sala
        /// </summary>
        private RepositorioGenerico<Sala> repositorio;

        /// <summary>
        /// Inicializa una nueva instancia de la clase SalaDAL
        /// </summary>
        public SalaDAL(IMongoDatabase database, IClientSessionHandle session)
        {
            this.respuesta = new Respuesta<ISalaDTO>();
            this.repositorio = new RepositorioGenerico<Sala>(database, session);
        }

        /// <summary>
        /// Metodo editar sala
        /// </summary>
        /// <param name="sala">Entidad a editar</param>
        /// <returns>Respuesta tipo Sala</returns>
        public async Task<Respuesta<ISalaDTO>> EditarSalaAsync(ISalaDTO sala)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<ISalaDTO>, SalaDAL>(async () =>
            {
                //SalaDO SalaEntidad = repositorio.BuscarPorFiltro(entidad => entidad
                //    .IdSala == sala.IdSala).FirstOrDefault();
                //Mapeador.MapearObjetosPorPropiedad(sala, SalaEntidad);
                //repositorio.Editar(SalaEntidad);
                //repositorio.Guardar();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo editar sala por filtro
        /// </summary>
        /// <param name="sala">Entidad con los datos a editar</param>
        /// <param name="propiedades">Propiedades a modificar</param>
        /// <returns>Respuesta tipo Sala</returns>
        public async Task<Respuesta<ISalaDTO>> EditarSalaPorFiltroAsync(ISalaDTO sala, params string[] propiedades)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<ISalaDTO>, SalaDAL>(async () =>
            {
                //SalaDO salaEntidad = repositorio.BuscarPor(entidad => entidad
                //.IdSala == sala.IdSala).FirstOrDefault();
                //Mapeador.MapearObjetosPorPropiedadPorFiltro(sala, salaEntidad, propiedades);
                //repositorio.Editar(salaEntidad);
                //repositorio.Guardar();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo editar sala por query
        /// </summary>
        /// <param name="filtro">Filtro de las entidades</param>
        /// <param name="valor">Entidad a mofificar</param>
        /// <param name="propiedades">Propiedades a modificar</param>
        /// <returns>Respuesta tipo Sala</returns>
        public async Task<Respuesta<ISalaDTO>> EditarPorQuerySalaAsync(Expression<Func<ISalaDTO, bool>> filtro, ISalaDTO valor, List<string> propiedades)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<ISalaDTO>, SalaDAL>(async () =>
            {
                //SalaDO SalaEntidad = Mapeador.MapearEntidadDTO(valor, new SalaDO());
                //Expression<Func<SalaDO, bool>> filtros = Mapeador.MapearExpresion<ISalaDTO, SalaDO>(filtro);
                //await repositorio.EditarPorQueryAsync(filtros, SalaEntidad, propiedades);
                //await repositorio.GuardarAsync();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo editar sala lista
        /// </summary>
        /// <param name="lista">Lista con entidades a modificar</param>
        /// <returns>Respuesta tipo Sala</returns>
        public async Task<Respuesta<ISalaDTO>> EditarListaSalaAsync(List<ISalaDTO> lista)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<ISalaDTO>, SalaDAL>(async () =>
            {
                //List<SalaDO> listaSala = new List<SalaDO>();
                //listaSala = Mapeador.MapearALista<ISalaDTO, SalaDO>(lista);
                //await repositorio.EditarListaAsync(listaSala);
                //await repositorio.GuardarAsync();
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
            return await this.EjecutarTransaccionAsync<Respuesta<ISalaDTO>, SalaDAL>(async () =>
            {
                //SalaDO SalaEntidad = repositorio.BuscarPor(entidad => entidad
                //    .IdSala == sala.IdSala).FirstOrDefault();
                //Mapeador.MapearObjetosPorPropiedad(sala, SalaEntidad);
                //repositorio.Eliminar(SalaEntidad);
                //repositorio.Guardar();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo eliminar lista sala
        /// </summary>
        /// <param name="lista">Lista de entidad a eliminar</param>
        /// <returns>Respuesta tipo Sala</returns>
        public async Task<Respuesta<ISalaDTO>> EliminarListaSalaAsync(List<ISalaDTO> lista)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<ISalaDTO>, SalaDAL>(async () =>
            {
                //List<SalaDO> listaSala = new List<SalaDO>();
                //listaSala = Mapeador.MapearALista<ISalaDTO, SalaDO>(lista);
                //await repositorio.EliminarListaAsync(listaSala);
                //await repositorio.GuardarAsync();
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
            return await this.EjecutarTransaccionAsync<Respuesta<ISalaDTO>, SalaDAL>(async () =>
            {
                Sala SalaEntidad = Mapeador.MapearEntidadDTO(sala, new Sala());
                await repositorio.AgregarAsync(SalaEntidad);
                respuesta.Entidades.Add(SalaEntidad);
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo Guardar lista sala
        /// </summary>
        /// <param name="listaSala">Lista de entidades a guardar</param>
        /// <returns>Respuesta tipo Sala</returns>
        public async Task<Respuesta<ISalaDTO>> GuardarListaSalaAsync(List<ISalaDTO> listaSala)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<ISalaDTO>, SalaDAL>(async () =>
            {
                //List<SalaDO> listaSalaEntidad = Mapeador.MapearALista<ISalaDTO, SalaDO>(listaSala);
                //await repositorio.AgregarListaAsync(listaSalaEntidad);
                //respuesta.Entidades.AddRange(listaSalaEntidad);
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo consultar lista sala
        /// </summary>
        /// <returns>Respuesta tipo Sala</returns>
        public async Task<Respuesta<ISalaDTO>> ConsultarListaSalaAsync()
        {
            return await this.EjecutarTransaccionAsync<Respuesta<ISalaDTO>, SalaDAL>(async () =>
            {
                respuesta.Entidades = repositorio.BuscarTodos().ToList<ISalaDTO>();
                return respuesta;
            });
        }

        /// <summary>
        /// Metodo consultar lista sala por filtro
        /// </summary>
        /// <param name="sala">Entidad con los datos a filtrar</param>
        /// <param name="filtro">Filtro de las entidades</param>
        /// <returns>Respuesta tipo Sala</returns>
        public async Task<Respuesta<ISalaDTO>> ConsultarListaSalaPorFiltroAsync(Expression<Func<ISalaDTO, bool>> filtro)
        {
            return await this.EjecutarTransaccionAsync<Respuesta<ISalaDTO>, SalaDAL>(async () =>
            {
                //respuesta.Entidades = repositorio.BuscarPor(Mapeador.MapearExpresion<ISalaDTO, SalaDO>(filtro)).ToList<ISalaDTO>();
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
            return await this.EjecutarTransaccionAsync<Respuesta<ISalaDTO>, SalaDAL>(async () =>
            {
                //respuesta.Entidades = (from entidad in ContextoBD.Sala
                //                       where entidad.IdSala == sala.IdSala
                //                       select entidad).ToList<ISalaDTO>();

                return respuesta;
            });
        }
    }
}