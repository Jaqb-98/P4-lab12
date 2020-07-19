using System;
using System.IO;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace lab12
{

    public partial class MainWindow : Window
    {
        public TextBox TextBox { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            TextBox = new TextBox();
            this.DataContext = TextBox;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["Brush"] = new SolidColorBrush(Colors.Red);
     
        }
    

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            string fileName = Environment.CurrentDirectory + @"\GreenBrush.xaml";
            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    ResourceDictionary dic = (ResourceDictionary)XamlReader.Load(fs);
                    Resources.MergedDictionaries.Add(dic);
                }
            }
        }

        private void Zoom(object sender, RoutedEventArgs e)
        {
            TextBox.Length += 10;
        }
    }
}
