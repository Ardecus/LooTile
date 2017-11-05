using UnityEngine;

using Interactables;

namespace GameCore
{
    // Development-only requirement, remake it later
    [RequireComponent(typeof(Hero))]
    internal class GameManager : MonoBehaviour
    {
        private static int score = 0;
        internal static int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                Output.Instance.UpdateScoreCaption(value);
            }
        }

        private void Start()
        {
            gameObject.GetComponent<Hero>().SetHeroAsCurrent();
        }
    }
}
