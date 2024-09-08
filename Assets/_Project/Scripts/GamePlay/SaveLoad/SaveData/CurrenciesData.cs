using System;
using System.Collections.Generic;

namespace GamePlay
{
    [Serializable]
    public class CurrenciesData
    {
        public readonly List<CurrencyData> CurrencyDatas;

        public CurrenciesData()
        {
            CurrencyDatas = new List<CurrencyData>();
        }
    }
    
    [Serializable]
    public readonly struct CurrencyData
    {
        public readonly string Type;
        public readonly float Amount;
        
        public CurrencyData(string type, float amount)
        {
            Type = type;
            Amount = amount;
        }
    }
}