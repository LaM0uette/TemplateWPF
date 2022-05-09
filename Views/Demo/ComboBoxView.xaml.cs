using System.Windows;
using System.Windows.Controls;

namespace TemplateWPF.Views.Demo;

public partial class ComboBoxView : UserControl
{
    public ComboBoxView()
    {
        InitializeComponent();
    }

    private void ComboBoxView_OnLoaded(object sender, RoutedEventArgs e)
    {
        ComboBoxPlainM1.Items.Insert(0, "Alice");
        ComboBoxPlainM1.Items.Insert(1, "Bob");
        ComboBoxPlainM1.Items.Insert(2, "Charlie");
        ComboBoxPlainM1.Items.Insert(3, "Charlie Charlie Charlie Charlie Charlie Charlie");
    }
} 