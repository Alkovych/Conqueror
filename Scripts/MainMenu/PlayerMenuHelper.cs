using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMenuHelper : MonoBehaviour
{

    public Image[] menuImages;
    public Image playerImage;

    public Sprite[] menuSprite;
    public Sprite[] playerSprite;

    [HideInInspector]
    public int playerIndex;


    [HideInInspector]
    public int imageIndex1;

    [HideInInspector]
    public int imageIndex2;

    [HideInInspector]
    public int imageIndex3;


    void Start()
    {

        playerIndex = PlayerPrefs.GetInt("playerIndex");
        imageIndex1 = PlayerPrefs.GetInt("playerSkill1");
        imageIndex2 = PlayerPrefs.GetInt("playerSkill2");
        imageIndex3 = PlayerPrefs.GetInt("playerSkill3");

        menuImages[0].sprite = menuSprite[imageIndex1];
        menuImages[1].sprite = menuSprite[imageIndex2];
        menuImages[2].sprite = menuSprite[imageIndex3];
        menuImages[3].sprite = menuSprite[5];
        menuImages[4].sprite = menuSprite[6];
        playerImage.sprite = playerSprite[playerIndex];
    }
}
