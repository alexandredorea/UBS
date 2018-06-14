using System;

namespace UBS.Dominio.Interfaces.Entidades
{
    /// <summary>
    /// Interface de representação para todas as entidades
    /// </summary>
    public interface IEntidadeBase : ICloneable
    {
        /// <summary>
        /// Obtém o Id da chave primária da entidade atual
        /// </summary>
        /// <returns>Retorna o objeto identificador da chave primária</returns>
        object ObterId();

        /// <summary>
        /// Obtém o Nome da entidade atual
        /// </summary>
        /// <returns>Retorna o nome da entidade</returns>
        string ObterNomeEntidade();
    }
}
