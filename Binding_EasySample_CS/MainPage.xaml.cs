using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Binding_EasySample_CS
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        /* private void myTextBox_TextChanged(object sender, TextChangedEventArgs e)
         {
             if (System.Text.RegularExpressions.Regex.IsMatch(myTextBox.Text, "[^0-9]"))
             {
                 myTextBox.Text.Remove(myTextBox.Text.Length - 1);
             }
         }*/

        /// <summary>
        /// Evita que pongamos letras en el textbox, pero sólo funcionan los números de la fila de arriba, no los del pad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myTextBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (!(char.IsNumber((char)e.Key)))
                e.Handled = true;
        }
    }
}
