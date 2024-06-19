using Andreitoledo.SGC.Mvc.Data;
using Andreitoledo.SGC.Mvc.Models;

namespace Andreitoledo.SGC.Mvc.Repository
{
    public class ConferenciaRepository : IConferenciaRepository

    {
        private readonly ApplicationDbContext _context;

        public ConferenciaRepository(ApplicationDbContext applicationContext)
        {
            _context = applicationContext;
        }

        public Conferencia ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Conferencia> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Conferencia Adicionar(Conferencia conferencia)
        {
            throw new NotImplementedException();
        }

        public Conferencia Atualizar(Conferencia conferencia)
        {
            throw new NotImplementedException();
        } 

        public bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

 
    }
}
