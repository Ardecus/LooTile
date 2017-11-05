using UnityEngine;

namespace Tiles
{
    internal class Foreground : MonoBehaviour
    {
        private static readonly Color unavaliableColor = new Color(0.5f, 0.5f, 0.5f);
        private static readonly Color   avaliableColor = new Color(1f, 1f, 1f);

        // Set in Inspector
        #pragma warning disable 0649
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private Tile tile;
        #pragma warning restore 0649

        private void OnMouseDown()
        {
            tile.Opened = true;
        }

        internal void SetAvaliable(bool active)
        {
            spriteRenderer.color = active ? avaliableColor : unavaliableColor;
        }

        internal void SetOpen(bool open)
        {
            gameObject.SetActive(!open);
        }
    }
}
