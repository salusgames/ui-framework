using UnityEngine;

namespace SalusGames.UIFramework.Effects
{
    [RequireComponent(typeof(CanvasGroup))]
    public class FadeCanvasGroup : MonoBehaviour
    {
        private CanvasGroup _canvasGroup;
        [SerializeField] private float desiredAlpha;

        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        private void Update()
        {
            _canvasGroup.alpha = Mathf.MoveTowards(_canvasGroup.alpha, desiredAlpha, 0.5f * Time.deltaTime);
        }

        public void SetDesiredAlpha(float value)
        {
            desiredAlpha = value;
        }
    }
}