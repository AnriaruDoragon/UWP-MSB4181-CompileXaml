using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace UWP_MSB4181_CompileXaml
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            this.TestTextBlock.Text = this.TestTextBox.Text;
        }

        private void TestComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ComboBoxTestTextBlock.Text = (string)(this.TestComboBox.SelectedItem as ComboBoxItem).Content;
        }
    }
}
