using UnityEngine;

using Interactables;

namespace GameCore
{
    internal class Levelup : MonoBehaviour
    {
        private enum UpSkill { Damage, Defence, Health }
        private UpSkill upSkillSelection = UpSkill.Damage;

        private void Awake()
        {
            Panels.Instance.LevelupPanel = gameObject;
        }

        public void ChangeSelection(int upSkill)
        {
            upSkillSelection = (UpSkill)upSkill;
        }

        public void Upgrade()
        {
            switch (upSkillSelection)
            {
                case UpSkill.Damage:
                    Hero.CurrentHero.Damage++;
                    break;

                case UpSkill.Defence:
                    Hero.CurrentHero.Defence++;
                    break;

                case UpSkill.Health:
                    Hero.CurrentHero.Health += 15;
                    break;
            }

            Panels.Instance.LevelupPanel.SetActive(false);
        }
    }
}