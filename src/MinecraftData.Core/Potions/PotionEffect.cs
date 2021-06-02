using System;
using MinecraftData.Core.Nbt;

namespace MinecraftData.Core.Potions
{
    /// <summary>
    /// Represents a user selected potion effect.
    /// </summary>
    public class PotionEffect : INbt
    {
        /// <summary>
        /// Gets or sets the ID of the potion effect.
        /// </summary>
        /// <value>The ID of the potion effect.</value>
        public byte Id { get; set; } = 0;

        /// <summary>
        /// Gets or sets the level of the potion effect.
        /// </summary>
        /// <value>The level of the potion effect.</value>
        public byte Amplifier { get; set; } = 0;

        /// <summary>
        /// Gets or sets the duration of the potion effect.
        /// </summary>
        /// <value>The duration of the potion effect.</value>
        public int Duration { get; set; } = 0;

        /// <summary>
        /// Gets or sets whether the potion effect is from a beacon.
        /// </summary>
        /// <value>Whether the potion effect is from a beacon.</value>
        public bool Ambient { get; set; } = false;

        /// <summary>
        /// Gets or sets whether the potion effect particle is showing.
        /// </summary>
        /// <value>Whether the potion effect particle is showing.</value>
        public bool ShowParticles { get; set; } = true;

        /// <summary>
        /// Gets or sets whether the potion effect icon is shown.
        /// </summary>
        /// <value>Whether the potion effect is shown.</value>
        public bool ShowIcon { get; set; } = true;

        /// <summary>
        /// Converts this object into a NBT string which can be used in commands.
        /// </summary>
        /// <returns>The NBT string representation.</returns>
        public string ToNbt()
        {
            int amb = Convert.ToInt32(Ambient), part = Convert.ToInt32(ShowParticles), icon = Convert.ToInt32(ShowIcon);
            return $"{{Id:{Id},Amplifier:{Amplifier},Duration:{Duration},Ambient:{amb},ShowParticles:{part},ShowIcon:{icon}}}";
        }

        /// <summary>
        /// Returns the <see cref="string"/> representation of this object.
        /// </summary>
        /// <returns>The <see cref="string"/> representation of this object.</returns>
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
