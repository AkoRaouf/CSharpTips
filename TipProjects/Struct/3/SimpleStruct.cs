using System;
using System.Collections.Generic;
using System.Text;

namespace CShapAdvancedTips.Struct._3
{
    public struct SimpleStruct
    {
        public int Value { get; set; }
    }

    public class TestStrcut3
    {
        /// <summary>
        /// struct is a value type, change values in a method does affect original source.
        /// </summary>
        public void Test()
        {
            var ss = new SimpleStruct() { Value = 50 };
            ChangeValue(ss);
            Console.WriteLine(ss.Value == 50);
        }

        private void ChangeValue(SimpleStruct simpleStruct)
        {
            simpleStruct.Value = 100;
        }
    }
}
