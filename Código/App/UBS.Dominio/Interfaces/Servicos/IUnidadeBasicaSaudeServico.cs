using System.Collections.Generic;
using UBS.Dominio.Entidades;
using UBS.Dominio.Interfaces.Servicos.Comum;

namespace UBS.Dominio.Interfaces.Servicos
{
    public interface IUnidadeBasicaSaudeServico : IServicoBase<UnidadeBasicaSaude>
    {
        IEnumerable<UnidadeBasicaSaude> Selecionar(double latitude, double longitude);
        IEnumerable<UnidadeBasicaSaude> Selecionar(double latitude, double longitude, int quantidadeRetorno = 5);
    }
}
