using Microsoft.AspNetCore.Identity;

namespace ProjetoDeEstudoOpensea.Model
{
    public class Usuario : IdentityUser
    {
        public List<Colecao> Colecoes { get; set; }

        public List<Arte> Artes { get; set; }
    }
}
