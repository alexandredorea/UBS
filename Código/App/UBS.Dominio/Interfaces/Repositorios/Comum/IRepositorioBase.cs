using System;
using System.Collections.Generic;

namespace UBS.Dominio.Interfaces.Repositorios.Comum
{
    public interface IRepositorioBase<TipoEntidade> : IDisposable where TipoEntidade : class
    {
        void Adicionar(TipoEntidade entidade);
        void Atualizar(TipoEntidade entidade);
        void Remover(TipoEntidade entidade);
        IEnumerable<TipoEntidade> Selecionar();
        TipoEntidade Selecionar(int id);
    }
}
