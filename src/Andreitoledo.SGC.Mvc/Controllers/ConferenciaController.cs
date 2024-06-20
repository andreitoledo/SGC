using Andreitoledo.SGC.Mvc.Models;
using Andreitoledo.SGC.Mvc.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Andreitoledo.SGC.Mvc.Controllers
{
    public class ConferenciaController : Controller
    {
        private readonly IConferenciaRepository _conferenciaRepository;

        public ConferenciaController(IConferenciaRepository conferenciaRepository)
        {
            _conferenciaRepository = conferenciaRepository;
        }

        // Listar Conferencias
        public IActionResult Index()
        {
            List<Conferencia> conferencias = _conferenciaRepository.BuscarTodos();
            return View(conferencias);
        }

        // Adicionar Conferencias
        [Authorize]
        public IActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Incluir(Conferencia conferencia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _conferenciaRepository.Adicionar(conferencia);
                    TempData["MensagemSucesso"] = "Conferência cadastrada com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(conferencia);
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não foi possível cadastrar sua conferência, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }            
        }

        // Editar Conferencias
        [Authorize]
        public IActionResult Editar(int id)
        {
            Conferencia conferencia = _conferenciaRepository.ListarPorId(id);

            return View(conferencia);
        }

        [HttpPost]
        public IActionResult Alterar(Conferencia conferencia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _conferenciaRepository.Atualizar(conferencia);
                    TempData["MensagemSucesso"] = "Conferência alterada com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", conferencia);
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não foi possível atualizar sua conferência, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        // Excluir Conferência
        [Authorize]
        public IActionResult ExcluirConfirmacao(int id)
        {
            Conferencia conferencia = _conferenciaRepository.ListarPorId(id);

            return View(conferencia);
        }

        public IActionResult Excluir(int id)
        {
            try
            {
                bool apagado = _conferenciaRepository.Excluir(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Conferencia deletada com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, não foi possível deletar sua conferência!";
                }

                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não foi possível deletar sua conferência, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

    }
}
