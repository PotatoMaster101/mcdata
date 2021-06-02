using System;
using System.Collections.Generic;

namespace MinecraftData.Core.Attributes
{
    /// <summary>
    /// Represents a single attribute in the game.
    /// </summary>
    public record InGameAttribute
    {
        /// <summary>
        /// Gets the attribute display name.
        /// </summary>
        /// <value>The attribute display name.</value>
        public string Name { get; }

        /// <summary>
        /// Gets the attribute default value.
        /// </summary>
        /// <value>The attribute default value.</value>
        public double Default { get; }

        /// <summary>
        /// Gets the attribute minimum value.
        /// </summary>
        /// <value>The attribute minimum value.</value>
        public double Minimum { get; }

        /// <summary>
        /// Gets the attribute maximum value.
        /// </summary>
        /// <value>The attribute maximum value.</value>
        public double Maximum { get; }

        /// <summary>
        /// Constructs a new instance of <see cref="InGameAttribute"/>.
        /// </summary>
        /// <param name="name">The name of the attribute.</param>
        /// <param name="def">The default value of the attribute.</param>
        /// <param name="min">The minimum value of the attribute.</param>
        /// <param name="max">The maximum value of the attribute.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="max"/> is less than <paramref name="min"/>.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="name"/> is <see langword="null"/>.</exception>
        public InGameAttribute(string name, double def, double min, double max)
        {
            if (max < min)
                throw new ArgumentOutOfRangeException(nameof(max));

            Name = name ?? throw new ArgumentNullException(nameof(name));
            Default = def;
            Minimum = min;
            Maximum = max;
        }

        /// <summary>
        /// Checks whether the given value is in range.
        /// </summary>
        /// <param name="val">The value to check.</param>
        /// <returns><see langword="true"/> if <paramref name="val"/> is in range; otherwise <see langword="false"/>.</returns>
        public bool InRange(double val)
        {
            return (val >= Minimum) && (val <= Maximum);
        }
    }

    /// <summary>
    /// Contains a lookup table of all in game attributes.
    /// </summary>
    public static class InGameAttributeLookup
    {
        /// <summary>
        /// A lookup table of all the in game attributes.
        /// </summary>
        public static readonly IReadOnlyDictionary<string, InGameAttribute> Lookup = new Dictionary<string, InGameAttribute>
        {
            ["generic.armor_toughness"] = new InGameAttribute("Armor Toughness", 0, 0, 20),
            ["generic.armor"] = new InGameAttribute("Armor", 0, 0, 30),
            ["generic.attack_damage"] = new InGameAttribute("Attack Damage", 1, 0, 2048),
            ["generic.attack_knockback"] = new InGameAttribute("Attack Knockback", 0, 0, 8),
            ["generic.attack_speed"] = new InGameAttribute("Attack Speed", 4, 0, 1024),
            ["generic.flying_speed"] = new InGameAttribute("Parrot Fly Speed", 0.4, 0, 1024),
            ["generic.follow_range"] = new InGameAttribute("Follow Range", 32, 0, 2048),
            ["generic.knockback_resistance"] = new InGameAttribute("Knockback Resistance", 0, 0, 1),
            ["generic.luck"] = new InGameAttribute("Luck", 0, -1024, 1024),
            ["generic.max_health"] = new InGameAttribute("Max Health", 20, 0, 1024),
            ["generic.movement_speed"] = new InGameAttribute("Movement Speed", 0.7, 0, 1024),
            ["horse.jump_strength"] = new InGameAttribute("Horse Jump Strength", 0.7, 0, 2),
            ["zombie.spawn_reinforcements"] = new InGameAttribute("Zombie Reinforcements Chance", 0, 0, 1),
        };
    }
}
