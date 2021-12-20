using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr_10_teselko_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Random _random = new Random();
        private List<int> _integers = new List<int>(5) { };

        private void FillList_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                _integers.Add(_random.Next(-1000, 1000));
                outputListBox.Items.Add(_integers[i]);
            }
        }

        private void FindOut_Click(object sender, RoutedEventArgs e)
        {
            if (_integers.Where(x => x > int.Parse(minImputValue.Text)).Where(x => x < int.Parse(maxImputValue.Text)).Count() > 0)
            {
                MessageBox.Show($"В массиве есть хотя бы 1 элемент в диапозоне от {minImputValue.Text} до {maxImputValue.Text}!");
            }
            else MessageBox.Show($"В массиве нет элементов в диапозоне от {minImputValue.Text} до {maxImputValue.Text}!");
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            _integers.Clear();
            outputListBox.Items.Clear();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Теселько.М ИСП-34.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
