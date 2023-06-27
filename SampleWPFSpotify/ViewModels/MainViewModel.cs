namespace SampleWPFSpotify.ViewModels
{
    using System.Collections.ObjectModel;
    using SampleWPFSpotify.Models;

    public class MainViewModel
    {
        public ObservableCollection<Song> SongList { get; set; }
    }
}
