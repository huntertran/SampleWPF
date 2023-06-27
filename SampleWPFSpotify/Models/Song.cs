namespace SampleWPFSpotify.Models
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class Song : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private DateTime datePublished;

        public Song(int id, string name, DateTime datePublished)
        {
            Id = id;
            Name = name;
            DatePublished = datePublished;
        }

        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public string Name
        {
            get => name; set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public DateTime DatePublished
        {
            get => datePublished; set
            {
                datePublished = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
