namespace DemoMvvm.WP.View
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;

    using DemoMvvm.WP.ViewModel;

    using Microsoft.Phone.Controls;

    public partial class ContactPage : PhoneApplicationPage
    {
        private readonly ContactPageViewModel _viewModel;

        public ContactPage()
        {
            this.InitializeComponent();
            this._viewModel = new ContactPageViewModel();
            this.DataContext = this._viewModel;
            this.Loaded += this.OnPageLoaded;
        }

        private void OnPageLoaded(object sender, RoutedEventArgs e)
        {
            this._viewModel.InitializeViewModel();
        }

        private void OnTextChangeUpdateSource(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                BindingExpression be = textBox.GetBindingExpression(TextBox.TextProperty);
                be.UpdateSource();
            }
        }
    }
}