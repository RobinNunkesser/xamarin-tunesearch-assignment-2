using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonPorts;
using MusicPorts;
using ExplicitArchitecture.TuneSearchExample.MockCore;
using Xamarin.Forms;

namespace TuneSearchAssignment2
{
    public partial class MainPage : ContentPage
    {
        private IService<ISearchTerm, List<ICollectionEntity>> _service = new MockSearchTracksService();

        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Search_Clicked(object sender, System.EventArgs e)
        {
            _service.Execute(new SearchTermDTO { Term = searchTermEntry.Text }, SuccessHandler, ErrorHandler);
        }

        private async void ErrorHandler(System.Exception failure)
        {
            await DisplayAlert("Fehler", failure.Message, "OK");
        }

        private async void SuccessHandler(List<ICollectionEntity> collections)
        {
            var viewModel = new TracksViewModel
            {
                items = collections.Select(collection => collection.ToSectionViewModel()).ToList()
            };
            await Navigation.PushAsync(new TracksPage(viewModel));
        }
    }
}
