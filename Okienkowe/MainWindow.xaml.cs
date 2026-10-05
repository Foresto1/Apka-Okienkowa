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

namespace Okienkowe
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

        private void Oblicz(object sender, RoutedEventArgs e)
        {
            //TODO: pobierz tekst z pola z ceną i zmień go na liczbę
            int cena = int.Parse(CenaTextBox.Text);
            //TODO: pobierz tekst z pola z ilością i zmień go na liczbę
            
            //TODO: Jeśli wartości są niepoprawne lub ujemne wypisz komunikat w polu wynik albo rzuć wyjątek
            //TODO: oblicz wartość zamówienia i wypisz ją w polu wynik
            // int.parse() - konwertuje string na int, jeśli nie da się to rzuca wyjątek
            // int.tryparse() - konwertuje string na int, jeśli nie da się to zwraca false i nie rzuca wyjątku (Bad) 
        }
    }
}