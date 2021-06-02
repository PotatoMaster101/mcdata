using System;
using MinecraftData.Core.Nbt;

namespace MinecraftData.Core.Attributes
{
    /// <summary>
    /// Represents a user selected attribute.
    /// </summary>
    public class Attribute : INbt
    {
        /// <summary>
        /// Gets or sets the attribute ID.
        /// </summary>
        /// <value>The attribute ID.</value>
        public string Id { get; set; } = "none";

        /// <summary>
        /// Gets or sets the attribute name.
        /// </summary>
        /// <value>The attribute name.</value>
        public string Name { get; set; } = "none";

        /// <summary>
        /// Gets or sets the attribute item slot.
        /// </summary>
        /// <value>The attribute item slot.</value>
        public string Slot { get; set; } = "none";

        /// <summary>
        /// Gets or sets the attribute operation.
        /// </summary>
        /// <value>The attribute operation.</value>
        public int Operation { get; set; } = 0;

        /// <summary>
        /// Gets or sets the attribute amount.
        /// </summary>
        /// <value>The attribute amount.</value>
        public double Amount { get; set; } = 0.0;

        /// <summary>
        /// Gets or sets the attribute UUID.
        /// </summary>
        /// <value>The attribute UUID.</value>
        public int[] Uuid { get; set; }

        /// <summary>
        /// Constructs a new instance of <see cref="Attribute"/>.
        /// </summary>
        public Attribute()
        {
            var rand = new Random();
            Uuid = new[] { rand.Next(), rand.Next(), rand.Next(), rand.Next() };
        }

        /// <summary>
        /// Converts this object into a NBT string which can be used in commands.
        /// </summary>
        /// <returns>The NBT string representation.</returns>
        public string ToNbt()
        {
            return $"{{Slot:\"{Slot}\",AttributeName:\"{Id}\",Name:\"{Name}\",Amount:{Amount},Operation:{Operation},UUID:[I;{string.Join(',', Uuid)}]}}";
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
