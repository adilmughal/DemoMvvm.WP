namespace DemoMvvm.WP.Model
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class Category : INotifyPropertyChanged
    {
        private string _title;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }

        public string Title
        {
            get
            {
                return this._title;
            }

            set
            {
                this._title = value;
                this.OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}