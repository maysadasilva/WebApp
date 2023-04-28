using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ClienteController : Controller
    {
        public List<ClientesModel> db = new List<ClientesModel>();  
        public IActionResult Lista()
        {
            return View(db);
        }

        public IActionResult Cadastro()
        {
            ClientesModel model=new ClientesModel();
            return View(model);
        }

        //rota que salva os dados
        [HttpPost]
        public IActionResult SalvarDados(ClientesModel cliente)
        {
            if(cliente.Id==0)
            {
                Random rand = new Random();
                cliente.Id = rand.Next(1, 999);
                db.Add(cliente);
            }
            return RedirectToAction("Lista");
        }
    }
}
