using UnityEngine;

namespace UI
{
    public interface IWeaponPanelView
    {
        void SetCurrentAmount(string currentAmount);
        void SetCapacity(string capacity);
        void SetIcon(Sprite icon);
    }
}