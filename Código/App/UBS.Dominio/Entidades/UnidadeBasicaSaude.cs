using UBS.Dominio.Entidades.Comum;

namespace UBS.Dominio.Entidades
{
    public class UnidadeBasicaSaude : EntidadeBase<int>
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Avaliacao { get; set; }
    }
}
