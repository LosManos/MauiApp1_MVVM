using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
    public MainPageViewModel()
    {
        ButtonText = "Click Me";
    }

    [ObservableProperty]
    public int myCount;

    [ObservableProperty]
    public string buttonText;

    [RelayCommand]
    public void IncreaseCount()
    {
        MyCount += 1;

        if (MyCount == 1)
            ButtonText = $"Clicked {MyCount} time";
        else
            ButtonText = $"Clicked {MyCount} times";
    }
}
