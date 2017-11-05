using System;
using System.Collections.Generic;

using UnityEngine;

using Interactables;

namespace Tiles
{
    [Serializable]
    public class Tile : MonoBehaviour
    {
        [SerializeField] private bool avaliable = false;
        public bool Avaliable
        {
            get
            {
                return avaliable;
            }
            set
            {
                if (avaliable != value)
                {
                    foreground.SetAvaliable(value);
                    avaliable = value;
                }
            }
        }

        [SerializeField] private bool opened = false;
        public bool Opened
        {
            get
            {
                return opened;
            }
            set
            {
                if (!opened && Avaliable && value)
                {
                    foreach (Tile neighbour in neighbours)
                    {
                        neighbour.Avaliable = true;
                    }

                    contentPlaceholder.SetActive(true);
                    foreground.SetOpen(true);
                    opened = value;
                }

                if (opened && !value)
                {
                    contentPlaceholder.SetActive(false);
                    foreground.SetOpen(false);
                    opened = value;
                }
            }
        }

        [Space(10)]

        private Interactable content = null;
        public Interactable Content
        {
            get
            {
                return content;
            }
            set
            {
                if (content != null)
                {
                    DestroyImmediate(content.gameObject);
                }
                content = value;
                if (value != null)
                {
                    content.Tile = this;
                    content.SetPlaceholder(contentPlaceholder.transform);
                }
            }
        }

        // These are set in the Inspector
        #pragma warning disable 0649
        [SerializeField] private List<Tile> neighbours;

        [Space(10)]

        [SerializeField] private GameObject contentPlaceholder;
        [SerializeField] private Foreground foreground;
        //[SerializeField] private PolygonCollider2D collider;
        #pragma warning restore 0649
      
        internal void AddContent(Interactable addedContent)
        {
            content = addedContent;  
            //content.gameObject.SetActive(false);
        }

        public void AddNeighbour(Tile neighbour)
        {
            if (!neighbours.Contains(neighbour))
            {
                neighbours.Add(neighbour);
            }
        }

        public void SetTransparent(bool visible)
        {
            contentPlaceholder.SetActive(Opened ? true : visible);
            foreground.SetOpen(Opened ? true : visible);
        }
    }
}