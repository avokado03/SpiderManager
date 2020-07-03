using System;
using System.Windows;
using System.Windows.Controls;

namespace SpiderManager.CustomControls
{
    /// <summary>
    /// Логика взаимодействия для MyNumericUpDown.xaml
    /// </summary>
    public partial class MyNumericUpDown : UserControl
    {
        private int min = 0;
        private int max = 25;
        private int start = 0;

        public MyNumericUpDown()
        {
            InitializeComponent();
            Value.Text = start.ToString();
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            int currentValue = (Value.Text != "") ? Convert.ToInt32(Value.Text) : start;
            if (currentValue > min)
                Value.Text = (--currentValue).ToString();
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            int currentValue = (Value.Text!="") ? Convert.ToInt32(Value.Text) : start;
            if (currentValue < max)
                Value.Text = (++currentValue).ToString();
        }

        private void Value_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Value.Text != "")
            {
                int currentValue = Convert.ToInt32(Value.Text);
                if (currentValue < min)
                    Value.Text = min.ToString();
                if (currentValue > max)
                    Value.Text = max.ToString();
            }
        }
    }
}
