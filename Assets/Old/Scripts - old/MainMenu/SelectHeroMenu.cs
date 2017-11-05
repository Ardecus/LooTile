using UnityEngine;
/*
public class SelectHeroMenu : MonoBehaviour
{
    [SerializeField] Sprite selected, unselected;                           //спрайт для фона выбранного перса и прочих

    SelectHero activeHero;                                                  //выбранный, по сути, ГО героя в меню
    public SelectHero ActiveHero
    {
        get
        {
            return activeHero;
        }
        set
        {
            activeHero.SetCellSprite(unselected);                           //SetCellSprite - переключение фона для нового выбранного
            activeHero = value;
            activeHero.SetCellSprite(selected);
            GameSettings.Character = activeHero.Character;                  //сохранение выбора для игры
        }
    }

    void Start()
    {
        activeHero = GameObject.Find("Red").GetComponent<SelectHero>();     //дефолтный выбор 1 героя (имя может поменяться!)
        activeHero.SetCellSprite(selected);
    }
}
*/