using ProjetoDeEstudoOpensea.Database;
using ProjetoDeEstudoOpensea.Model;

namespace ProjetoDeEstudoOpensea.DAO
{
    public class ColecaoDAO
    {
        private AppContextDb _context;

        public ColecaoDAO(AppContextDb context)
        {
            _context = context;
        }

        public List<Colecao> buscar()
        {
            return _context.Colecoes.ToList();
        }
    }
}
