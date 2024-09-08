using System;
using System.Collections.Generic;

namespace GamePlay
{
    [Serializable]
    public class CharacterUpgradesData
    {
        public readonly List<UpgradeData> UpgradeDatas;

        public CharacterUpgradesData(int collectionSize)
        {
            UpgradeDatas = new List<UpgradeData>(collectionSize);
        }
    }
    
    [Serializable]
    public readonly struct UpgradeData
    {
        public readonly string Id;
        public readonly int Level;

        public UpgradeData(string id, int level)
        {
            Id = id;
            Level = level;
        }
    }
}