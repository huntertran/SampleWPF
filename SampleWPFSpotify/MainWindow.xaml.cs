namespace SampleWPFSpotify
{
    using SampleWPFSpotify.Models;
    using SampleWPFSpotify.ViewModels;
    using System;
    using System.Collections.ObjectModel;
    using System.Windows;

    public partial class MainWindow : Window
    {
        public MainViewModel MainVm = new MainViewModel();

        public MainWindow()
        {
            DataContext = MainVm;
            MainVm.SongList = new ObservableCollection<Song>
            {
                new Song(1, "Test 1", DateTime.UtcNow.AddDays(1)),
                new Song(2, "Test 2", DateTime.UtcNow.AddDays(2)),
                new Song(3, "Test 3", DateTime.UtcNow.AddDays(3)),
                new Song(4, "Test 4", DateTime.UtcNow.AddDays(4))
            };

            InitializeComponent();
        }
    }
}
