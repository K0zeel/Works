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

namespace LabWork39_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetFiles();
        }

        public void GetFiles()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\temp\ispp-21");
            var files = directory.GetFiles("*", SearchOption.AllDirectories);
            var directories = directory.GetDirectories("*", SearchOption.AllDirectories);
            var result = files;
            resultDataGrid.ItemsSource = result;

            //Task1
            var filesDirs = files.Select(f => new { Name = f.Name, DateCreated = f.CreationTime })
                .Union(directories.Select(d => new { Name = d.Name, DateCreated = d.CreationTime }));
            resultDataGrid.ItemsSource = filesDirs.ToList();

            //task2
            var fileExtensions = files.GroupBy(f => f.Extension)
                .Select(g => new { Extension = g.Key, TotalSize = g.Sum(f => f.Length), Count = g.Count() });
        }
    }
}