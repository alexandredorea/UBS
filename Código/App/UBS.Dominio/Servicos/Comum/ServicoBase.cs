using System.Collections.Generic;
using UBS.Dominio.Interfaces.Repositorios.Comum;
using UBS.Dominio.Interfaces.Servicos.Comum;

namespace UBS.Dominio.Servicos.Comum
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TipoEntidade"></typeparam>
    public abstract class ServicoBase<TipoEntidade> : IServicoBase<TipoEntidade> where TipoEntidade : class
    {
        /// <summary>
        /// Repositório de acesso genérico
        /// </summary>
        private readonly IRepositorioBase<TipoEntidade> _repositorio;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="contexto">Contexto de banco de dados</param>
        public ServicoBase(IRepositorioBase<TipoEntidade> contexto)
        {
            _repositorio = contexto;
        }

        #region CRUD Básico

        /// <summary>
        /// Adicionar uma entidade no banco de dados
        /// </summary>
        /// <param name="endidade">Entidade preenchida</param>
        public void Adicionar(TipoEntidade entidade)
        {
            _repositorio.Adicionar(entidade);
        }

        /// <summary>
        /// Atualiza uma entidade no banco de dados
        /// </summary>
        /// <param name="endidade">Entidade preenchida</param>
        public void Atualizar(TipoEntidade entidade)
        {
            _repositorio.Atualizar(entidade);
        }

        /// <summary>
        /// Remover uma entidade no banco de dados
        /// </summary>
        /// <param name="endidade">Entidade preenchida</param>
        public void Remover(TipoEntidade entidade)
        {
            _repositorio.Remover(entidade);
        }

        /// <summary>
        /// Selecionar entidades no banco de dados
        /// </summary>
        /// <returns>Lista das entidades preenchidas</returns>
        public IEnumerable<TipoEntidade> Selecionar()
        {
            return _repositorio.Selecionar();
        }

        /// <summary>
        /// Selecionar uma entidade no banco de dados
        /// </summary>
        /// <param name="id">Id da chave primária da entidade atual</param>
        /// <returns>Entidade preenchida</returns>
        public TipoEntidade Selecionar(int id)
        {
            return _repositorio.Selecionar(id);
        }

        #endregion

        #region IDisposable Support

        private bool disposedValue = false; // Para detectar chamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: descartar estado gerenciado (objetos gerenciados).
                }

                // TODO: liberar recursos não gerenciados (objetos não gerenciados) e substituir um finalizador abaixo.
                // TODO: definir campos grandes como nulos.

                disposedValue = true;
            }
        }

        // TODO: substituir um finalizador somente se Dispose(bool disposing) acima tiver o código para liberar recursos não gerenciados.
        // ~ServicoBase() {
        //   // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
        //   Dispose(false);
        // }

        // Código adicionado para implementar corretamente o padrão descartável.
        public void Dispose()
        {
            // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
            Dispose(true);
            // TODO: remover marca de comentário da linha a seguir se o finalizador for substituído acima.
            // GC.SuppressFinalize(this);
        }

        #endregion
    }
}
