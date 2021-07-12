using MusicPorts;

namespace TuneSearchAssignment2
{
    public static class CollectionMappings
    {
        public static SectionViewModel<TrackViewModel> ToSectionViewModel(this ICollectionEntity self)
        {
            var collectionViewModel = new SectionViewModel<TrackViewModel> { LongName = self.Name };
            foreach (var track in self.Tracks)
            {
                collectionViewModel.Add(new TrackViewModel()
                {
                    image = track.ArtworkUrl,
                    text = $"{track.TrackNumber}  - {track.TrackName}",
                    detail = track.ArtistName
                });
            }
            return collectionViewModel;
        }

    }
}