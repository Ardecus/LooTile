namespace Interactables
{
    internal abstract class Character : Interactable
    {
        ///private int health;
        internal abstract int Health     { get; set; }
        internal abstract int Damage     { get; set; }
        internal abstract int Defence    { get; set; }
        internal abstract int Experience { get; set; }

        internal void Attack(Character target)
        {
            target.Health -= Damage;
        }
    }
}
