using AvaloniaToDo.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaToDo.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    ViewModelBase contentView;

    public MainViewModel()
    {
        ContentView = new ToDoViewModel(new ItemStorageService().Items);
    }

    [RelayCommand]
    public void AddItem()
    {
        ContentView = new AddItemViewModel();
    }
}
