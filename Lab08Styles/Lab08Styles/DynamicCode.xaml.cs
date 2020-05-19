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
    public partial class DynamicCode : ContentPage
    {
        //bool originalStyle = true;
        public DynamicCode()
        {
            InitializeComponent();
            //Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    if (originalStyle)
        //    {
        //        Resources["searchBarStyle"] = Resources["greenSearchBarStyle"];
        //        originalStyle = false;
        //    }
        //    else
        //    {
        //        Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
        //        originalStyle = true;
        //    }
        //}
    }
}