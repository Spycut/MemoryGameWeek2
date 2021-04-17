using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCard1 : MonoBehaviour
{
    [SerializeField] private GameObject Card_Back;



    public void OnMouseDown()
    {
        if (Card_Back.activeSelf)
        {
            Card_Back.SetActive(false);
        }
    }

    private int _id;
    public int id
    {
        get { return _id; }
    }

    public void ChangeSprite (int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }


}
