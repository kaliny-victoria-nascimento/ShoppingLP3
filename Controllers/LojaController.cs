using Microsoft.AspNetCore.Mvc;
using ShoppingLP3.ViewModels;
using ShoppingLP3.Models;
using System.Diagnostics;

namespace ShoppingLP3.Controllers;

public class LojaController : Controller
{
    //private static List<LojaViewModel> lojas = new List<LojaViewModel>();
    private static List<LojaViewModel> lojas = new List<LojaViewModel>{
    new LojaViewModel(32, "piso 3", "Tênis Brasil", "Aqui você encontra os tênis", true, "tenis@email.com"),
    new LojaViewModel(33, "piso 3", "Lembranças Já", "Vem comprar sua lembrança", true, "lemb@email.com"),
    new LojaViewModel(12, "piso 1", "Sorvetinho Gelado", "Sorvetinho Gelado", false, "sorvet@email.com"),
    };

    public IActionResult Index(int id)
    {
        return View();
    }

    public IActionResult Gerenciamento()
    {
        return View();
    }

    public IActionResult Cadastro([FromForm] int id, [FromForm] string piso, [FromForm] string nome, [FromForm] string descricao, [FromForm] bool lojaKiosq, [FromForm] string email )
    {
        lojas.Add(new LojaViewModel(id, piso, nome, descricao, lojaKiosq, email));
        return View();
    }

    public IActionResult Detalhar()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}