using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Blacksmith.Enumerations.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IEnumerable<TestEnumeration> enumValues;
            TestEnumeration test;

            enumValues = Enumeration.getAll<TestEnumeration>();
            test = TestEnumeration.Foo;

            Assert.Equal(2, enumValues.Count());
            Assert.True(Enumeration.isDefined(test));
        }
    }
}
