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
    public partial class InheritanceCode : ContentPage
    {
        public InheritanceCode()
        {
            InitializeComponent();
            var baseStyle = new Style(typeof(View))
            {
                Setters = {
                new Setter {
                    Property = View.HorizontalOptionsProperty, Value = LayoutOptions.Center    }
            }
            };

            var labelStyle = new Style(typeof(Label))
            {
                BasedOn = baseStyle,
                Setters = {
                new Setter { Property = Label.TextColorProperty, Value = Color.Teal    }
            }
            };

            var buttonStyle = new Style(typeof(Button))
            {
                BasedOn = baseStyle,
                Setters = {
                new Setter { Property = Button.BorderColorProperty, Value =    Color.Lime }
            }
            };

            Content = new StackLayout
            {
                Children = {
                new Label { Text = "These labels - Code", Style = labelStyle },
                new Button { Text = "So is the button - Code", Style = buttonStyle }
            }
            };
        }
    }
}