using Movies.Model;
using Movies.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movies.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Index : ContentPage
    {
        public Index()
        {
            InitializeComponent();
            BindingContext = new MoviesViewModel();
        }
        private void GetMovieCommand(object sender, EventArgs e)
        {
            Movie unMovie = (Movie)((TappedEventArgs)e).Parameter;
            Debug.WriteLine(unMovie);
            Navigation.PushAsync(new Details(unMovie));
        }
    }
}