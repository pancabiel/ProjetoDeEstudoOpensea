using System.ComponentModel.DataAnnotations;

namespace ProjetoDeEstudoOpensea.Model
{
    public class Colecao
    {
        [Key]
        public int id { get; set; }
        public string? nome { get; set; }

        public List<Arte> Artes { get; set; }

        public string AutorId { get; set; }
        public Usuario Autor { get; set; }
    }
}
