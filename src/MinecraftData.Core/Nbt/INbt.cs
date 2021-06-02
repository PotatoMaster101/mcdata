namespace MinecraftData.Core.Nbt
{
    /// <summary>
    /// Represents an NBT tag in Minecraft.
    /// </summary>
    public interface INbt
    {
        /// <summary>
        /// Converts this object into a NBT string which can be used in commands.
        /// </summary>
        /// <returns>The NBT string representation.</returns>
        string ToNbt();
    }
}
