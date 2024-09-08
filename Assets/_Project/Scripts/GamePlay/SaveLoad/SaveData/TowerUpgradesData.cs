using System;
using System.Collections.Generic;

namespace GamePlay
{
    [Serializable]
    public class TowerUpgradesData
    {
        public readonly List<UpgradeData> UpgradeDatas;

        public TowerUpgradesData(int collectionSize)
        {
            UpgradeDatas = new List<UpgradeData>(collectionSize);
        }
    }
}