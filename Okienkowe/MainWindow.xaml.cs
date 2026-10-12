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
            //TODO: pobierz tekst z pola z ilością i zmień go na liczbę
            
            //TODO: Jeśli wartości są niepoprawne lub ujemne wypisz komunikat w polu wynik albo rzuć wyjątek
            //TODO: oblicz wartość zamówienia i wypisz ją w polu wynik
            // int.parse() - konwertuje string na int, jeśli nie da się to rzuca wyjątek
            // int.tryparse() - konwertuje string na int, jeśli nie da się to zwraca false i nie rzuca wyjątku (Bad) 
            if (!double.TryParse(CenaTextBox.Text, out double cena))
            {
                WynikTextBlock.Text = "Niepoprawna cena";
                return;
            }
            //double cena = double.Parse(CenaTextBox.Text);
            if (!int.TryParse(IloscTextBox.Text, out int ilosc))
            {
                WynikTextBlock.Text = "Niepoprawna ilość";
                return;
            }
            //int ilosc = int.Parse(IloscTextBox.Text);
            double wartoscZamowienia = cena * ilosc;
            WynikTextBlock.Text = wartoscZamowienia.ToString();

            //TODO wypisz w WynikTextBLock nazwę produktu, kategorie, cenę, ilość i wartość zamówienia
            //Jeśli jest zaznaczony checkbox promocja odejmij 10% od wartości zamówienia

            if (PromocjaCheckBox.IsChecked == true)
            {
                wartoscZamowienia *= 0.9;
            }

            WynikTextBlock.Text = $"Nazwa produktu: {NazwaTextBox.Text}\n" +
                                  $"Kategoria: {KategorieComboBox.SelectedItem}\n" +
                                  $"Cena: "

        }
    }
}