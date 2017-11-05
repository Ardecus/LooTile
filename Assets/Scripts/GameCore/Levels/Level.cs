using UnityEngine;

namespace GameCore
{
    namespace Levels
    {
        internal abstract class Level : Singleton<Level>
        {
            internal int CurrentLevel { get; set; }
            
            internal static void NextLevel()
            {
                Instance.CustomNextLevel();
            }

            protected abstract void CustomNextLevel();
        }
    }
}