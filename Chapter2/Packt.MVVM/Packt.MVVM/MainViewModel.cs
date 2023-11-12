using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI;

namespace Packt.MVVM
{
    public class MainViewModel : ObservableObject
    {
        public ICommand ChangeColorCommand { get; }
        public MainViewModel()
        {
            ChangeColorCommand = new RelayCommand(ChangeColor);
        }

        private string name;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }


        private SolidColorBrush _colorBrush;
        public SolidColorBrush ColorBrush
        {
            get => _colorBrush;
            set => SetProperty(ref _colorBrush, value);
        }


        private void ChangeColor()
        {
            Color color = Color.FromArgb(255, (byte)Random.Shared.Next(0, 255), (byte)Random.Shared.Next(0, 255), (byte)Random.Shared.Next(255));

            ColorBrush = new SolidColorBrush(color);

        }
    }
}
