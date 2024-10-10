
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace Relacion2_CarlosMN
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Ejercicio04();
        }

        // Metodo para establecer el tamaño y posicion fija a la hora de ejecutar el Windows Machine
        protected override Window CreateWindow(IActivationState activationState)
        {
            var windows = base.CreateWindow(activationState);

            // Tamaño Ventana
            windows.Height = 500;
            windows.Width = 310;

            // Posicion Ventana
            windows.X = 500;
            windows.Y = 200;

            return windows;
        }
    }
}
