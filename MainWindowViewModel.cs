using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDepedencyProperties;

internal class MainWindowViewModel : ObservableObject
{

    private string _text = "";
    public string Text
    {
        get => _text;
        set => SetProperty(ref _text, value);
    }

    public MainWindowViewModel()
    {
        // setting some text... should also update the CustomUserControl DependencyProperty
        Text = "Initial Text";
    }
}
