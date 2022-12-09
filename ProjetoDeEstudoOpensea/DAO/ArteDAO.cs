using ProjetoDeEstudoOpensea.Database;
using ProjetoDeEstudoOpensea.Model;

namespace ProjetoDeEstudoOpensea.DAO
{
    public class ArteDAO
    {
        private AppContextDb _context;

        public ArteDAO(AppContextDb context)
        {
            _context = context;
        }

        public List<Arte> buscar()
        {
            return _context.Artes.ToList();
        }
    }
}
