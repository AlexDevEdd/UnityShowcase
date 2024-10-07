using Atomic.Elements;
using Atomic.Entities;
using Cysharp.Threading.Tasks;
using GameCycle;
using GamePlay;
using JetBrains.Annotations;
using Zenject;

namespace UI
{
    [UsedImplicitly]
    public sealed class WeaponPanelPresenter : IInitializable, IGameFinish
    {
        private const string ID_POSTFIX = "_01_Horizontal";
        
        private readonly IEntity _character;
        private readonly IWeaponPanelView _weaponPanelView;
        private readonly IWeaponIconProvider _weaponIconProvider;
        private IReactiveVariable<IEntity> _currentWeapon;
        
        private EventAction _fireAction;
        private IEntity _lastWeapon;
        
        public WeaponPanelPresenter(IEntity character, IWeaponIconProvider weaponIconProvider, 
            IWeaponPanelView weaponPanelView)
        {
            _character = character;
            _weaponIconProvider = weaponIconProvider;
            _weaponPanelView = weaponPanelView;
        }

        void IInitializable.Initialize()
        {
            _currentWeapon = _character.GetCurrentWeapon();
            _currentWeapon.Subscribe(OnWeaponChanged);
            _lastWeapon = _currentWeapon.Value;
           
            _fireAction = _character.GetFireAction();
            _fireAction.Subscribe(OnFireEvent);
        }
        
        private void OnFireEvent()
        {
            var currentAmmo = _lastWeapon.GetCurrentAmmo();
            if(currentAmmo.Value == 0) return;
            
            _weaponPanelView.SetCurrentAmount(currentAmmo.ToString());
        }

        private void OnWeaponChanged(IEntity weapon)
        {
            RedrawPanel(weapon).Forget();
        }

        private async UniTaskVoid RedrawPanel(IEntity weapon)
        {
            Unsubscribe();
            _lastWeapon = weapon;
            Subscribe(weapon);

            string iconId = $"{weapon.GetWeaponType().ToString()}{ID_POSTFIX}";
            var icon = await _weaponIconProvider.GetIcon(iconId);
            _weaponPanelView.SetIcon(icon);
            
            _weaponPanelView.SetCapacity(weapon.GetTotalAmmo().Value.ToString());
            _weaponPanelView.SetCurrentAmount(weapon.GetCurrentAmmo().Value.ToString());
        }

        private void OnTotalAmmoChanged(int totalAmmo)
        {
            _weaponPanelView.SetCapacity(totalAmmo.ToString());
        }

        private void OnCurrentAmmoChanged(int currentAmmo)
        {
            _weaponPanelView.SetCurrentAmount(currentAmmo.ToString());
        }

        private void Subscribe(IEntity weapon)
        {
            var currentAmmo = weapon.GetCurrentAmmo();
            var totalAmmo = weapon.GetTotalAmmo();
            currentAmmo.Subscribe(OnCurrentAmmoChanged);
            totalAmmo.Subscribe(OnTotalAmmoChanged);
        }
        
        private void Unsubscribe()
        {
            var currentAmmo = _lastWeapon?.GetCurrentAmmo();
            var totalAmmo = _lastWeapon?.GetTotalAmmo();
            currentAmmo?.Unsubscribe(OnCurrentAmmoChanged);
            totalAmmo?.Unsubscribe(OnTotalAmmoChanged);
        }

        public void OnFinish()
        {
            Unsubscribe();
            _currentWeapon.Unsubscribe(OnWeaponChanged);
        }
    }
}