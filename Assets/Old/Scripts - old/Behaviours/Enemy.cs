using UnityEngine;
/*
public class Enemy : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] int damage;
    [SerializeField] int block;
    [SerializeField] int xp;

    void OnMouseDown()
    {
        TakeDamage(GameManager.Hero[Hero.HeroParamsName.attack]);
    }

    private void TakeDamage(int takenDamage)
    {
        int suffered = takenDamage - block;
        if (suffered > 0)
        {
            if (health > suffered)
            {
                health -= suffered;
                GameManager.Hero.TakeDamage(damage);
            }
            else
            {
                GameManager.Hero.XP += xp;
                Destroy(gameObject);
            }
        }
    }
}
*/