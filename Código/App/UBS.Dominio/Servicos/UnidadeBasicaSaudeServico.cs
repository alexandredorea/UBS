using System.Collections.Generic;
using UBS.Dominio.Entidades;
using UBS.Dominio.Interfaces.Repositorios;
using UBS.Dominio.Servicos.Comum;

namespace UBS.Dominio.Servicos
{
    public class UnidadeBasicaSaudeServico : ServicoBase<UnidadeBasicaSaude>, IUnidadeBasicaSaudeRepositorio
    {
        private readonly IUnidadeBasicaSaudeRepositorio _repositorio;

        public UnidadeBasicaSaudeServico(IUnidadeBasicaSaudeRepositorio contexto) : base(contexto)
        {
            _repositorio = contexto;
        }
        public IEnumerable<UnidadeBasicaSaude> Selecionar(double latitude, double longitude)
        {
            return _repositorio.Selecionar(latitude, longitude);
        }

        public IEnumerable<UnidadeBasicaSaude> Selecionar(double latitude, double longitude, int quantidadeRetorno = 5)
        {
            return _repositorio.Selecionar(latitude, longitude, quantidadeRetorno);
        }
    }
}
