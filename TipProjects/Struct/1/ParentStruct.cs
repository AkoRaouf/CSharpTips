using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleForTest.Struct._1
{
    public struct ParentStruct
    {
        public void PrintTrue() => Console.WriteLine(true);
    }

    public struct ChileStruct : ParentStruct
    {

    }
}
