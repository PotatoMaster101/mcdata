using Xunit;
using MinecraftData.Core.Potions;
using System;

namespace MinecraftData.Tests.Potions
{
    /// <summary>
    /// Tests <see cref="InGamePotionEffect"/>.
    /// </summary>
    public class InGamePotionEffectTests
    {
        /// <summary>
        /// Tests <see cref="InGamePotionEffect(byte, string, PotionEffectType)"/> assigns value correctly.
        /// </summary>
        [Fact]
        public void Constructor_AssignsCorrectValues()
        {
            // arrange
            var pot = new InGamePotionEffect(255, "abc");

            // act + assert
            Assert.Equal(255, pot.NumericId);
            Assert.Equal("abc", pot.Name);
            Assert.Equal(PotionEffectType.Positive, pot.EffectType);
        }

        /// <summary>
        /// Tests <see cref="InGamePotionEffect(byte, string, PotionEffectType)"/> throws on <see langword="null"/>.
        /// </summary>
        [Fact]
        public void Constructor_ThrowsOnNull()
        {
            // act + assert
            Assert.Throws<ArgumentNullException>(delegate { new InGamePotionEffect(0, null, PotionEffectType.Positive); });
        }
    }
}
