using MinecraftData.Core.Attributes;
using Xunit;

namespace MinecraftData.Tests.Attributes
{
    /// <summary>
    /// Tests for <see cref="InGameAttributeLookup"/>.
    /// </summary>
    public class InGameAttributeLookupTests
    {
        /// <summary>
        /// Tests <see cref="InGameAttributeLookup.Lookup"/> item count is correct.
        /// </summary>
        [Fact]
        public void Lookup_ItemCountCorrect()
        {
            // act + assert
            Assert.Equal(13, InGameAttributeLookup.Lookup.Count);
        }
    }
}
