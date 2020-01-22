using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SoCraTesFrOrganizer.Test.API
{
    [TestFixture]
    public class RangeTest
    {
        [Test]
        public void EmptyDate()
        {
            Assert.Catch<ArgumentException>(() => Range.Of(new DateTime(0), new DateTime(0)));
        }

        [Test]
        public void WithTwoDateValid()
        {
            Range range = Range.Of(new DateTime(2020, 10, 24), new DateTime(2020, 10, 25));
            Assert.IsNotNull(range);
        }

        [Test]
        public void WithTwoDateNotValid()
        {
            Assert.Catch<ArgumentException>(() => Range.Of(new DateTime(2020, 10, 24), new DateTime(2020, 10, 23)));
        }
    }
}
