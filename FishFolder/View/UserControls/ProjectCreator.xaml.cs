using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace FishFolder.View.UserControls;

public partial class ProjectCreator : UserControl
{
    public ProjectCreator()
    {
        InitializeComponent();
    }

    private void AddButton_OnClick(object sender, RoutedEventArgs e)
    {
        Console.Write("Button add clicked");
        var result = MessageBox.Show("Not Implemented", "ERROR!", MessageBoxButton.YesNo, MessageBoxImage.Question);
        Console.WriteLine(result);
    }

    private void SelectFolderButton_OnClick(object sender, RoutedEventArgs e)
    {
        var folderDialog = new OpenFolderDialog();
        folderDialog.Multiselect = false;
        // folderDialog.InitialDirectory = "C:\\temp";
        folderDialog.Title = "Please select your project folder";
        
        if (folderDialog.ShowDialog() == true)
        {
            var path = folderDialog.FolderName;
            Console.WriteLine(path);
        }
    }
}