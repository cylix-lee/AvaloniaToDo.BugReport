using AvaloniaToDo.Models;
using System.Collections.Generic;

namespace AvaloniaToDo.Services;

public class ItemStorageService
{
    readonly ToDoItem[] items =
    {
        new ToDoItem { Description = "Walk the dog" },
        new ToDoItem { Description = "Buy some milk" },
        new ToDoItem { Description = "Learn Avalonia", IsChecked = true },
    };

    public IEnumerable<ToDoItem> Items => items;
}
