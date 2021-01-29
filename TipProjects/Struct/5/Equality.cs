using System;
using System.Collections.Generic;
using System.Text;

namespace CShapAdvancedTips.Struct._5
{
    public struct SampleStruct
    {
        public int Value { get; set; }
    }

    public class TestStrcut5
    {
        /// <summary>
        /// struct can implement an interface
        /// </summary>
        public void Test()
        {
            var sampleStruct = new SampleStruct() { Value = 50 };
            var sampleStruct1 = new SampleStruct() { Value = 50 };
            Console.WriteLine(sampleStruct.Equals(sampleStruct1));
            Console.WriteLine(ReferenceEquals(sampleStruct, sampleStruct1));
            Console.WriteLine(object.Equals(sampleStruct, sampleStruct1));

            var sampleStructt = new SampleStruct() { Value = 50 };
            var sampleStructt1 = sampleStructt;
            Console.WriteLine(sampleStructt.Equals(sampleStructt1));
            Console.WriteLine(ReferenceEquals(sampleStructt, sampleStructt1));
            Console.WriteLine(object.Equals(sampleStructt, sampleStructt1));

            Console.ReadKey();
        }
    }
}
