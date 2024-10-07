using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public sealed class WeaponPanelView : MonoBehaviour, IWeaponPanelView
    {
        [SerializeField]
        private Image _iconImage;
        
        [SerializeField] 
        private TMP_Text _currentAmount;
        
        [SerializeField] 
        private TMP_Text _capacity;

        public void SetCurrentAmount(string currentAmount)
        {
            _currentAmount.text = currentAmount;
        }
        
        public void SetCapacity(string capacity)
        {
            _capacity.text = capacity;
        }
        
        public void SetIcon(Sprite icon)
        {
            _iconImage.sprite = icon;
        }
    }
}