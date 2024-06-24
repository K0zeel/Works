using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabWork37
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

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            GetFiles();
        }

        public void GetFiles()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\temp\ispp-21");
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
            var result = files
                .Where(file => file.Name.ToLower().Contains(inputTextBox.Text.ToLower()))
                .Select(file => new {file.Name, file.Length, file.FullName, file.Extension,file.CreationTime, file.LastWriteTime})
                .ToList();
            resultDataGrid.ItemsSource = result;
        }

        private void clearFilterButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBox.Text = string.Empty;
            resultDataGrid.ItemsSource = null;
        }
    }
}