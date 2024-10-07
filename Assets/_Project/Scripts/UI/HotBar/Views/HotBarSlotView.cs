using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public sealed class HotBarSlotView : MonoBehaviour, IHotBarSlotView
    {
        [SerializeField]
        private Image _iconImage;
        
        [SerializeField]
        private Image _selectImage;

        [SerializeField] 
        private TMP_Text _slotNumber;

        public void SetSlotNumber(string slotNumber)
        {
            _slotNumber.text = slotNumber;
        }
        
        public void SetIcon(Sprite icon)
        {
            _iconImage.sprite = icon;
        }
        
        public void Select()
        {
            _selectImage.enabled = true;
        }
        
        public void Deselect()
        {
            _selectImage.enabled = false;
        }
    }
}