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
    public partial class ExplicitCode : ContentPage
    {
        public ExplicitCode()
        {
            InitializeComponent();
            var labelRedStyle = new Style(typeof(Label))
            {
                Setters = {
                new Setter { Property = Label.TextColorProperty, Value = Color.Red    }
            }
            };
            var labelGreenStyle = new Style(typeof(Label))
            {
                Setters = {
                new Setter { Property = Label.TextColorProperty, Value = Color.Green }
            }
            };
            var labelBlueStyle = new Style(typeof(Label))
            {
                Setters = {
                new Setter { Property = Label.TextColorProperty, Value = Color.Blue }
            }
            };

            Resources = new ResourceDictionary();
            Resources.Add("labelRedStyle", labelRedStyle);
            Resources.Add("labelGreenStyle", labelGreenStyle);
            Resources.Add("labelBlueStyle", labelBlueStyle);

            Content = new StackLayout
            {
                Children = {
                new Label { Text = "These labels",
                            Style = (Style)Resources ["labelRedStyle"] },
                new Label { Text = "are demonstrating",
                            Style = (Style)Resources ["labelGreenStyle"] },
                new Label { Text = "explicit styles,",
                            Style = (Style)Resources ["labelBlueStyle"] },
                new Label {    Text = "and an explicit style override",
                            Style = (Style)Resources ["labelBlueStyle"], TextColor = Color.Teal }
                }
            };

        }
    }
}