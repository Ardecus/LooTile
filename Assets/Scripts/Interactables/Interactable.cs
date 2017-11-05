using UnityEngine;

using Tiles;

namespace Interactables
{
    [RequireComponent(typeof(PolygonCollider2D))]
    public abstract class Interactable : MonoBehaviour
    {
        [SerializeField] protected Tile tile;
        internal Tile Tile
        {
            get
            {
                return tile;
            }
            set
            {
                tile = value;
            }
        }

        protected void OnMouseDown()
        {
            if (enabled)
            {
                Interact();

            }
        }

        protected abstract void Interact();
        
        internal void SetPlaceholder(Transform placeholder)
        {
            gameObject.transform.SetParent(placeholder);
            gameObject.transform.localPosition = Vector3.zero;
            gameObject.transform.localRotation = Quaternion.identity;
        }
    }
}
