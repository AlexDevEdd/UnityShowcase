using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace App
{
    public sealed class LoadingWindow : MonoBehaviour
    {
        private const float FADE_END_VALUE = 0f;
        private const float FILL_START_VALUE = 0f;
        
        [SerializeField] private CanvasGroup _canvasGroup;
        [SerializeField] private TMP_Text _progressTitle;
        [SerializeField] private TMP_Text _progressText;
        [SerializeField] private Image _fillImage;
        [Space]
        [SerializeField] private float _fadeDuration = 0.5f;
        
        
        private Tween _fillAmountTween;
        
        public void Show()
        {
            ResetProgress();
            _canvasGroup.alpha = 1;
            gameObject.SetActive(true);
        }

        public void SetTitle(string text)
        {
            _progressTitle.text = text;
        }

        public void StartProgress(float fillAmount, float duration)
        {
            _fillAmountTween?.Kill();
            ResetProgress();

            _fillAmountTween = _fillImage
                .DOFillAmount(fillAmount, duration)
                .SetEase(Ease.Linear);
            
            _fillAmountTween.OnUpdate(FillAmountCallback);
        }

        public void Hide()
        {
            _fillAmountTween?.Kill();
            _canvasGroup.DOFade(FADE_END_VALUE, _fadeDuration)
                .OnComplete(() =>
                {
                    gameObject.SetActive(false);
                    _fillImage.fillAmount = FILL_START_VALUE;
                });
        }

        private void FillAmountCallback()
        {
            var progress = _fillAmountTween.ElapsedPercentage();
            _progressText.text = $"{progress * 100:0.}%";
        }

        private void ResetProgress()
        {
            _fillImage.fillAmount = FILL_START_VALUE;
            _progressText.text = $"{ _fillImage.fillAmount * 100:0.}%";
        }
    }
}