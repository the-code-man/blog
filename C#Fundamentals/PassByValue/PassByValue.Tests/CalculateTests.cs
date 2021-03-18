using System;
using Xunit;

namespace PassByValue.Tests
{
    public class CalculateTests
    {
        private Point _point;
        private readonly Calculate _sut;

        public CalculateTests()
        {
            _point = new Point { X = 10 };
            _sut = new Calculate();
        }

        [Fact]
        public void Square_Should_MultiplyXByItself_And_ModifySameObject()
        {
            _sut.Square(_point);
            Assert.Equal(100, _point.X);
        }

        [Fact]
        public void SquareWithNewObject_Should_MultiplyXByItself_And_ModifySameObject()
        {
            _sut.SquareWithNewObject(_point);
            Assert.Equal(100, _point.X);
        }

        [Fact]
        public void SquareWithNewObjectPassByRef_Should_MultiplyXByItself_And_ModifySameObject()
        {
            _sut.SquareWithNewObjectPassByRef(ref _point);
            Assert.Equal(100, _point.X);
        }
    }
}