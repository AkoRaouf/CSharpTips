using System;
using System.Collections.Generic;
using System.Text;

namespace CShapAdvancedTips.Exceptions
{
    public class SampleClassForExceptions
    {
        public int Value { get; set; }
    }

    public class TestException
    {
        public void Test()
        {
            try
            {
                try
                {
                    SampleClassForExceptions instance = null;
                    var value = instance.Value;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Local: NullReferenceException");
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Local: Exception");
                    throw;
                }
                finally
                {
                    Console.WriteLine("Local: finally");
                }
                Console.WriteLine("Global: End of Try");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Global: {ex.GetType().Name}");
            }
        }
    }
}
