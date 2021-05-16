using System;
using System.Collections.Generic;
using System.IO;
using Google.Protobuf;
using SerializationSystem;
using SerializationSystem.Logging;
using UnityCommons;
using Utils;
using proto = Protocol.Protobuf;
using custom = Protocol.Custom;

namespace protobuf {
    public static class Example3 {
        const int itemCount = 16;

        public static void Run() {
            LogOptions.LogSerialization = false;
            var seed = Rand.Int;

            var memoryStream = new MemoryStream();
            Benchmark.Run("Proto serialization", () => {
                Rand.PushState(seed);
                var protoPlayer = MakeProtoPlayerData();
                Rand.PopState();
                memoryStream.SetLength(0);
                protoPlayer.WriteTo(memoryStream);
            }, 2);

            Benchmark.Run("Custom serialization", () => {
                Rand.PushState(seed);
                var customPlayer = MakeCustomPlayerData();
                Rand.PopState();
                Serializer.Serialize(customPlayer);
                Console.WriteLine($"\n\n\n\n");
            }, 2);

            // memoryStream.SetLength(0);
            // protoPlayer.WriteTo(memoryStream);
            // var protoBytes = memoryStream.Length;
            // var customBytes = Serializer.Serialize(customPlayer);

            // Console.WriteLine($"Proto: \nsize: {protoBytes} bytes");
            // Console.WriteLine($"Custom: \nsize: {customBytes.Length} bytes");
        }

        private static proto::PlayerData MakeProtoPlayerData() {
            var name = new Guid(Rand.Bytes(16)).ToString();
            var transform = new proto::Transform {
                Position = new proto::Vector3 {
                    X = Rand.Range(float.MinValue, float.MaxValue),
                    Y = Rand.Range(float.MinValue, float.MaxValue),
                    Z = Rand.Range(float.MinValue, float.MaxValue)
                },
                Scale = new proto::Vector3 {
                    X = Rand.Range(float.MinValue, float.MaxValue),
                    Y = Rand.Range(float.MinValue, float.MaxValue),
                    Z = Rand.Range(float.MinValue, float.MaxValue)
                },
                EulerAngles = new proto::Vector3 {
                    X = Rand.Range(360.0f),
                    Y = Rand.Range(360.0f),
                    Z = Rand.Range(360.0f)
                }
            };
            var experience = (uint) Rand.Int;
            var maxExperience = (uint) Rand.Int;
            var level = (uint) Rand.Int;
            var items = new List<proto::ItemStack>();
            for (var i = 0; i < itemCount; i++) {
                items.Add(MakeProtoItem());
            }

            return new proto::PlayerData {
                Name = name,
                Transform = transform,
                Experience = experience,
                MaxExperience = maxExperience,
                Level = level,
                Inventory = new proto::Inventory {
                    Items = {items}
                }
            };
        }

        private static proto::ItemStack MakeProtoItem() {
            var count = (uint) Rand.Int;

            var name = new Guid(Rand.Bytes(16)).ToString();
            var typeId = Rand.Range(3);
            var type = (proto::ItemData.Types.ItemType) typeId;

            // BaseStats
            var durability = (uint) Rand.Int;
            var maxDurability = (uint) Rand.Int;
            var level = (uint) Rand.Int;
            var rarity = (proto::BaseItemStats.Types.Rarity) Rand.Range(4);

            var item = new proto::ItemData {Name = name, Type = type};
            var baseStats = new proto::BaseItemStats {Durability = durability, MaxDurability = maxDurability, Level = level, Rarity = rarity};

            switch (typeId) {
                case 0:
                    // ArmorStats
                    var protection = (uint) Rand.Int;
                    var blockChance = Rand.Float;
                    item.ArmorStats = new proto::ArmorStats {Protection = protection, BlockChance = blockChance, BaseStats = baseStats};
                    break;
                case 1:
                    // WeaponStats
                    var damage = (uint) Rand.Int;
                    var critChance = Rand.Float;
                    item.WeaponStats = new proto::WeaponStats {Damage = damage, CritChance = critChance, BaseStats = baseStats};
                    break;
                case 2:
                    // PotionStats
                    var durationMs = (ulong) Rand.Long;
                    var statusEffect = (uint) Rand.Int;
                    var statusMultiplier = Rand.Float;
                    item.PotionStats = new proto::PotionStats {DurationMs = durationMs, StatusEffect = statusEffect, StatusMultiplier = statusMultiplier, BaseStats = baseStats};
                    break;
                default: throw new ArgumentOutOfRangeException();
            }

            return new proto::ItemStack {Item = item, Count = count};
        }

        private static custom::PlayerData MakeCustomPlayerData() {
            var name = new Guid(Rand.Bytes(16)).ToString();
            var transform = new custom::Transform {
                Position = new custom::Vector3 {
                    X = Rand.Range(float.MinValue, float.MaxValue),
                    Y = Rand.Range(float.MinValue, float.MaxValue),
                    Z = Rand.Range(float.MinValue, float.MaxValue)
                },
                Scale = new custom::Vector3 {
                    X = Rand.Range(float.MinValue, float.MaxValue),
                    Y = Rand.Range(float.MinValue, float.MaxValue),
                    Z = Rand.Range(float.MinValue, float.MaxValue)
                },
                EulerAngles = new custom::Vector3 {
                    X = Rand.Range(360.0f),
                    Y = Rand.Range(360.0f),
                    Z = Rand.Range(360.0f)
                }
            };
            var experience = (uint) Rand.Int;
            var maxExperience = (uint) Rand.Int;
            var level = (uint) Rand.Int;
            var items = new List<custom::ItemStack>();
            for (var i = 0; i < itemCount; i++) {
                items.Add(MakeCustomItem());
            }

            return new custom::PlayerData {
                Name = name,
                Transform = transform,
                Experience = experience,
                MaxExperience = maxExperience,
                Level = level,
                Inventory = new custom::Inventory {
                    Items = items
                }
            };
        }

        private static custom::ItemStack MakeCustomItem() {
            var count = (uint) Rand.Int;

            var name = new Guid(Rand.Bytes(16)).ToString();
            var typeId = Rand.Range(3);
            var type = (custom::ItemData.ItemType) typeId;

            // BaseStats
            var durability = (uint) Rand.Int;
            var maxDurability = (uint) Rand.Int;
            var level = (uint) Rand.Int;
            var rarity = (custom::ItemData.ItemRarity) Rand.Range(4);
            custom::ItemData item;

            switch (typeId) {
                case 0:
                    // ArmorStats
                    var protection = (uint) Rand.Int;
                    var blockChance = Rand.Float;
                    item = new custom::ArmorItemData {
                        Name = name, Type = type, Rarity = rarity, Durability = durability, MaxDurability = maxDurability, Level = level, Protection = protection,
                        BlockChance = blockChance
                    };
                    break;
                case 1:
                    // WeaponStats
                    var damage = (uint) Rand.Int;
                    var critChance = Rand.Float;
                    item = new custom::WeaponItemData {
                        Name = name, Type = type, Rarity = rarity, Durability = durability, MaxDurability = maxDurability, Level = level, Damage = damage, CritChance = critChance
                    };
                    break;
                case 2:
                    // PotionStats
                    var durationMs = (ulong) Rand.Long;
                    var statusEffect = (uint) Rand.Int;
                    var statusMultiplier = Rand.Float;
                    item = new custom::PotionItemData {
                        Name = name, Type = type, Rarity = rarity, Durability = durability, MaxDurability = maxDurability, Level = level, Duration = durationMs,
                        StatusEffect = statusEffect,
                        StatusMultiplier = statusMultiplier
                    };
                    break;
                default: throw new ArgumentOutOfRangeException();
            }

            return new custom::ItemStack {Item = item, Count = count};
        }
    }
}