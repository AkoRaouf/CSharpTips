using System;
using System.Collections.Generic;
using System.Text;

namespace CShapAdvancedTips.Class
{
    public class Vehicle
    {
        public int MaxSpeed { get; set; }
    }

    public class Car :Vehicle
    {

    }

    public class Processor
    {
        public int MaxSpeed { get; set; }
    }

    public class InheritanceTester
    {
        public void Test()
        {
            object car = new Car();
            object processor = new Processor();

            Vehicle vehicle1 = (Vehicle)car;
            int speed1 = vehicle1.MaxSpeed;

            Vehicle vehicle2 = car as Vehicle;
            int speed2 = vehicle1.MaxSpeed;

            Vehicle vehicle3 = (Vehicle)processor;
            int speed3 = vehicle1.MaxSpeed;

            Vehicle vehicle4 = processor as Vehicle;
            int speed4 = vehicle4.MaxSpeed;
        }
    }

}
