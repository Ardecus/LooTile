using System;
using System.Collections.Generic;
using UnityEngine;
/*
[Serializable]

public class Tile : MonoBehaviour
{
    static readonly Color avaliableColor = new Color(0.63f, 0.58f, 0.5f, 1f);    //A19480FF
    static readonly Color unavaliableColor = new Color(0.3f, 0.25f, 0.25f, 1f);   //4B3F3FFF

    [SerializeField] Field field;

    [SerializeField] GameObject Content;
	[SerializeField] GameObject Foreground;
	[SerializeField] SpriteRenderer ForegroundImage;

    public List<Tile> Neighbours;

    private bool revealed;
    //public bool Revealed { get { return revealed; } }

	private bool avaliable;
	public bool Avaliable
	{ 
		get
		{
			return avaliable;
		}
		set
		{
            if (!revealed)
            {
                if (value)
                {
                    ForegroundImage.color = avaliableColor;
                }
                else
                {
                    ForegroundImage.color = unavaliableColor;
                }
            }
            avaliable = value;
		}
	}

	//public bool Revealed { get; set; }

	public void SetContent(GameObject content)
	{
		GameObject newItem = Instantiate(content);

        newItem.transform.SetParent(Content.transform, false);

        //newItem.transform.parent = Content.transform;
		//newItem.transform.localPosition = Vector3.zero;
		//newItem.transform.localScale = Vector3.one;
	}

	public void Reset()
	{
        Foreground.SetActive(true);
        revealed = false;
        Avaliable = false;
		
		for (int ch = Content.transform.childCount; ch > 0; --ch)
		{
			Destroy(Content.transform.GetChild(0).gameObject);
		}
	}

    public void Reveal()
    {
        if (Avaliable)
        {
            revealed = true;
            Foreground.SetActive(false);
            foreach (Tile tile in Neighbours)
            {
                tile.Avaliable = true;
            }
        }
    }
}
*/
