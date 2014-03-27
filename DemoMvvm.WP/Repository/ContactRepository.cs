namespace DemoMvvm.WP.Repository
{
    using System.Collections.Generic;

    using DemoMvvm.WP.Contract;
    using DemoMvvm.WP.Model;

    public class ContactRepository : IContactRepository
    {
        #region Public Methods and Operators

        public IEnumerable<Category> PopulateDummyDataInCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category { Id = -1, Title = "Select" });
            categories.Add(new Category { Id = 1, Title = "Techical Support" });
            categories.Add(new Category { Id = 2, Title = "Project Consultation" });
            categories.Add(new Category { Id = 3, Title = "Article/Blog Reference" });
            categories.Add(new Category { Id = 4, Title = "Speaking" });
            return categories;
        }

        public void Submit(string userName, string email, int selectedCategoryId, string inquiry)
        {
            // Some network, database etc. implementation here
        }

        #endregion
    }
}