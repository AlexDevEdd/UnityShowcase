namespace GamePlay
{
    // [UsedImplicitly]
    // public sealed class CharacterUpgradesSaveLoader : SaveLoader<CharacterUpgradesData, CharacterStatCollection>
    // {
    //     public CharacterUpgradesSaveLoader(GameRepository repository, CharacterStatCollection statCollection) 
    //         : base(repository, statCollection) { }
    //
    //     protected override CharacterUpgradesData ConvertToData(CharacterStatCollection statCollection)
    //     {
    //         var stats = statCollection.GetStats();
    //         var upgradesData = new CharacterUpgradesData(stats.Count);
    //         
    //         foreach (var stat in stats)
    //         {
    //             upgradesData.UpgradeDatas.Add(new UpgradeData(stat.ID, stat.Level));
    //         }
    //
    //         return upgradesData;
    //     }
    //
    //     protected override void SetUpData(CharacterUpgradesData data, CharacterStatCollection statCollection)
    //     {
    //         if(data.UpgradeDatas.Count == 0) return;
    //
    //         var stats = statCollection.GetStats();
    //         
    //         for (var index = 0; index < stats.Count; index++)
    //         {
    //             if(data.UpgradeDatas.Count < index)
    //                 return;
    //             
    //             statCollection.ApplyByLevel(data.UpgradeDatas[index].Id, data.UpgradeDatas[index].Level);
    //         }
    //     }
    // }
}