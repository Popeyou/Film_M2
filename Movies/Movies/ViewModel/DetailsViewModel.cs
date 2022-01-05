using Movies.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Movies.ViewModel
{
    class DetailsViewModel
    {
        public DetailsViewModel(Movie unMovie)
        {
            GetMovie(unMovie);
        }

        private void GetMovie(Movie unMovie)
        {
            Movie = new ObservableCollection<Movie>();
            Movie.Add(unMovie);
        }

        private ObservableCollection<Movie> movie;
        public ObservableCollection<Movie> Movie
        {
            get { return movie; }
            set
            {
                movie = value;
            }
        }
    }
}
