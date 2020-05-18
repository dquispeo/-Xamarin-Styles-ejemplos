using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab08Styles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GlobalCode : ContentPage
    {
        public GlobalCode()
        {
            InitializeComponent();
            Content = new StackLayout
            {
                Children = {
                new Button { Text = "These buttons", Style = (Style)Application.Current.Resources ["buttonStyleCode"] },
                new Button { Text = "are demonstrating", Style = (Style)Application.Current.Resources ["buttonStyleCode"] },
                new Button { Text = "application styles", Style = (Style)Application.Current.Resources ["buttonStyleCode"]
                }
            }
            };
        }
    }
}