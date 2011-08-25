namespace SoftWrox.Infrastructure.ServiceLocator
{
    public static class ServiceLocator
    {
        private static IServiceLocatorProvider currentProvider;

        /// <summary>
        /// The current ambient container.
        /// </summary>
        public static IServiceLocatorProvider Current
        {
            get { return currentProvider; }
        }

        /// <summary>
        /// Set the delegate that is used to retrieve the current container.
        /// </summary>
        /// <param name="newProvider">Delegate that, when called, will return
        /// the current ambient container.</param>
        public static void SetLocatorProvider(IServiceLocatorProvider newProvider)
        {
            currentProvider = newProvider;
        }
    }
}
