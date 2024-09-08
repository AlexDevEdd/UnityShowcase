using System;
using UnityEngine;
using Utils;

namespace App
{
    [CreateAssetMenu(fileName = "AppStepConfiguration", menuName = "Configs/AppStepConfiguration")]
    public sealed class AppStepConfiguration : ScriptableObject
    {
        [SerializeField] 
        private SerializableDictionary<int, AppStepConfig> _configs;

        public AppStepConfig GetConfig(int id)
        {
            if(_configs.TryGetValue(id, out var config))
                return config;

            throw new ArgumentException($"Config with type of {id} doesn't exist");
        }
    }
}