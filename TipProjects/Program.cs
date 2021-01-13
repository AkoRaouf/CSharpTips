using System;
using System.Diagnostics;

namespace ConsoleForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person() { Name = "Mike" };
            p.DoSomething();
            p.DoSomething();
            

            Base bs = new Base();
            bs.MyMethod();

            Drived dr = new Drived();
            dr.MyMethod();

            Base br = new Drived();
            br.MyMethod();

            Base br2 = (Base)dr;
            br2.MyMethod();

            Base br3 = (Base)br;
            br3.MyMethod();

            Console.ReadLine();
        }
    }

    public class Base : AbstClass
    {
        public override void IAMethod()
        {
            throw new NotImplementedException();
        }

        public virtual void MyMethod()
        {
            Trace.WriteLine("This is the base class");
        }

        protected override void MyAbsMethod()
        {
            throw new NotImplementedException();
        }
    }

    public class Drived : Base
    {

    }

    public interface IA
    {
        public void IAMethod();
    }

    public abstract class AbstClass : IA
    {
        protected abstract void MyAbsMethod();

        public virtual void MyVirMethod()
        {

        }

        public abstract void IAMethod();
    }
}
