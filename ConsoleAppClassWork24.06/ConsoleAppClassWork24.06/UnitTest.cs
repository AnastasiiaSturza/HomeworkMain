using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleAppClassWork24._06
{
    public class UnitTest
    {
        [Fact]
        public void AddMeeetingController()
        {

            //arange (setup)
            var sut = new UnitTest();
            var nextControler = sut.Equals(sut);

            //act 
            var moqrepoz = new Mock<>();

            //asert
           // Assert.Throws<ArgumentException>(() => sut.AddMeeetingController(nextControler));

        }

        [Theory]
        [InlineData("2022/25/25")]
        [InlineData("1321314546")]
        public void RemoveMeeetingController()
        {
        // .....
        }

    }
}
