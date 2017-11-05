using UnityEngine;
using UnityEngine.UI;

namespace GameCore
{
    internal class Output : Singleton<Output>
    {
        [SerializeField] private Text healthCaption;
        [SerializeField] private Text damageCaption;
        [SerializeField] private Text defenceCaption;
        [SerializeField] private Text scoreCaption;
        
        internal void UpdateHealthCaption(int value)
        {
            healthCaption.text = value.ToString();
        }

        internal void UpdateDamageCaption(int value)
        {
            damageCaption.text = value.ToString();
        }

        internal void UpdateDefenceCaption(int value)
        {
            defenceCaption.text = value.ToString();
        }

        internal void UpdateScoreCaption(int value)
        {
            scoreCaption.text = value.ToString();
        }
    }
}
