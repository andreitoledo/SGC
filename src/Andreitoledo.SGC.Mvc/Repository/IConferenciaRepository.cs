using Andreitoledo.SGC.Mvc.Models;

namespace Andreitoledo.SGC.Mvc.Repository
{
    public interface IConferenciaRepository
    {
        Conferencia ListarPorId(int id);
        List<Conferencia> BuscarTodos();
        Conferencia Adicionar(Conferencia conferencia);
        Conferencia Atualizar(Conferencia conferencia);
        bool Excluir(int id);
    }
}
