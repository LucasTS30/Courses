using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using TodoList.ViewModels;

namespace TodoList.Controllers;
public class TestController : Controller
{
    public IActionResult Index()
    {
        //ViewData["apresentacao"] = "Olá, ASP .NET Core";
        //ou
        //ViewData.Add("apresentacao", "Olá, ASP .NET Core");

        var todo = new ToDo { Title = "Estudar ASP .NET Core",
                               Description = "Concluir curso ASP .NET Core"};
        
        //ViewData["todo"] = todo;
        ViewBag.Todo = todo;

        TempData["message"] = "Mensagem vinda da action Index";

        return View();
    }

    public IActionResult Message()
    {
        return View();
    }

    public IActionResult ViewModel()
    {
        var todo = new ToDo 
        { 
            Title = "Estudar ASP .NET Core",
            Description = "Concluir curso ASP .NET Core"
        };
        var viewModel = new DetailToDoViewModel
        {
            ToDo = todo,
            PageTitle = "Detalhes da tarefa"
        };
        return View(viewModel);
    }
}