using UnityEngine;
using Zenject;

namespace GamePlay
{
    [CreateAssetMenu(fileName = "ScriptableObjectInstaller", menuName = "Installers/ScriptableObjectInstaller")]
    public class ScriptableObjectInstaller : ScriptableObjectInstaller<ScriptableObjectInstaller>
    {
        [SerializeField, Space]
        private IconAssetReferences _iconAssetReferences;
        
        public override void InstallBindings()
        {
            BindIconAssetReferences();
        }
        
        private void BindIconAssetReferences()
        {
            Container.BindInterfacesAndSelfTo<IconAssetReferences>()
                .FromInstance(_iconAssetReferences)
                .AsSingle()
                .NonLazy();
        }
    }
}