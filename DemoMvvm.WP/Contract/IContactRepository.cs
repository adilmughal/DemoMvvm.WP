namespace DemoMvvm.WP.Contract
{
    using System.Collections.Generic;

    using DemoMvvm.WP.Model;

    internal interface IContactRepository
    {
        IEnumerable<Category> PopulateDummyDataInCategories();
        
        void Submit(string userName, string email, int selectedCategoryId, string inquiry);
    }
}