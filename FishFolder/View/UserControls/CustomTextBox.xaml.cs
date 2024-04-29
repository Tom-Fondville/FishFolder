using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FishFolder.View.UserControls;

public partial class CustomTextBox
{
    public CustomTextBox()
    {
        DataContext = this;
        InitializeComponent();
    }

    private string _placeHolderText;
    public string PlaceHolderText
    {
        get => _placeHolderText;
        set => SetField(ref _placeHolderText, value);
        // PlaceHolder.Text = _placeHolderText;
    }

    private void ClearButton_OnClick(object sender, RoutedEventArgs e)
    {
        TextInput.Clear();
        TextInput.Focus();
    }
    
    private void TextInput_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        PlaceHolder.Visibility = string.IsNullOrEmpty(TextInput.Text) ? Visibility.Visible : Visibility.Hidden;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        return true;
    }
}