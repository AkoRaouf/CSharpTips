using System;

namespace ConsoleForTest.Struct._2
{
    /// <summary>
    /// Operator '==' cannot be applied to operands of type Struct.
    /// </summary>
    public struct SampleStruct
    {
        public int Value { get; set; }

    }

    public class TestStrcut2
    {
        public void Test()
        {
            var ss = new SampleStruct();
            ///Of course, structs are value types, so they can't be compared by reference. 
            ///There is no default implementation of == for structs because memberwise comparison 
            ///isn't always a valid comparison, depending on the type.
            ///You can instead use the Object.Equals method

            ///Console.WriteLine(ss == null);


            //Solution
            Console.WriteLine(ss.Equals(null));
        }
    }

}
