using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Utils;

namespace GamePlay
{
    [CreateAssetMenu(fileName = "IconAssetReferences", menuName = "AssetReferences/IconAssetReferences")]
    public class IconAssetReferences : ScriptableObject, IWeaponIconAssetReference
    {
        
        [SerializeField]
        private SerializableDictionary<string, AssetReference> _weaponIcons;
        
        public AssetReference GetWeaponIconReference(string key)
        {
            if (_weaponIcons.TryGetValue(key, out var reference))
                return reference;
        
            throw new ArgumentException($"Doesn't exist KEY of {key}");
        }
    }
}