using System;
using System.Collections.Generic;

namespace UBS.Dominio.Interfaces.Servicos.Comum
{
    public interface IServicoBase<TipoEntidade> : IDisposable where TipoEntidade : class
    {
        void Adicionar(TipoEntidade entidade);
        void Atualizar(TipoEntidade entidade);
        void Remover(TipoEntidade entidade);
        IEnumerable<TipoEntidade> Selecionar();
        TipoEntidade Selecionar(int id);
    }
}
