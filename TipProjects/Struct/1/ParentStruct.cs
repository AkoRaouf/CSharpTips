using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleForTest.Struct._1
{
    /// <summary>
    /// A struct can not inherit from a struct. but it cant impelement an interface.
    /// </summary>
    public struct ParentStruct
    {
        public void PrintTrue() => Console.WriteLine(true);
    }

    public interface IParentStructs
    {
        void PrintTrue();
    }


    //public struct ChileStruct : ParentStruct
    //{

    //}

    public struct ChileStruct : IParentStructs
    {
        public void PrintTrue()
        {
            throw new NotImplementedException();
        }
    }
}
