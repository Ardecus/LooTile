using GameCore;

namespace Interactables
{
    internal class ScoreItem : Item
    {
        override protected void Interact()
        {
            GameManager.Score += value;
            Destroy(gameObject);
        }
    }
}