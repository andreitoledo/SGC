using Andreitoledo.SGC.Mvc.Data;
using Andreitoledo.SGC.Mvc.Data.Orm;
using Andreitoledo.SGC.Mvc.Models;

namespace Andreitoledo.SGC.Mvc.Repository
{
    public class ConferenciaRepository : IConferenciaRepository

    {
        private readonly BancoContext _context;

        public ConferenciaRepository(BancoContext bancoContext)
        {
            _context = bancoContext;
        }

        public Conferencia ListarPorId(int id)
        {
            return _context.Conferencia.FirstOrDefault(x => x.Id == id);
        }

        public List<Conferencia> BuscarTodos()
        {
            return _context.Conferencia.ToList();
        }

        public Conferencia Adicionar(Conferencia conferencia)
        {
            _context.Conferencia.Add(conferencia);
            _context.SaveChanges();

            return conferencia;
        }

        public Conferencia Atualizar(Conferencia conferencia)
        {
            Conferencia conferenciaDB = ListarPorId(conferencia.Id);

            if (conferenciaDB == null) throw new System.Exception("Houve um erro na atualização da conferência!");

            conferenciaDB.Trilha = conferencia.Trilha;
            conferenciaDB.Nome = conferencia.Nome;            
            conferenciaDB.Tempo = conferencia.Tempo;

            _context.Conferencia.Update(conferenciaDB);
            _context.SaveChanges();

            return conferenciaDB;
        } 

        public bool Excluir(int id)
        {
            Conferencia conferenciaDB = ListarPorId(id);

            if (conferenciaDB == null) throw new System.Exception("Houve um erro na exclusão da conferência!");

            _context.Conferencia.Remove(conferenciaDB);
            _context.SaveChanges();

            return true;
        }

 
    }
}
