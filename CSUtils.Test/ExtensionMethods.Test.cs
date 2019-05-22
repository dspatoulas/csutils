using NUnit.Framework;
using System.Collections.Generic;
using CSUtils.ExtensionMethods;

namespace CSUtilsTest
{
    public class ExtensionMethodTest
    {
        [Test]
        public void TestUniqueListReturnsTrue()
        {
            var list = new List<string>
            {
                "foo",
                "bar",
                "baz"
            };
            Assert.IsTrue(list.IsUnique());
        }

        [Test]
        public void TestDuplicateListReturnsFalse()
        {
            var list = new List<string>
            {
                "foo",
                "foo",
                "bar",
                "baz"
            };
            Assert.IsFalse(list.IsUnique());
        }

        [Test]
        public void TestEmptyListReturnsTrue()
        {
            var list = new List<string>();
            Assert.IsTrue(list.IsNullOrEmpty());
        }


        [Test]
        public void TestNullListReturnsTrue()
        {
            List<string> list = null;
            Assert.IsTrue(list.IsNullOrEmpty());
        }

        [Test]
        public void TestNonEmptyListReturnsFalse()
        {
            var list = new List<string>()
            {
                "foo"
            };
            Assert.IsFalse(list.IsNullOrEmpty());
        }
    }
}