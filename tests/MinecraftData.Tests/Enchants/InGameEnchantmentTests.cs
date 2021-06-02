using System.Collections.Generic;
using System.Linq;
using Xunit;
using MinecraftData.Core.Enchants;

namespace MinecraftData.Tests.Enchants
{
    /// <summary>
    /// Test <see cref="InGameEnchantment"/>.
    /// </summary>
    public class InGameEnchantmentTests
    {
        /// <summary>
        /// Tests <see cref="InGameEnchantment(string, int, IEnumerable{string})"/> assigns value correctly.
        /// </summary>
        [Fact]
        public void Constructor_AssignsCorrectValues()
        {
            // arrange
            var ench = new InGameEnchantment("foobar", 999);

            // act + assert
            Assert.Equal("foobar", ench.Name);
            Assert.Equal(999, ench.MaxLevel);
            Assert.Equal(Enumerable.Empty<string>(), ench.Conflicts);
        }

        /// <summary>
        /// Tests <see cref="InGameEnchantment.ConflictWith(string)"/> returns <see langword="true"/> when conflict exists.
        /// </summary>
        [Fact]
        public void ConflictWith_ReturnsTrue_WhenConflictExists()
        {
            // arrange
            var ench = new InGameEnchantment("foobar", 999, new[] { "baz" });

            // act + assert
            Assert.True(ench.ConflictWith("baz"));
        }

        /// <summary>
        /// Tests <see cref="InGameEnchantment.ConflictWith(string)"/> returns <see langword="false"/> when conflict doesn't exist.
        /// </summary>
        [Fact]
        public void ConflictWith_ReturnsFalse_WhenConflictDoesntExist()
        {
            // arrange
            var ench = new InGameEnchantment("foobar", 999);

            // act + assert
            Assert.False(ench.ConflictWith("baz"));
        }

        /// <summary>
        /// Tests <see cref="InGameEnchantment.ConflictWith(string)"/> returns <see langword="false"/> when <see langword="null"/>.
        /// </summary>
        [Fact]
        public void ConflictWith_ReturnsFalse_WhenNull()
        {
            // arrange
            var ench = new InGameEnchantment("foobar", 999, new[] { "baz" });

            // act + assert
            Assert.False(ench.ConflictWith(null));
        }
    }
}
