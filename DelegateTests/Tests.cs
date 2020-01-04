using System;
using Xunit;

namespace DelegateTests
{
    public class Tests
    {
        class A
        {
            public void M()
            {
            }
        }

        [Fact]
        public void ActionsCreatedFromTheSameClassMemberAreEqualTest()
        {
            var a = new A();
            Assert.True(new Action(a.M) == new Action(a.M));
        }

        struct B
        {
            public void M()
            {
            }
        }

        [Fact]
        public void ActionsCreatedFromTheSameStructMemberAreEqualTest()
        {
            var b = new B();
            Assert.True(new Action(b.M) == new Action(b.M));
        }
    }
}
