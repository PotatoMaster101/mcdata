using System;
using Xunit;
using MinecraftData.Core.Attributes;

namespace MinecraftData.Tests.Attributes
{
    /// <summary>
    /// Tests for <see cref="InGameAttribute"/>.
    /// </summary>
    public class InGameAttributeTests
    {
        /// <summary>
        /// Tests <see cref="InGameAttribute(string, double, double, double)"/> assigns correct values.
        /// </summary>
        [Fact]
        public void Constructor_AssignsCorrectValues()
        {
            // arrange
            var atr = new InGameAttribute("abc", 5.99, -9999.5, double.PositiveInfinity);

            // act + assert
            Assert.Equal("abc", atr.Name);
            Assert.Equal(5.99, atr.Default);
            Assert.Equal(-9999.5, atr.Minimum);
            Assert.Equal(double.PositiveInfinity, atr.Maximum);
        }

        /// <summary>
        /// Tests <see cref="InGameAttribute(string, double, double, double)"/> throws on <see langword="null"/>.
        /// </summary>
        [Fact]
        public void Constructor_ThrowsOnNull()
        {
            // act + assert
            Assert.Throws<ArgumentNullException>(delegate { new InGameAttribute(null, 0.0, -1.0, 1.0); });
        }

        /// <summary>
        /// Tests <see cref="InGameAttribute(string, double, double, double)"/> throws on invalid range (when min > max).
        /// </summary>
        [Fact]
        public void Constructor_ThrowsOnInvalidRange()
        {
            // act + assert
            Assert.Throws<ArgumentOutOfRangeException>(delegate { new InGameAttribute("abc", 0.0, double.PositiveInfinity, double.NegativeInfinity); });
        }

        /// <summary>
        /// Tests <see cref="InGameAttribute.InRange(double)"/> returns <see langword="true"/> when value is in range.
        /// </summary>
        [Fact]
        public void InRange_ReturnsTrue_WhenInRange()
        {
            // arrange
            var atr = new InGameAttribute("abc", 0.0, -1.0, 1.0);

            // act + assert
            Assert.True(atr.InRange(0.99));
        }

        /// <summary>
        /// Tests <see cref="InGameAttribute.InRange(double)"/> returns <see langword="false"/> when value is out of range.
        /// </summary>
        [Fact]
        public void InRange_ReturnsFalse_WhenOutOfRange()
        {
            // arrange
            var atr = new InGameAttribute("abc", 0.0, -1.0, 1.0);

            // act + assert
            Assert.False(atr.InRange(1.01));
        }
    }
}
