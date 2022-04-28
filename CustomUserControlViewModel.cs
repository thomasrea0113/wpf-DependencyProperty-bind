using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDepedencyProperties;

internal class CustomUserControlViewModel : ObservableObject
{

    public IRelayCommand? _dependencyPropertyParameterCommand;
    public IRelayCommand DependencyPropertyParameterCommand => _dependencyPropertyParameterCommand ??= InitializeCommand();

    private string _text = "";
    public string Text
    {
        get => _text;
        set => SetProperty(ref _text, value);
    }

    public IRelayCommand InitializeCommand() => new RelayCommand<string>(arg =>
    {
        // TODO should be able to set out Text Value to the Text Property of the MainWindow,
        // since it is data bound and passed as a paramter
        Text = arg!;
    }, arg => !string.IsNullOrWhiteSpace(arg));
}
