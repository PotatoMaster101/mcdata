using System;
using System.Collections.Generic;

namespace MinecraftData.Core.Potions
{
    /// <summary>
    /// Represents a single potion effect in the game.
    /// </summary>
    public record InGamePotionEffect
    {
        /// <summary>
        /// Gets the potion effect numeric ID.
        /// </summary>
        /// <value>The potion effect numeric ID.</value>
        public byte NumericId { get; }

        /// <summary>
        /// Gets the potion effect name.
        /// </summary>
        /// <value>The potion effect name.</value>
        public string Name { get; }

        /// <summary>
        /// Gets the potion effect type.
        /// </summary>
        public PotionEffectType EffectType { get; }

        /// <summary>
        /// Constructs a new instance of <see cref="InGamePotionEffect"/>.
        /// </summary>
        /// <param name="numId">The numeric ID of the potion effect.</param>
        /// <param name="id">The ID of the potion effect.</param>
        /// <param name="name">The name of the potion effect.</param>
        /// <param name="type">The type of the potion effect.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="name"/> is <see langword="null"/>.</exception>
        public InGamePotionEffect(byte numId, string name, PotionEffectType type = PotionEffectType.Positive)
        {
            NumericId = numId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            EffectType = type;
        }
    }

    /// <summary>
    /// Contains a lookup table of all in game potion effects.
    /// </summary>
    public static class InGamePotionEffectLookup
    {
        /// <summary>
        /// A lookup table of all the in game potion effects.
        /// </summary>
        public static readonly IReadOnlyDictionary<string, InGamePotionEffect> Lookup = new Dictionary<string, InGamePotionEffect>
        {
            ["absorption"] = new InGamePotionEffect(22, "Absorption", PotionEffectType.Positive),
            ["bad_omen"] = new InGamePotionEffect(31, "Bad Omen", PotionEffectType.Neutral),
            ["blindness"] = new InGamePotionEffect(15, "Blindness", PotionEffectType.Negative),
            ["conduit_power"] = new InGamePotionEffect(29, "Conduit Power", PotionEffectType.Positive),
            ["dolphins_grace"] = new InGamePotionEffect(30, "Dolphin's Grace", PotionEffectType.Positive),
            ["fire_resistance"] = new InGamePotionEffect(12, "Fire Resistance", PotionEffectType.Positive),
            ["glowing"] = new InGamePotionEffect(24, "Glowing", PotionEffectType.Neutral),
            ["haste"] = new InGamePotionEffect(3, "Haste", PotionEffectType.Positive),
            ["health_boost"] = new InGamePotionEffect(21, "Health Boost", PotionEffectType.Positive),
            ["hero_of_the_village"] = new InGamePotionEffect(32, "Hero of the Village", PotionEffectType.Positive),
            ["hunger"] = new InGamePotionEffect(17, "Hunger", PotionEffectType.Negative),
            ["instant_damage"] = new InGamePotionEffect(7, "Instant Damage", PotionEffectType.Negative),
            ["instant_health"] = new InGamePotionEffect(6, "Instant Health", PotionEffectType.Positive),
            ["invisibility"] = new InGamePotionEffect(14, "Invisibility", PotionEffectType.Positive),
            ["jump_boost"] = new InGamePotionEffect(8, "Jump Boost", PotionEffectType.Positive),
            ["levitation"] = new InGamePotionEffect(25, "Levitation", PotionEffectType.Negative),
            ["luck"] = new InGamePotionEffect(26, "Luck", PotionEffectType.Positive),
            ["mining_fatigue"] = new InGamePotionEffect(4, "Mining Fatigue", PotionEffectType.Negative),
            ["nausea"] = new InGamePotionEffect(9, "Nausea", PotionEffectType.Negative),
            ["night_vision"] = new InGamePotionEffect(16, "Night Vision", PotionEffectType.Positive),
            ["poison"] = new InGamePotionEffect(19, "Poison", PotionEffectType.Negative),
            ["regeneration"] = new InGamePotionEffect(10, "Regeneration", PotionEffectType.Positive),
            ["resistance"] = new InGamePotionEffect(11, "Resistance", PotionEffectType.Positive),
            ["saturation"] = new InGamePotionEffect(23, "Saturation", PotionEffectType.Positive),
            ["slow_falling"] = new InGamePotionEffect(28, "Slow Falling", PotionEffectType.Positive),
            ["slowness"] = new InGamePotionEffect(2, "Slowness", PotionEffectType.Negative),
            ["speed"] = new InGamePotionEffect(1, "Speed", PotionEffectType.Positive),
            ["strength"] = new InGamePotionEffect(5, "Strength", PotionEffectType.Positive),
            ["unluck"] = new InGamePotionEffect(27, "Bad Luck", PotionEffectType.Negative),
            ["water_breathing"] = new InGamePotionEffect(13, "Water Breathing", PotionEffectType.Positive),
            ["weakness"] = new InGamePotionEffect(18, "Weakness", PotionEffectType.Negative),
            ["wither"] = new InGamePotionEffect(20, "Wither", PotionEffectType.Negative),
        };
    }
}
