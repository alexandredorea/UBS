using System.Collections.Generic;
using UBS.Dominio.Entidades;
using UBS.Dominio.Interfaces.Repositorios.Comum;

namespace UBS.Dominio.Interfaces.Repositorios
{
    public interface IUnidadeBasicaSaudeRepositorio : IRepositorioBase<UnidadeBasicaSaude>
    {
        IEnumerable<UnidadeBasicaSaude> Selecionar(double latitude, double longitude);
        IEnumerable<UnidadeBasicaSaude> Selecionar(double latitude, double longitude, int quantidadeRetorno = 5);
    }
}
