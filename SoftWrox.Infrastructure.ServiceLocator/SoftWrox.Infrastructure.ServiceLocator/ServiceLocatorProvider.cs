namespace SoftWrox.Infrastructure.ServiceLocator
{
    using System;
    using System.Collections.Generic;

    public class ServiceLocatorProvider : IServiceLocatorProvider
    {
        private readonly Dictionary<Type, Func<Object>> initialisers = new Dictionary<Type, Func<Object>>();

        /// <summary>
        /// Get all instances of the given <typeparamref name="TService"/> currently
        /// registered in the container.
        /// </summary>
        /// <typeparam name="TService">Type of object requested.</typeparam>
        /// <returns>
        /// A sequence of instances of the requested <typeparamref name="TService"/>.
        /// </returns>
        /// <exception cref="ActivationException">if there is are errors resolving
        /// the service instance.</exception>
        public IEnumerable<TService> GetAllInstances<TService>()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get an instance of the given <typeparamref name="TService"/>.
        /// </summary>
        /// <typeparam name="TService">Type of object requested.</typeparam>
        /// <returns>
        /// The requested service instance.
        /// </returns>
        /// <exception cref="ActivationException">if there is are errors resolving
        /// the service instance.</exception>
        public TService GetInstance<TService>()
        {
            return (TService)initialisers[typeof(TService)]();
        }

        /// <summary>
        /// Get an instance of the given named <typeparamref name="TService"/>.
        /// </summary>
        /// <typeparam name="TService">Type of object requested.</typeparam>
        /// <param name="key">Name the object was registered with.</param>
        /// <returns>
        /// The requested service instance.
        /// </returns>
        /// <exception cref="ActivationException">if there is are errors resolving
        /// the service instance.</exception>
        public TService GetInstance<TService>(string key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Registers the service.
        /// </summary>
        /// <typeparam name="TService">The type of the service.</typeparam>
        /// <param name="initialiser">The initialiser.</param>
        public void RegisterService<TService>(Func<Object> initialiser)
        {
            initialisers.Add(typeof(TService), initialiser);
        }
    }
}
