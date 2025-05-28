using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using System;
using System.IO;

namespace DemStroiPol;

public partial class EditPartnerWindow : Window
{
    public EditPartnerWindow()
    {
        InitializeComponent();
    }

    private void Return_Click(object? sender, RoutedEventArgs e)
    {
        MainWindow mw = new MainWindow();
        mw.Show();
        this.Close();
    }

    private async void AddLogo_Click(object? sender, RoutedEventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        try
        {
            var dialog = await ofd.ShowAsync(this);
            string filename = string.Join("", dialog);
            Random random = new Random();
            string photo = "logo" + random.Next(1, 1000) + ".png";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../", photo);
            File.Copy(filename, AppDomain.CurrentDomain.BaseDirectory + "../../../", true);
            Bitmap pib = new Bitmap(path);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}