using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GamePlay
{
    public interface IWeaponIconProvider
    {
        UniTask<Sprite> GetIcon(string type);
    }
}