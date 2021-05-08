using System.Collections.Generic;
using SerializationSystem;

namespace Protocol.Custom {
    public class PlayerData {
        [field: Serialized] public string Name { get; set; }
        [field: Serialized] public Transform Transform { get; set; }

        [field: Serialized] public uint Experience { get; set; }
        [field: Serialized] public uint MaxExperience { get; set; }
        [field: Serialized] public uint Level { get; set; }

        [field: Serialized] public Inventory Inventory { get; set; }
    }

    public class Inventory {
        [field: Serialized] public List<ItemStack> Items { get; set; }
    }

    public class ItemStack {
        [field: Serialized] public ItemData Item { get; set; }
        [field: Serialized] public uint Count { get; set; }
    }

    public class ItemData {
        public enum ItemType : byte {
            Armor = 0,
            Weapon = 1,
            Potion = 2
        }

        public enum ItemRarity : byte {
            Common = 0,
            Uncommon = 1,
            Rare = 2,
            Legendary = 3
        }

        [field: Serialized] public ItemType Type { get; set; }
        [field: Serialized] public string Name { get; set; }

        // Base stats
        [field: Serialized] public uint Durability { get; set; }
        [field: Serialized] public uint MaxDurability { get; set; }
        [field: Serialized] public uint Level { get; set; }
        [field: Serialized] public ItemRarity Rarity { get; set; }
    }

    public sealed class ArmorItemData : ItemData {
        // Armor stats
        [field: Serialized] public uint Protection { get; set; }
        [field: Serialized] public float BlockChance { get; set; }
    }

    public sealed class WeaponItemData : ItemData {
        // Weapon stats
        [field: Serialized] public uint Damage { get; set; }
        [field: Serialized] public float CritChance { get; set; }
    }

    public sealed class PotionItemData : ItemData {
        // Potion stats
        [field: Serialized] public ulong Duration { get; set; }
        [field: Serialized] public uint StatusEffect { get; set; }
        [field: Serialized] public float StatusMultiplier { get; set; }
    }
}