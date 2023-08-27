using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaToDo.ViewModels;

public partial class AddItemViewModel : ViewModelBase
{
    [ObservableProperty]
    string description = string.Empty;

    public bool CanOkExecute => !string.IsNullOrEmpty(Description);

    [RelayCommand(CanExecute = nameof(CanOkExecute))]
    public void Ok()
    {
    }

    [RelayCommand]
    public void Cancel()
    {
    }
}
