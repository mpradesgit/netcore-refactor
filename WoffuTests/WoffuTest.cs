using Xunit;
using System.Collections.Generic;
using WoffuKata;

namespace WoffuTests
{
    public class WoffuTest
    {
        [Fact]
        public void Foo()
        {
            IList<Allocation> allocations = new List<Allocation> { new Allocation { Name = "foo", DaysToExpiration = 0, Availability = 0 } };
            Woffu app = new Woffu(allocations);
            app.UpdateAvailability();
            Assert.Equal("fixme", allocations[0].Name);
        }
    }
}
