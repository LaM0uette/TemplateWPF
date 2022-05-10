using System.Collections.Generic;
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
        string[] items = new string[5]{ "Mumbai", "London", "New York", "Paris", "Colombo" };

        int i = 0;
        foreach (var item in items)
        {
            ComboBoxPlainM1.Items.Insert(i, item);
            ComboBoxPlainM2.Items.Insert(i, item);
            ComboBoxPlainM3.Items.Insert(i, item);
            ComboBoxPlainB1.Items.Insert(i, item);
            ComboBoxPlainB2.Items.Insert(i, item);
            i++;
        }
    }
} 