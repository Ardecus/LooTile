using UnityEngine;

namespace GameCore
{
    internal class Panels : Singleton<Panels>
    {
        [SerializeField] internal GameObject LevelupPanel;
        [SerializeField] internal GameObject DialoguePanel;
    }
}