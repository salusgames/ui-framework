using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SalusGames.UIFramework.Helpers
{
    public static class MouseOverUI
    {
        public static bool MouseIsOver()
        {
            var eventDataCurrentPosition = new PointerEventData(EventSystem.current) {position = Input.mousePosition};
            var results = new List<RaycastResult>();

            EventSystem.current.RaycastAll(eventDataCurrentPosition, results);

            return results.Count > 0;
        }
    }
}