using System;
using System.Collections.Generic;
using System.Text;

namespace CShapAdvancedTips.Class.Singletone.EgerLoading
{
    public class SingletoneClass
    {
        /// <summary>
        /// The Eager loading in singleton design pattern is nothing a process in 
        /// which we need to initialize the singleton object at the time of application 
        /// start-up rather than on-demand and keep it ready in memory to be used in 
        /// the future. The advantage of using Eager Loading in the Singleton design 
        /// pattern is that the CLR (Common Language Runtime) will take care of object 
        /// initialization and thread-safety. That means we will not require to write 
        /// any code explicitly for handling the thread-safety for a multithreaded environment.
        /// </summary>
        private static readonly SingletoneClass instance = new SingletoneClass();
        private SingletoneClass()
        {

        }

        public static SingletoneClass GetInstance
        {
            get
            {
                return instance;
            }
        }
    }
}
