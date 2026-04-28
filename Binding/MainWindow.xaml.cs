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
using System.ComponentModel;

namespace Binding
{
    /*
    Binding - позволяет привязывать переменные к графическим интерфейсам таким образом 
    чтобы элементы интерфейса отображали значения этих переменных, а иногда и изменяли эти значения.

    К элементами интерфейса привязываются не сами переменные, а свойства (Propeties) соответствующие 
    к этим переменным
     */
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        string boundText;
        public string BoundText 
        {
            get => boundText;
            set
            {
                boundText = value;
                OnPropertyChanged();
            }
        }
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            txtInput.Focus();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
        }

        private void BtnDefault_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Default";
        }
    }
}
