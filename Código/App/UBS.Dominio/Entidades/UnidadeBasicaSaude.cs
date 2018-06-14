using UBS.Dominio.Entidades.Comum;

namespace UBS.Dominio.Entidades
{
    /// <summary>
    /// Classe de representação para as Unidades Básicas de Saúde
    /// </summary>
    public class UnidadeBasicaSaude : EntidadeBase<int>
    {
        /// <summary>
        /// Get e Set da Latitude para a coordenada geográfica da Unidade Básica de Saúde
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Get e Set da Longitude para a coordenada geográfica da Unidade Básica de Saúde
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Get e Set do Nome da Unidade Básica de Saúde
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Get e Set do Endereco da Unidade Básica de Saúde
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Get e Set do Bairro da Unidade Básica de Saúde
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Get e Set do Cidade da Unidade Básica de Saúde
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// Get e Set das Avaliações das Unidades Básicas de Saúde
        /// </summary>
        public string Avaliacao { get; set; }
    }
}
