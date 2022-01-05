using Movies.Model;
using Movies.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movies.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Details : ContentPage
    {
        public Details(Movie unMovie)
        {
            InitializeComponent();
            BindingContext = new DetailsViewModel(unMovie);
        }
    }
}