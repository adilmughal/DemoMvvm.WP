namespace DemoMvvm.WP.Validator
{
    using System.ComponentModel;

    using DemoMvvm.WP.Contract;
    using DemoMvvm.WP.ViewModel;

public class RequiredFieldValidator : IValidator
{
    private ContactPageViewModel _contactPageViewModel;

    public void RegisterPropertyChangeForValidation(ContactPageViewModel contactPageViewModel)
    {
        this._contactPageViewModel = contactPageViewModel;
        contactPageViewModel.PropertyChanged += this.PerformValidationOnPropertyChanged;
    }

    private void PerformValidationOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
    {
        if (propertyChangedEventArgs.PropertyName == "IsValid") 
            return;

        if (string.IsNullOrWhiteSpace(this._contactPageViewModel.Email)
            || string.IsNullOrWhiteSpace(this._contactPageViewModel.Name)
            || string.IsNullOrWhiteSpace(this._contactPageViewModel.Inquiry)
            || this._contactPageViewModel.SelectedCategory == null
            || this._contactPageViewModel.SelectedCategory.Id <= 0)
        {
            this._contactPageViewModel.IsValid = false;
        }
        else
        {
            this._contactPageViewModel.IsValid = true;
        }
    }
}
}
