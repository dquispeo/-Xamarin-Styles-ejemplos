using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab08Styles
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var buttonStyle = new Style(typeof(Button))
            {
                Setters = { new Setter { Property = Button.TextColorProperty,    Value = Color.Teal }
            }
            };
            //Resources = new ResourceDictionary();
            Resources.Add("buttonStyleCode", buttonStyle);

            MainPage = new NavigationPage(new GlobalCode());


            //MainPage = new MainPage();
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
