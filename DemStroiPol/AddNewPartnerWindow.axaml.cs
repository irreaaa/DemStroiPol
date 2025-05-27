using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace DemStroiPol;

public partial class AddNewPartnerWindow : Window
{
    public AddNewPartnerWindow()
    {
        InitializeComponent();
    }

    private void Return_Click(object? sender, RoutedEventArgs e)
    {
        MainWindow mw = new MainWindow();
        mw.Show();
        this.Close();
    }
}