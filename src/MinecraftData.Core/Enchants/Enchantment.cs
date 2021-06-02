using MinecraftData.Core.Nbt;

namespace MinecraftData.Core.Enchants
{
    /// <summary>
    /// Represents a user selected enchantment.
    /// </summary>
    public class Enchantment : INbt
    {
        /// <summary>
        /// Gets or sets the enchantment ID.
        /// </summary>
        /// <value>The enchantment ID.</value>
        public string Id { get; set; } = "none";

        /// <summary>
        /// Gets or sets the enchantment level.
        /// </summary>
        /// <value>The enchantment level.</value>
        public int Level { get; set; } = 0;

        /// <summary>
        /// Converts this object into a NBT string which can be used in commands.
        /// </summary>
        /// <returns>The NBT string representation.</returns>
        public string ToNbt()
        {
            return $"{{id:\"{Id}\",lvl:{Level}}}";
        }

        /// <summary>
        /// Returns the <see cref="string"/> representation of this object.
        /// </summary>
        /// <returns>The <see cref="string"/> representation of this object.</returns>
        public override string ToString()
        {
            return Id;
        }
    }
}
