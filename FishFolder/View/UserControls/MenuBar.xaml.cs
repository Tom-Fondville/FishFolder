using System.Windows;
using System.Windows.Input;

namespace FishFolder.View.UserControls;

public partial class MenuBar : UserControlNotifyPropertyChanged
{
    public MenuBar()
    {
        InitializeComponent();
        
        MainGrid.AddHandler(MouseLeftButtonDownEvent, new MouseButtonEventHandler(MainGrid_MouseLeftButtonDown), true);
        MinimizeButton.AddHandler(MouseLeftButtonUpEvent, new MouseButtonEventHandler(MinimizeButton_OnClick), true);
        MaximizeButton.AddHandler(MouseLeftButtonUpEvent, new MouseButtonEventHandler(MaximizeButton_OnClick), true);
        CloseButton.AddHandler(MouseLeftButtonUpEvent, new MouseButtonEventHandler(CloseButton_OnClick), true);
    }

    private void MainGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        var window = Window.GetWindow(this);
        window?.DragMove();
    }

    private void MinimizeButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (IsLeftMouseButtonPressed(e)) return;
        
        var window = Window.GetWindow(this);
        if (window is not null) window.WindowState = WindowState.Minimized;
    }

    private void MaximizeButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (IsLeftMouseButtonPressed(e)) return;

        var window = Window.GetWindow(this);
        if (window is null) return;

        window.WindowState = window.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
    }

    private void CloseButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (IsLeftMouseButtonPressed(e)) return;

        Application.Current.Shutdown();
    }

    private bool IsLeftMouseButtonPressed(RoutedEventArgs e) => e is MouseButtonEventArgs mouseEvent && mouseEvent.LeftButton == MouseButtonState.Pressed;
}