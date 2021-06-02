using Xunit;
using MinecraftData.Core.Potions;

namespace MinecraftData.Tests.Potions
{
    /// <summary>
    /// Tests <see cref="PotionEffect"/>.
    /// </summary>
    public class PotionEffectTests
    {
        /// <summary>
        /// Tests <see cref="PotionEffect.ToNbt"/> returns the correct NBT string.
        /// </summary>
        [Fact]
        public void ToNbt_ReturnsCorrectNbt()
        {
            // arrange
            var pot = new PotionEffect
            {
                Id = 50,
                Amplifier = 30,
                Duration = -1,
                Ambient = true,
                ShowParticles = false,
                ShowIcon = false
            };
            var expected = "{Id:50,Amplifier:30,Duration:-1,Ambient:1,ShowParticles:0,ShowIcon:0}";

            // act + assert
            Assert.Equal(expected, pot.ToNbt());
        }

        /// <summary>
        /// Tests <see cref="PotionEffect.ToString"/> returns the correct ID.
        /// </summary>
        [Fact]
        public void ToStrirng_ReturnsCorrectId()
        {
            // arrange
            var pot = new PotionEffect
            {
                Id = 255
            };

            // act + assert
            Assert.Equal("255", pot.ToString());
        }
    }
}
