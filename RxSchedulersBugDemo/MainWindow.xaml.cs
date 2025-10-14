using ReactiveUI;
using System.Reactive.Concurrency;
using System.Windows;

namespace TestReactiveUI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        RxSchedulers.MainThreadScheduler.Schedule(() =>
        {
            var currentThreadId = Environment.CurrentManagedThreadId;
            testLabel.Content = $"Current thread Id: {currentThreadId}";
        });
    }
}