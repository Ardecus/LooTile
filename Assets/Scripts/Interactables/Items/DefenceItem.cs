namespace Interactables
{
    internal class DefenceItem : Item
    {
        override protected void Interact()
        {
            Hero.CurrentHero.Defence += value;
            Destroy(gameObject);
        }
    }
}