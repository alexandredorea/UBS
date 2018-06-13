using System;

namespace UBS.Dominio.Interfaces.Entidades
{
    public interface IEntidadeBase : ICloneable
    {
        object ObterId();
        string ObterNomeEntidade();
    }
}
