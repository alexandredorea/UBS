using UBS.Dominio.Interfaces.Entidades;

namespace UBS.Dominio.Entidades.Comum
{
    /// <summary>
    /// Classe abstrata de representação para todas as entidades
    /// </summary>
    /// <typeparam name="TipoChave">Tipo da chave primária utilizada para a entidade</typeparam>
    public abstract class EntidadeBase<TipoChave> : IEntidadeBase
    {
        public TipoChave Id { get; set; }

        /// <summary>
        /// Cria um novo objeto que é uma cópia da instância atual
        /// </summary>
        /// <returns>Uma cópia superficial da atual instância</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        /// <summary>
        /// Obtém o Id da entidade atual
        /// </summary>
        /// <returns>Retorna o objeto identificador da chave primária</returns>
        public object ObterId()
        {
            return Id;
        }

        /// <summary>
        /// Obtém o Nome da entidade atual
        /// </summary>
        /// <returns>Retorna o nome da entidade</returns>
        public string ObterNomeEntidade()
        {
            return GetType().Name;
        }
    }
}
