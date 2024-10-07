using UnityEngine;

namespace UI
{
    public sealed class HotBarSlotPresenter
    {
        private readonly IHotBarSlotView _hotBarSlotView;
        private readonly int _slotNumber;
        private readonly Sprite _icon;

        public HotBarSlotPresenter(Sprite icon, int slotNumber, IHotBarSlotView hotBarSlotView)
        {
            _hotBarSlotView = hotBarSlotView;
            _icon = icon;
            _slotNumber = slotNumber;
            _hotBarSlotView.SetSlotNumber(_slotNumber.ToString());
        }

        public void SetSlotNumber()
        {
            _hotBarSlotView.SetSlotNumber(_slotNumber.ToString());
        }

        public void SetIcon()
        {
            _hotBarSlotView.SetIcon(_icon);
        }
        
        public void Select()
        {
            _hotBarSlotView.Select();
        }

        public void Deselect()
        {
            _hotBarSlotView.Deselect();
        }
    }
}