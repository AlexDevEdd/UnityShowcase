using UnityEngine;

namespace UI
{
    public interface IHotBarSlotView
    {
        void SetSlotNumber(string slotNumber);
        void SetIcon(Sprite icon);
        void Select();
        void Deselect();
    }
}