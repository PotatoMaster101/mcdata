using Xunit;
using MinecraftData.Core.Attributes;

namespace MinecraftData.Tests.Attributes
{
    /// <summary>
    /// Tests for <see cref="Attribute"/>.
    /// </summary>
    public class AttributeTests
    {
        /// <summary>
        /// Tests <see cref="Attribute.ToNbt"/> returns the correct NBT string.
        /// </summary>
        [Fact]
        public void ToNbt_ReturnsCorrectNbt()
        {
            // arrange
            var atr = new Attribute
            {
                Id = "test",
                Name = "Test",
                Slot = "SlotA",
                Operation = 3,
                Amount = 5.4,
            };
            var uuidStr = string.Join(',', atr.Uuid);
            var expected = $"{{Slot:\"SlotA\",AttributeName:\"test\",Name:\"Test\",Amount:5.4,Operation:3,UUID:[I;{uuidStr}]}}";

            // act + assert
            Assert.Equal(expected, atr.ToNbt());
        }

        /// <summary>
        /// Tests <see cref="Attribute.ToString"/> returns the correct ID.
        /// </summary>
        [Fact]
        public void ToString_ReturnsCorrectId()
        {
            // arrange
            var atr = new Attribute
            {
                Id = "FooBar"
            };

            // act + assert
            Assert.Equal("FooBar", atr.ToString());
        }
    }
}
