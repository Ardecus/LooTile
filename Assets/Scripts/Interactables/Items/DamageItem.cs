namespace Interactables
{
    internal class DamageItem : Item
    {
        override protected void Interact()
        {
            Hero.CurrentHero.Damage += value;
            Destroy(gameObject);
        }
    }
}