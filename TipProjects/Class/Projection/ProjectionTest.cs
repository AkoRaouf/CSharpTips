using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CShapAdvancedTips.Class.Projection
{
    public class Customer
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public string Family { get; set; }

        public string Address { get; set; }
    }

    public class ProjectionTest
    {
        public void Test()
        {
            var customers = new List<Customer>();

            var client = customers.Select(c => new
            {
                c.Number,
                name = c.Name
            }).ToList();

            client.Add(new { Number = 50, name = "Ahmad" });

            //client.Add(new { Number = 50, name = "Ahmad", family="" });
        }
    }
}
