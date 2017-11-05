using GameCore.Levels;

namespace Interactables
{
    internal class Exit : Interactable
    {
        override protected void Interact()
        {
            Level.NextLevel();
        }
    }
}
