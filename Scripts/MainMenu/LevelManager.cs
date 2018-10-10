using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {


    public static int countUnlockedLevel = 1; // Храниться в игре постоянно пока игра запущенна

    [SerializeField]
    Sprite unLockedIcon;


    [SerializeField]
    Sprite lockedIcon;

    void Start () {

        PlayerPrefs.SetInt("CountUnlockedLevel", countUnlockedLevel);

        for (int i = 0; i < transform.childCount; i++) // вернет количество наших дочерних элементов
        {
            transform.GetChild(i).gameObject.name = (i + 1).ToString();
            transform.GetChild(i).transform.GetChild(0).GetComponent<Text>().text = (i + 1).ToString();

            if (i < countUnlockedLevel)
            {
                transform.GetChild(i).GetComponent<Image>().sprite = unLockedIcon; // Меняем иконку кнопки
                transform.GetChild(i).GetComponent<Button>().interactable = true; // Делаем кнопку активной
            }
            else
            {
                transform.GetChild(i).GetComponent<Image>().sprite = lockedIcon;
                transform.GetChild(i).GetComponentInChildren<Text>().text = " "; // делаем текст пустым.
                transform.GetChild(i).GetComponent<Button>().interactable = false;

            }
        }

	}
}
