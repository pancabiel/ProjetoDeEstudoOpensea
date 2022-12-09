using System.ComponentModel.DataAnnotations;

namespace ProjetoDeEstudoOpensea.Model
{
    public class Colecao
    {
        [Key]
        public int id { get; set; }
        public string? nome { get; set; }
    }
}
