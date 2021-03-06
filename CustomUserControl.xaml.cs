using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestDepedencyProperties
{
    /// <summary>
    /// Interaction logic for CustomUserControl.xaml
    /// </summary>
    public partial class CustomUserControl : UserControl
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            nameof(Text),
            typeof(string),
            typeof(CustomUserControl),
            new FrameworkPropertyMetadata("", (obj, args) =>
            {
                if (args.OldValue != args.NewValue)
                {
                    // when a value changes, let the command know it's execution status has changed
                    //var c = (FrameworkElement)obj;
                    //var dc = (CustomUserControlViewModel)c.DataContext;
                    //dc.DependencyPropertyParameterCommand.NotifyCanExecuteChanged();
                }
            })
            {
                BindsTwoWayByDefault = true
            });

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public CustomUserControl()
        {
            InitializeComponent();
            DataContext ??= new CustomUserControlViewModel();
        }
    }
}
