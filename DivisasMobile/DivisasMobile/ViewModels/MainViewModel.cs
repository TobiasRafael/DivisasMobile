using GalaSoft.MvvmLight.Command;
using System.ComponentModel;
using System.Windows.Input;

namespace DivisasMobile.ViewModels
{
    public class MainViewModel :INotifyPropertyChanged
    {
        private decimal dollars;
        private decimal euros;
        private decimal pounds;
        private decimal pesos;
        public event PropertyChangedEventHandler PropertyChanged;

        public decimal Pesos { get; set; }
        public decimal Dollars {
            set
            {
                if (dollars != value)
                {
                    dollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollars"));
                }
            }
            get
            {
                return dollars;
            }
        }

        public decimal Euros {
            set
            {
                if (euros != value)
                {
                    euros = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Euros"));
                }
            }
            get
            {
                return euros;
            }
        }

        public decimal Pounds {
            set
            {
                if (pounds != value)
                {
                    pounds = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pounds"));
                }
            }
            get
            {
                return pounds;
            }

        }

        public ICommand ConvertCommand { get { return new RelayCommand(ConvertMoney); } }

        private async void ConvertMoney()
        {
            if (Pesos <= 0)
            {
               await App.Current.MainPage.DisplayAlert("Error", "Ingresar valor mayor a cero", "Aceptar");
                return;
            }

            Dollars = Pesos / 47.5895874M;
            Euros = Pesos / 56.7810403M;
            Pounds = Pesos / 61.4143625M;
         }
    }
}
