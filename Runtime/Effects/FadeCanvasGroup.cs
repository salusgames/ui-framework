using UnityEngine;

namespace SalusGames.UIFramework.Effects
{
    [RequireComponent(typeof(CanvasGroup))]
    public class FadeCanvasGroup : MonoBehaviour
    {
        private CanvasGroup _canvasGroup;
        public float DesiredAlpha;

        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        private void Update()
        {
            _canvasGroup.alpha = Mathf.MoveTowards(_canvasGroup.alpha, DesiredAlpha, 0.5f * Time.deltaTime);
        }
    }
}