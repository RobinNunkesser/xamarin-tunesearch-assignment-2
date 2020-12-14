using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TuneSearchAssignment2
{
    public class TracksViewModel
    {
        public List<SectionViewModel<TrackViewModel>> items { get; set; }

        public TracksViewModel()
        {
            items = new List<SectionViewModel<TrackViewModel>>();
        }
    }
}
