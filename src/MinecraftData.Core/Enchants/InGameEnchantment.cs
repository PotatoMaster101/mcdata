using System;
using System.Collections.Generic;
using System.Linq;

namespace MinecraftData.Core.Enchants
{
    /// <summary>
    /// Represents a single enchantment in the game.
    /// </summary>
    public record InGameEnchantment
    {
        /// <summary>
        /// Gets the enchantment name.
        /// </summary>
        /// <value>The enchantment name.</value>
        public string Name { get; }

        /// <summary>
        /// Gets the maximum enchant level allowed.
        /// </summary>
        /// <value>The maximum enchant level allowed.</value>
        public int MaxLevel { get; }

        /// <summary>
        /// Gets the collection of conflict enchants.
        /// </summary>
        /// <value>The collection of conflict enchants.</value>
        public IEnumerable<string> Conflicts { get; }

        /// <summary>
        /// Constructs a new instance of <see cref="InGameEnchantment"/>.
        /// </summary>
        /// <param name="name">The name of the enchantment.</param>
        /// <param name="maxlvl">The maximum level of the enchantment.</param>
        /// <param name="conflicts">Collection of enchant conflicts. <see langword="null"/> if no conflicts.</param>
        public InGameEnchantment(string name, int maxlvl, IEnumerable<string> conflicts = null)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            MaxLevel = maxlvl;
            Conflicts = conflicts ?? Enumerable.Empty<string>();
        }

        /// <summary>
        /// Checks whether the current enchantment conflicts with the given enchantment.
        /// </summary>
        /// <param name="id">The ID of the enchantment to check.</param>
        /// <returns><see langword="true"/> if conflict exists, <see langword="false"/> otherwise.</returns>
        public bool ConflictWith(string id)
        {
            return id is not null && Conflicts.Contains(id);
        }
    }

    /// <summary>
    /// Contains a lookup table of all in game enchantments.
    /// </summary>
    public static class InGameEnchantmentLookup
    {
        /// <summary>
        /// A lookup table of all the in game enchantments.
        /// </summary>
        public static readonly IReadOnlyDictionary<string, InGameEnchantment> Lookup = new Dictionary<string, InGameEnchantment>
        {
            ["aqua_affinity"] = new InGameEnchantment("Aqua Affinity", 1),
            ["bane_of_arthropods"] = new InGameEnchantment("Bane of Arthropods", 5, new[] { "smite", "sharpness" }),
            ["binding_curse"] = new InGameEnchantment("Curse of Binding", 1),
            ["blast_protection"] = new InGameEnchantment("Blast Protection", 4, new[] { "protection", "fire_protection", "projectile_protection" }),
            ["channeling"] = new InGameEnchantment("Channeling", 1, new[] { "riptide" }),
            ["chopping"] = new InGameEnchantment("Chopping", 3, new[] { "sharpness", "bane_of_arthropods", "smite" }),
            ["depth_strider"] = new InGameEnchantment("Depth Strider", 3, new[] { "frost_walker" }),
            ["efficiency"] = new InGameEnchantment("Efficiency", 5),
            ["feather_falling"] = new InGameEnchantment("Feather Falling", 4),
            ["fire_aspect"] = new InGameEnchantment("Fire Aspect", 2),
            ["fire_protection"] = new InGameEnchantment("Fire Protection", 4, new[] { "protection", "blast_protection", "projectile_protection" }),
            ["flame"] = new InGameEnchantment("Flame", 1),
            ["fortune"] = new InGameEnchantment("Fortune", 3, new[] { "silk_touch" }),
            ["frost_walker"] = new InGameEnchantment("Frost Walker", 2, new[] { "depth_strider" }),
            ["impaling"] = new InGameEnchantment("Impaling", 5),
            ["infinity"] = new InGameEnchantment("Infinity", 1),
            ["knockback"] = new InGameEnchantment("Knockback", 2),
            ["looting"] = new InGameEnchantment("Looting", 3),
            ["loyalty"] = new InGameEnchantment("Loyalty", 3, new[] { "riptide" }),
            ["luck_of_the_sea"] = new InGameEnchantment("Luck of the Sea", 3),
            ["lure"] = new InGameEnchantment("Lure", 3),
            ["mending"] = new InGameEnchantment("Mending", 1, new[] { "infinity" }),
            ["multishot"] = new InGameEnchantment("Multishot", 1, new[] { "piercing" }),
            ["piercing"] = new InGameEnchantment("Piercing", 4, new[] { "multishot" }),
            ["power"] = new InGameEnchantment("Power", 5),
            ["projectile_protection"] = new InGameEnchantment("Projectile Protection", 4, new[] { "protection", "blast_protection", "fire_protection" }),
            ["protection"] = new InGameEnchantment("Protection", 4, new[] { "projectile_protection", "blast_protection", "fire_protection" }),
            ["punch"] = new InGameEnchantment("Punch", 2),
            ["quick_charge"] = new InGameEnchantment("Quick Charge", 3),
            ["respiration"] = new InGameEnchantment("Respiration", 3),
            ["riptide"] = new InGameEnchantment("Riptide ", 3, new[] { "channeling", "loyalty" }),
            ["sharpness"] = new InGameEnchantment("Sharpness", 5, new[] { "bane_of_arthropods", "smite" }),
            ["silk_touch"] = new InGameEnchantment("Silk Touch", 1, new[] { "fortune" }),
            ["smite"] = new InGameEnchantment("Smite", 5, new[] { "bane_of_arthropods", "sharpness" }),
            ["soul_speed"] = new InGameEnchantment("Soul Speed", 3),
            ["sweeping"] = new InGameEnchantment("Sweeping Edge", 3),
            ["thorns"] = new InGameEnchantment("Thorns", 3),
            ["unbreaking"] = new InGameEnchantment("Unbreaking", 3),
            ["vanishing_curse"] = new InGameEnchantment("Curse of Vanishing", 1),
        };
    }
}
