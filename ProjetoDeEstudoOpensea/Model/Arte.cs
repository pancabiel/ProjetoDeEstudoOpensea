using System.ComponentModel.DataAnnotations;

namespace ProjetoDeEstudoOpensea.Model
{
    public class Arte
    {
        [Key]
        public int id { get; set; }
        public string? nome { get; set; }
        public double? preco { get; set; }

        public int ColecaoId { get; set; }
        public Colecao Colecao { get; set; }

        public string ProprietarioId { get; set; }
        public Usuario Proprietario { get; set; }
    }
}
