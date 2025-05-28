
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace DemStroiPol;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddNewPartner_Click(object? sender, RoutedEventArgs e)
    {
        AddNewPartnerWindow anp = new AddNewPartnerWindow();
        anp.Show();
        this.Close();
    }

    private void EditPartner_Click(object? sender, RoutedEventArgs e)
    {
        EditPartnerWindow epw = new EditPartnerWindow();
        epw.Show();
        this.Close();
    }
}