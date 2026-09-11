using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input; // Wymagane dla obsługi przycisków!

namespace DeviceSimulatorDashboard.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    // Nasza zmienna statusu
    [ObservableProperty]
    public partial string ConnectionStatus { get; set; } = "Status: Odłączony";

    // Nasza logika przycisku
    [RelayCommand]
    private void ConnectToDevice()
    {
        // Zmieniamy wartość naszej właściwości. 
        // Dzięki Data Bindingowi, UI zaktualizuje się SŁAM!
        ConnectionStatus = "Status: Połączono po UDP!";
    }
}