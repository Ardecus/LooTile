using UnityEngine;

namespace Interactables
{
    internal abstract class Item : Interactable
    {
        // Set in Inspector
        #pragma warning disable 0649
        [SerializeField] protected int value;
        #pragma warning restore 0649
    }
}
