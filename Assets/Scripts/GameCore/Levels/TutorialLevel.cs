using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

namespace GameCore
{
    namespace Levels
    {
        internal class TutorialLevel : Level
        {
            private List<string> tutorialMessages;

            // Set in Inspector
            #pragma warning disable 0649
            [SerializeField] private TextAsset tutorialMessagesTextfile;
            [SerializeField] private GameObject tutorialMessagePanel;
            [SerializeField] private Text tutorialMessageText;
            #pragma warning restore 0649

            private void Start()
            {
                LoadTutorialMessages();
                ShowTutorialMessage();
            }

            private void LoadTutorialMessages()
            {
                tutorialMessages = new List<string>();
                foreach (string line in tutorialMessagesTextfile.text.Split('\n'))
                {
                    tutorialMessages.Add(line);
                }
            }

            private void ShowTutorialMessage()
            {
                tutorialMessageText.text = tutorialMessages[CurrentLevel];
                tutorialMessagePanel.SetActive(true);
            }

            override protected void CustomNextLevel()
            {
                CameraMovement.MoveCamera();
                ++CurrentLevel;
                ShowTutorialMessage();
            }
        }
    }
}