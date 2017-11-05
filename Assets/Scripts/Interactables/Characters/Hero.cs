using UnityEngine;

using GameCore;

namespace Interactables
{
    internal class Hero : Character
    {
        internal static Hero CurrentHero { get; private set; }
        
        [SerializeField] private int health;
        internal override int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value <= 0)
                {
                    // Gameover
                }
                health = value;
                Output.Instance.UpdateHealthCaption(value);
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
                Output.Instance.UpdateDamageCaption(value);
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
                Output.Instance.UpdateDefenceCaption(value);
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
                int cap = 5 * (int)Mathf.Pow(2, level - 1);
                while (experience > cap)
                {
                    ++level;
                    experience -= cap;
                    cap = 5 * (int)Mathf.Pow(2, level - 1);
                    // Show lvlup menu
                    Panels.Instance.LevelupPanel.SetActive(true);
                }
            }
        }

        private int level = 1;

        protected override void Interact()
        {
            SetHeroAsCurrent();
            // And prbbly sthg else
        }

        internal void SetHeroAsCurrent()
        {
            CurrentHero = (Hero)MemberwiseClone();
            //if (CurrentHero == null)
            //{
            //    CurrentHero = new Hero();
            //}
            //CurrentHero.Health = Health;
            //CurrentHero.Damage = Damage;
            //CurrentHero.Defence = Defence;
            Output.Instance.UpdateHealthCaption(CurrentHero.Health);
            Output.Instance.UpdateDamageCaption(CurrentHero.Damage);
            Output.Instance.UpdateDefenceCaption(CurrentHero.Defence);
        }
    }
}
