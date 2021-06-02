using Xunit;
using MinecraftData.Core.Potions;

namespace MinecraftData.Tests.Potions
{
    /// <summary>
    /// Tests <see cref="InGamePotionEffectLookup"/>.
    /// </summary>
    public class InGamePotionEffectLookupTests
    {
        /// <summary>
        /// Tests <see cref="InGamePotionEffectLookup.Lookup"/> item count is correct.
        /// </summary>
        [Fact]
        public void Lookup_ItemCountCorrect()
        {
            // act + assert
            Assert.Equal(32, InGamePotionEffectLookup.Lookup.Count);
        }
    }
}
