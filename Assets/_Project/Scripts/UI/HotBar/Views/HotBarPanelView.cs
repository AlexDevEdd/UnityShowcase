using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public sealed class HotBarPanelView : MonoBehaviour
    {
        [SerializeField]
        private List<HotBarSlotView> _slotViews;
        
        public IReadOnlyList<IHotBarSlotView> SlotViews => _slotViews;
    }
}