using System;
using System.Collections.Generic;
using System.Text;

namespace CShapAdvancedTips.Struct._4
{
    public interface ISampleStruct
    {
        public int Value { get; set; }
    }

    public struct SampleStruct : ISampleStruct
    {
        public int Value { get; set; }
    }

    public class TestStrcut4
    {
        /// <summary>
        /// struct can implement an interface
        /// </summary>
        public void Test()
        {
            var sampleStruct = new SampleStruct() { Value = 50 };
            Console.WriteLine(sampleStruct.Value == 50);
        }
       
    }
}
