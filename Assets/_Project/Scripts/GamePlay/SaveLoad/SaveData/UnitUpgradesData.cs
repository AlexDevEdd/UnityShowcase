using System;
using System.Collections.Generic;

namespace GamePlay
{
    [Serializable]
    public class UnitUpgradesData
    {
        public readonly List<UpgradeData> UpgradeDatas;

        public UnitUpgradesData(int collectionSize)
        {
            UpgradeDatas = new List<UpgradeData>(collectionSize);
        }
    }
}