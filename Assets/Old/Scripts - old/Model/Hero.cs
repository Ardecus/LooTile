using UnityEngine;
using UnityEngine.UI;
/*
[System.Serializable]
public class Character
{
    public int Health;
    public int Attack;
    public int Block;
}

public class Hero : MonoBehaviour
{
    [SerializeField] GameObject levelupPanel;

    int level = 1;
    public int Level
    {
        get
        {
            return level;
        }
        set
        {
            levelupPanel.SetActive(true); //some kind of showing lvlup-menu here
            level = value;
        }
    }

    int xp = 0;
    public int XP
    {
        get
        {
            return xp;
        }
        set
        {
            if (value > levelupCup)
            {
                XP = value - levelupCup;
                Level++;
            }
            else
            {
                xp = value;
            }
        }
    }

    int levelupCup { get { return level * 10; } }

    public Text[] HeroInfo = new Text[4]; //setting these
    //need some kind of auto-number
    public int[] HeroParams = new int[] { 10, 1, 0, 0 };//hardcoded values will cause troubles after changing hero in menu
    public enum HeroParamsName { health, attack, block, gold};
    
    public int this[HeroParamsName key]
    {
        get
        {
            return HeroParams[(int)key];
        }
        set
        {
            HeroParams[(int)key] = value;
            HeroInfo[(int)key].text = value.ToString();
        }
    }

    public void TakeDamage(int damage)
    {
        int suffered = damage - this[HeroParamsName.block];
        if (suffered > 0)
        {
            if (this[HeroParamsName.health] > suffered)
            {
                this[HeroParamsName.health] -= suffered;
            }
            else
            {
                GameManager.EndGame();
            }
        }
    }
}*/