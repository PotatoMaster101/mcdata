using MinecraftData.Core.Enchants;
using Xunit;

namespace MinecraftData.Tests.Enchants
{
    /// <summary>
    /// Tests for <see cref="Enchantment"/>.
    /// </summary>
    public class EnchantmentTests
    {
        /// <summary>
        /// Tests <see cref="Enchantment.ToNbt"/> returns the correct NBT string.
        /// </summary>
        [Fact]
        public void ToNbt_ReturnsCorrectNbt()
        {
            // arrange
            var ench = new Enchantment
            {
                Id = "foo",
                Level = -1
            };

            // act + assert
            Assert.Equal("{id:\"foo\",lvl:-1}", ench.ToNbt());
        }

        /// <summary>
        /// Tests <see cref="Enchantment.ToString"/> returns the correct ID.
        /// </summary>
        [Fact]
        public void ToString_ReturnsCorrectId()
        {
            // arrange
            var ench = new Enchantment
            {
                Id = "abc_foo_bar"
            };

            // act + assert
            Assert.Equal("abc_foo_bar", ench.ToString());
        }
    }
}
