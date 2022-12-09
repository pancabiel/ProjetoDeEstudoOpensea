using System.ComponentModel.DataAnnotations;

namespace ProjetoDeEstudoOpensea.Model
{
    public class Arte
    {
        [Key]
        public int id { get; set; }
        public string? nome { get; set; }
        public double? preco { get; set; }
    }
}
