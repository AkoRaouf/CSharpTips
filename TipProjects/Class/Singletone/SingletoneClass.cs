using System;
using System.Collections.Generic;
using System.Text;

namespace CShapAdvancedTips.Class.Singletone
{
    public class SingletoneClass
    {
        private static SingletoneClass instance = null;
        private static readonly object instancelock = new object();
        private SingletoneClass()
        {

        }

        public static SingletoneClass GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (instancelock)
                    {
                        if (instance == null)
                            instance = new SingletoneClass();

                     
                    }
                }
                return instance;
            }
        }
    }
}
