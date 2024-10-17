using UnityEngine;

namespace MobileJoystick
{
    [RequireComponent(typeof(RectTransform))]
    [DisallowMultipleComponent]
    public class FloatingJoystick : MonoBehaviour
    {
        [HideInInspector]
        public RectTransform RectTransform;
        public RectTransform Knob;
    
        [SerializeField]
        public Vector2 JoystickSize = new Vector2(300, 300);

        private void Awake()
        {
            RectTransform = GetComponent<RectTransform>();
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}