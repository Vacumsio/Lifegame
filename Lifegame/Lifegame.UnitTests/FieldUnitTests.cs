using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Sdk;

namespace Lifegame.UnitTests
{
    public class FieldUnitTests
    {
        [Fact]
        public void Set_shouldNot_crashed()
        {
            var f = new Field(10, 10);

            f.Set(4, 5, true);

            bool val = f.Get(4, 5);

            if (val != true)
            {
                throw new Exception("val was not set up!");
            }
        }

        [Fact]
        public void Set_should_crashed()
        {
            var f = new Field(3, 3);

            try
            {
                f.Set(4, 1, true);
            }
            catch (ArgumentOutOfRangeException e)
            {
                return;
            }

            throw new Exception("Exception was not thrown!");
        }
    }
}
