using Xunit;
using MinecraftData.Core.Enchants;

namespace MinecraftData.Tests.Enchants
{
    /// <summary>
    /// Test <see cref="InGameEnchantmentLookup"/>.
    /// </summary>
    public class InGameEnchantmentLookupTests
    {
        /// <summary>
        /// Tests <see cref="InGameEnchantmentLookup.Lookup"/> item count is correct.
        /// </summary>
        [Fact]
        public void Lookup_ItemCountCorrect()
        {
            // act + assert
            Assert.Equal(39, InGameEnchantmentLookup.Lookup.Count);
        }
    }
}
