using System.Collections.Generic;
using UBS.Dominio.Entidades;
using UBS.Dominio.Interfaces.Servicos.Comum;

namespace UBS.Dominio.Interfaces.Servicos
{
    /// <summary>
    /// Interface de representação das Unidades Básicas de Saúde para os serviços
    /// </summary>
    public interface IUnidadeBasicaSaudeServico : IServicoBase<UnidadeBasicaSaude>
    {
        /// <summary>
        /// Selecionar entidades no banco de dados
        /// </summary>
        /// <param name="latitude">Latitude para a coordenada geográfica da Unidade Básica de Saúde</param>
        /// <param name="longitude">Longitude para a coordenada geográfica da Unidade Básica de Saúde</param>
        /// <returns>Lista das entidades preenchidas</returns>
        IEnumerable<UnidadeBasicaSaude> Selecionar(double latitude, double longitude);

        /// <summary>
        /// Selecionar entidades no banco de dados
        /// </summary>
        /// <param name="latitude">Latitude para a coordenada geográfica da Unidade Básica de Saúde</param>
        /// <param name="longitude">Longitude para a coordenada geográfica da Unidade Básica de Saúde</param>
        /// <param name="quantidadeRetorno">Quantidade de dados que deseja retornar</param>
        /// <returns>Lista das entidades preenchidas</returns>
        IEnumerable<UnidadeBasicaSaude> Selecionar(double latitude, double longitude, int quantidadeRetorno = 5);
    }
}
