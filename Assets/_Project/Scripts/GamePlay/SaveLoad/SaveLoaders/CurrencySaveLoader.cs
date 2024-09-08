using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using SaveLoad;
using Zenject;

namespace GamePlay
{
    [UsedImplicitly]
    public sealed class CurrencySaveLoader : SaveLoader<CurrenciesData, CurrencyBank>
    {
        public CurrencySaveLoader(GameDataStorage gameDataStorage, CurrencyBank bank) 
            : base(gameDataStorage, bank) { }
    
        protected override CurrenciesData ConvertToData(CurrencyBank audioSystem)
        {
            var currencies = audioSystem.CurrencyMap;
            var currenciesData = new CurrenciesData();
            
            foreach (var currency in currencies)
            {
                currenciesData.CurrencyDatas.Add(new CurrencyData(currency.Key, currency.Value));
            }
    
            return currenciesData;
        }
    
        protected override void SetUpData(CurrenciesData data, CurrencyBank audioSystem)
        {
            if(data.CurrencyDatas.Count == 0) return;

            var currencies = audioSystem.CurrencyMap.Values.ToList();
    
            for (var index = 0; index < currencies.Count; index++)
            {
                if(data.CurrencyDatas.Count < index)
                    return;
                
                audioSystem.UpdateCurrency(data.CurrencyDatas[index].Type, data.CurrencyDatas[index].Amount);
            }
        }
    }

    public sealed class CurrencyBank : IInitializable
    {
        public Dictionary<string, float> CurrencyMap = new ();
        
        public void Initialize()
        {
            CurrencyMap.Add("coin", 20);
            CurrencyMap.Add("crystal", 10);
            CurrencyMap.Add("wood", 30);
        }

        public void UpdateCurrency(string type, float amount)
        {
            if(CurrencyMap.TryGetValue(type, out var value))
                value = amount;
        }
    }
}