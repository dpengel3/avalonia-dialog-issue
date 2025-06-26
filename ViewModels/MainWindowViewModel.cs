namespace aui_dialog.ViewModels;

using System;
using System.Reactive;

using aui_dialog.Views;

using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;

using ReactiveUI;

public partial class MainWindowViewModel : ViewModelBase
{
    private string _dialogText;

    public MainWindowViewModel()
    {
        Show = ReactiveCommand.Create(ExecuteShow);

        _dialogText = "Test";
    }

    public ReactiveCommand<Unit,Unit> Show { get; }

    public string DialogText
    {
        get => _dialogText;

        set
        {
            this.RaiseAndSetIfChanged(ref _dialogText, value);
        }
    }

    public string Greeting { get; } = "Welcome to Avalonia!";

    private async void ExecuteShow()
    {
        var lifetime = Application.Current?.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime;
        if (lifetime is null || lifetime.MainWindow is null)
        {
            return;
        }

        var vm = new DialogViewModel()
        {
            Text = DialogText
        };

        var dialog = new DialogView()
        {
            DataContext = vm
        };

        var result = await dialog.ShowDialog<bool>(lifetime.MainWindow).ConfigureAwait(false);
        if (result)
        {
            DialogText = string.Empty;
        }
    }
}
