using System;
using System.Collections.Generic;

namespace UBS.Dominio.Interfaces.Servicos.Comum
{
    /// <summary>
    /// Interface de representação básica para os serviços
    /// </summary>
    /// <typeparam name="TipoEntidade">Tipo da Entidade</typeparam>
    public interface IServicoBase<TipoEntidade> : IDisposable where TipoEntidade : class
    {
        /// <summary>
        /// Adicionar uma entidade no banco de dados
        /// </summary>
        /// <param name="endidade">Entidade preenchida</param>
        void Adicionar(TipoEntidade entidade);

        /// <summary>
        /// Atualiza uma entidade no banco de dados
        /// </summary>
        /// <param name="endidade">Entidade preenchida</param>
        void Atualizar(TipoEntidade entidade);

        /// <summary>
        /// Remover uma entidade no banco de dados
        /// </summary>
        /// <param name="endidade">Entidade preenchida</param>
        void Remover(TipoEntidade entidade);

        /// <summary>
        /// Selecionar entidades no banco de dados
        /// </summary>
        /// <returns>Lista das entidades preenchidas</returns>
        IEnumerable<TipoEntidade> Selecionar();

        /// <summary>
        /// Selecionar uma entidade no banco de dados
        /// </summary>
        /// <param name="id">Id da chave primária da entidade atual</param>
        /// <returns>Entidade preenchida</returns>
        TipoEntidade Selecionar(int id);
    }
}
