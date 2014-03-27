namespace DemoMvvm.WP.Contract
{
    using DemoMvvm.WP.ViewModel;

    public interface IValidator
    {
        void RegisterPropertyChangeForValidation(ContactPageViewModel contactPageViewModel);
    }
}