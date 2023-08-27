using AvaloniaToDo.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AvaloniaToDo.ViewModels;

public partial class ToDoViewModel : ViewModelBase
{
    [ObservableProperty]
    ObservableCollection<ToDoItem> items;

    public ToDoViewModel(IEnumerable<ToDoItem> items)
    {
        this.items = new(items);
    }
}
