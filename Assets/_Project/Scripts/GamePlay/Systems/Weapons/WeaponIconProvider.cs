using AssetManagement;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;

namespace GamePlay
{
    [UsedImplicitly]
    public sealed class WeaponIconProvider : IWeaponIconProvider
    {
        private readonly IAssetProvider _assetProvider;
        private readonly IWeaponIconAssetReference _iconAssetReference;
        
        public WeaponIconProvider(IAssetProvider assetProvider, IWeaponIconAssetReference iconAssetReference)
        {
            _assetProvider = assetProvider;
            _iconAssetReference = iconAssetReference;
        }

        public async UniTask<Sprite> GetIcon(string type)
        {
            var reference = _iconAssetReference.GetWeaponIconReference(type);
            return await _assetProvider.LoadAsync<Sprite>(reference);
        }
    }
}