﻿namespace Ejercicio02
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void navigate(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }

}
