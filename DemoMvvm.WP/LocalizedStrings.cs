namespace DemoMvvm.WP
{
    using DemoMvvm.WP.Resources;

    /// <summary>
    ///     Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        #region Static Fields

        private static readonly AppResources _localizedResources = new AppResources();

        #endregion

        #region Public Properties

        public AppResources LocalizedResources
        {
            get
            {
                return _localizedResources;
            }
        }

        #endregion
    }
}