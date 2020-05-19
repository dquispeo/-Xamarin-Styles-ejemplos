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
    public partial class ImplicitCode : ContentPage
    {
        public ImplicitCode()
        {
            var entryStyle = new Style(typeof(Entry))
        {
        Setters = {
                new Setter { Property = Entry.TextColorProperty, Value = Color.Blue }
            }
    };

    Resources = new ResourceDictionary();
    Resources.Add(entryStyle);

            Content = new StackLayout
            {
                Children = {
                new Entry { Text = "These entries" },
                new Entry { Text = "are demonstrating" },
                new Entry { Text = "implicit styles," },
                new Entry { Text = "and an implicit style override", BackgroundColor = Color.Lime, TextColor = Color.Red },
                new CustomEntry  { Text = "Subclassed Entry is not receiving the style" }
            }
            };
        }
	}
}