namespace Interactables
{
    internal class HealthItem : Item
    {
        override protected void Interact()
        {
            Hero.CurrentHero.Health += value;
            Destroy(gameObject);
        }
    }
}
