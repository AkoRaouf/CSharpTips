using System;
using System.Collections.Generic;
using System.Text;

namespace CShapAdvancedTips.Class.Singletone.LazyOrDeferredLoading
{
    /// <summary>
    /// The Lazy or Deferred Loading is a design pattern or you can say its a concept 
    /// which is commonly used to delay the initialization of an object until the point 
    /// at which it is needed. So the main objective of Lazy loading is to load the 
    /// object on-demand or you can say object when needed. The most important point 
    /// that you need to keep in mind is that, you need to use the Lazy loading when 
    /// the cost of the object creation is very high as well as the use of that object 
    /// is very rare. The lazy loading improves the performance of an application if 
    /// it is used properly. We can use the Lazy keyword to make the singleton instance 
    /// as lazy loading. 
    /// </summary>
    public class SingletoneClass
    {
        /// <summary>
        /// The most important point that you need to remember is the Lazy<T> objects 
        /// are by default thread-safe. In a multi-threaded environment, when multiple 
        /// threads are trying to access the same Get Instance property at the same time, 
        /// then the lazy object will take care of thread safety.
        /// </summary>
        private static readonly Lazy<SingletoneClass> instanceLock = new Lazy<SingletoneClass>(() => new SingletoneClass());
        private SingletoneClass()
        {

        }

        public static SingletoneClass GetInstance
        {
            get
            {
                return instanceLock.Value;
            }
        }
    }
}
