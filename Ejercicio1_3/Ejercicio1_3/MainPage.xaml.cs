using Ejercicio1_3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnregistrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateUsers());
        }

        private async void btnlistar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListUsers());
        }
    }
}
