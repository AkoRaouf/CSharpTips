using System;

namespace CShapAdvancedTips.Equality
{
    public class DifferentTypes
    {
        public void TestIt()
        {
            var dt1 = new DateTimeOffset(2010, 1, 1, 1, 1, 1, TimeSpan.FromHours(8));
            var dt2 = new DateTimeOffset(2010, 1, 1, 2, 1, 1, TimeSpan.FromHours(9));

            var a = DateTimeOffset.Now;
            var b = DateTime.Now;

            var res1 = dt1 == dt2;

            var res2 = dt1.Equals(dt2);

            var dtt = DateTime.Now;

            var dtt1 = dtt;
            var dtt2 = dtt;

            var res3 = dtt1 == dtt2;
            var res4 = dtt1.Equals(dtt2);
        }
    }
}
