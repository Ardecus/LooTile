using UnityEngine;

namespace Interactables
{
    internal class Enemy : Character
    {
        [SerializeField] private int health;
        internal override int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
                if (value <= 0)
                {
                    Loot.Drop(tile);
                    Hero.CurrentHero.Experience += Experience;
                    Destroy(gameObject);
                }
            }
        }

        [SerializeField] private int damage;
        internal override int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }

        [SerializeField] private int defence;
        internal override int Defence
        {
            get
            {
                return defence;
            }
            set
            {
                defence = value;
            }
        }

        [SerializeField] private int experience;
        internal override int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }

        protected override void Interact()
        {
            Hero.CurrentHero.Attack(this);
            Attack(Hero.CurrentHero);
        }
    }
}
