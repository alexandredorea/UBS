using System.Collections.Generic;
using UBS.Dominio.Entidades;
using UBS.Dominio.Interfaces.Repositorios;
using UBS.Dominio.Servicos.Comum;

namespace UBS.Dominio.Servicos
{
    /// <summary>
    /// 
    /// </summary>
    public class UnidadeBasicaSaudeServico : ServicoBase<UnidadeBasicaSaude>, IUnidadeBasicaSaudeRepositorio
    {
        /// <summary>
        /// Repositório de acesso as Unidade Básicas de Saúde
        /// </summary>
        private readonly IUnidadeBasicaSaudeRepositorio _repositorio;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="contexto">Contexto de banco de dados</param>
        public UnidadeBasicaSaudeServico(IUnidadeBasicaSaudeRepositorio contexto) : base(contexto)
        {
            _repositorio = contexto;
        }

        /// <summary>
        /// Selecionar entidades no banco de dados
        /// </summary>
        /// <param name="latitude">Latitude para a coordenada geográfica da Unidade Básica de Saúde</param>
        /// <param name="longitude">Longitude para a coordenada geográfica da Unidade Básica de Saúde</param>
        /// <returns>Lista das entidades preenchidas</returns>
        public IEnumerable<UnidadeBasicaSaude> Selecionar(double latitude, double longitude)
        {
            return _repositorio.Selecionar(latitude, longitude);
        }

        /// <summary>
        /// Selecionar entidades no banco de dados
        /// </summary>
        /// <param name="latitude">Latitude para a coordenada geográfica da Unidade Básica de Saúde</param>
        /// <param name="longitude">Longitude para a coordenada geográfica da Unidade Básica de Saúde</param>
        /// <param name="quantidadeRetorno">Quantidade de dados que deseja retornar</param>
        /// <returns>Lista das entidades preenchidas</returns>
        public IEnumerable<UnidadeBasicaSaude> Selecionar(double latitude, double longitude, int quantidadeRetorno = 5)
        {
            return _repositorio.Selecionar(latitude, longitude, quantidadeRetorno);
        }
    }
}
