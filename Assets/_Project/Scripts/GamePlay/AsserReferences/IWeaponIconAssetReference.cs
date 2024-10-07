using UnityEngine.AddressableAssets;

namespace GamePlay
{
    public interface IWeaponIconAssetReference
    {
        public AssetReference GetWeaponIconReference(string key);
    }
}