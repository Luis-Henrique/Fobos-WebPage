using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fobos.Models;

namespace Fobos.Controllers;

public class HomeController : Controller
{
    int id;
    private readonly FobosContext _context;

    public HomeController(FobosContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Posts);
    }

    public IActionResult Contato()
    {
        return View();
    }

    public IActionResult Sobre()
    {
        return View();
    }

    public IActionResult PostPage(int id)
    {
        Post post = _context.Posts.Find(id);

        if(post == null)
        {
            return NotFound();
        }

        return View(post);
    }

    public IActionResult Cadastro()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastro(User acc)
    {
        acc.Id = id;

        if(!ModelState.IsValid) 
        {
            return View(acc);
        }

        _context.Users.Add(acc);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
