using System.Collections.Generic;

using UnityEngine;

using GameCore;

namespace Interactables
{
    internal class Talkable : Interactable
    {
        private Enemy enemy;

        [SerializeField] private List<string> dialogueLines;

        private void Start()
        {
            enemy = gameObject.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.enabled = false;
            }
        }

        protected override void Interact()
        {
            Dialogue.SetDialogueLines(dialogueLines);
            enemy.enabled = true;
        }
    }
}
