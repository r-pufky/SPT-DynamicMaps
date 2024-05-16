using UnityEngine;

namespace InGameMap.UI.Controls
{
    public class CursorPositionText : TextControl
    {
        private RectTransform _mapViewTransform;

        public static CursorPositionText Create(GameObject parent, RectTransform mapViewTransform, float fontSize)
        {
            var text = Create<CursorPositionText>(parent, "CursorPositionText", fontSize);
            text._mapViewTransform = mapViewTransform;

            return text;
        }

        private void Update()
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                _mapViewTransform, Input.mousePosition, null, out Vector2 mouseRelative);
            Text.text = $"Cursor: {mouseRelative.x:F} {mouseRelative.y:F}";
        }
    }
}
