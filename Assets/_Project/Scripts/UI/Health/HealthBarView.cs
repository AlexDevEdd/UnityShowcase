using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public sealed class HealthBarView : MonoBehaviour
    {
        [SerializeField]
        private Image _fillImage;
        
        [SerializeField] 
        private TMP_Text _healthText;

        [SerializeField]
        private float _fillDuration = 0.5f;
        
        [SerializeField] private Ease _ease;

        private Tween _fillTween;
        public void SetHealth(string amount)
        {
            _healthText.text = amount;
        }
        
        public void UpdateProgress(float amount)
        {
            _fillTween?.Kill();
            _fillTween = _fillImage.DOFillAmount(amount, _fillDuration).SetEase(_ease);
        }
    }
}