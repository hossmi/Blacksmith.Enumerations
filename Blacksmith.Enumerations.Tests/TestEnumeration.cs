namespace Blacksmith.Enumerations.Tests
{
    public class TestEnumeration : DescribedEnumeration
    {
        private TestEnumeration(int id, string name, string description) : base(id, name, description)
        {
        }

        public static TestEnumeration Foo => new TestEnumeration(1, "foo", "Lorem ipsum sit amet.");
        public static TestEnumeration Bar => new TestEnumeration(1, "bar", "Yet another description.");
    }
}
