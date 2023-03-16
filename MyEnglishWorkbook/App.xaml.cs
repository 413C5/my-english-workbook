using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//Autor: Marco Antonio García Hernández
namespace MyEnglishWorkbook
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
