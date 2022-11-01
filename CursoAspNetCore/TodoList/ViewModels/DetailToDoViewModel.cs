using TodoList.Models;

namespace TodoList.ViewModels;

public class DetailToDoViewModel
{
    public ToDo? ToDo { get; set; }
    public string PageTitle { get; set; } = string.Empty;
}