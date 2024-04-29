using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Domain.Models;

namespace FishFolder;

public partial class MainWindow : Window
{
    private ProjectContainer ProjectContainer { get; init; }
    
    public MainWindow()
    {
        InitializeComponent();
        ProjectContainer = new ProjectContainer("C:\\Users\\tomfo\\Work", "main");

        ProjectContainer.AddNewProject("C:\\Users\\tomfo\\Work", "test1");
        ProjectContainer.AddNewProject("C:\\Users\\tomfo\\Work", "test1");
        ProjectContainer.AddNewProject("C:\\Users\\tomfo\\Work", "test1");
        ProjectContainer.AddNewProject("C:\\Users\\tomfo\\Work", "test1");
        ProjectContainer.AddNewProject("C:\\Users\\tomfo\\Work", "test1");
        ProjectContainer.AddNewProject("C:\\Users\\tomfo\\Work", "test1");
        ProjectContainer.AddNewProject("C:\\Users\\tomfo\\Work", "test1");


        foreach (var project in ProjectContainer.Projects)
        {
            ProjectsListView.Items.Add(project.ProjectPath);
        }
    }

    private void MainWindow_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        DragMove();
    }

    private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        Console.WriteLine("Mouse donw on menu");
        DragMove();
    }
}