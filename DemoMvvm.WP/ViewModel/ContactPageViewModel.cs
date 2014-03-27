namespace DemoMvvm.WP.ViewModel
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;

    using DemoMvvm.WP.Contract;
    using DemoMvvm.WP.Model;
    using DemoMvvm.WP.Repository;
    using DemoMvvm.WP.Validator;

    public class ContactPageViewModel : INotifyPropertyChanged
    {
        private readonly IContactRepository _contactRepository;

        private readonly IValidator _requiredFieldValidator;

        private ObservableCollection<Category> _categories;

        private string _email;

        private string _inquiry;

        private bool _isValid;

        private string _name;

        private Category _selectedCategory;

        public ContactPageViewModel()
        {
            this._requiredFieldValidator = new RequiredFieldValidator();
            this._contactRepository = new ContactRepository();
            this.SubmitCommand = new RelayCommand(this.OnSubmit);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Category> Categories
        {
            get
            {
                return this._categories;
            }

            set
            {
                this._categories = value;
                this.OnPropertyChanged();
            }
        }

        public string Email
        {
            get
            {
                return this._email;
            }

            set
            {
                this._email = value;
                this.OnPropertyChanged();
            }
        }

        public string Inquiry
        {
            get
            {
                return this._inquiry;
            }

            set
            {
                this._inquiry = value;
                this.OnPropertyChanged();
            }
        }

        public bool IsValid
        {
            get
            {
                return this._isValid;
            }

            set
            {
                this._isValid = value;
                this.OnPropertyChanged();
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
                this.OnPropertyChanged();
            }
        }

        public Category SelectedCategory
        {
            get
            {
                return this._selectedCategory;
            }

            set
            {
                this._selectedCategory = value;
                this.OnPropertyChanged();
            }
        }

        public ICommand SubmitCommand { get; set; }

        public void InitializeViewModel()
        {
            this.Name = string.Empty;
            this.Email = string.Empty;
            this.Categories = new ObservableCollection<Category>(
                this._contactRepository.PopulateDummyDataInCategories());
            this._requiredFieldValidator.RegisterPropertyChangeForValidation(this);
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnSubmit()
        {
            this._contactRepository.Submit(this.Name, this.Email, this.SelectedCategory.Id, this.Inquiry);
        }
    }
}