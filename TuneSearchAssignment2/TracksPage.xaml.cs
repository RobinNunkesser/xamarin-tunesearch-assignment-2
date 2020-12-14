using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TuneSearchAssignment2
{
    public partial class TracksPage : ContentPage
    {
        public TracksPage()
        {
            InitializeComponent();
        }

        public TracksPage(object bindingContext) : this()
        {            
            BindingContext = bindingContext;
        }

    }
}
