using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using GameCore;

internal class Dialogue : Singleton<Dialogue>
{
    // Set in Inspector
    #pragma warning disable 0649
    [SerializeField] private Text dialogueText;
    #pragma warning restore 0649

    private static List<string> dialogueLines = new List<string>();
    private static int currentLine = 0;

    private void UpdateText()
    {
        if (currentLine == dialogueLines.Count)
        {
            gameObject.SetActive(false);
            return;
        }

        dialogueText.text = dialogueLines[currentLine];
        ++currentLine;
    }

    private void OnMouseDown()
    {
        UpdateText();
    }

    internal static void SetDialogueLines(List<string> newLines)
    {
        dialogueLines = newLines;
        currentLine = 0;

        Instance.UpdateText();
        Instance.gameObject.SetActive(true);
    }
}
