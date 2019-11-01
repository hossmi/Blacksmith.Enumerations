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
            IEnumerable<ServerStatus> enumValues;
            ServerStatus test;

            enumValues = Enumeration.getAll<ServerStatus>();
            test = ServerStatus.Off;

            Assert.Equal(5, enumValues.Count());
            Assert.True(Enumeration.isDefined(test));
        }
    }
}
