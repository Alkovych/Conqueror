using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour
{

    public Sprite[] attackSprite;
    public Sprite[] defenceSprite;
    [HideInInspector]
    public int atackImage;
    [HideInInspector]
    public int defenceImage;

    public Image atackScreenImage;
    public Image defenceScreenImage;

    public GameObject[] heroCharacters;
    public GameObject[] monsterCharacters;

    public Sprite[] stackIcons;
    public Sprite[] heroIcons;

    public Text hpBottleText;
    public Text energyBottleText;

    [HideInInspector]
    public int hpBottleCount;
    [HideInInspector]
    public int energyBottleCount;

    public Transform playerInstantiatePosition;
    public Transform monsterInstantiatePosition;

    #region PlayerImage
    public Image playerImage;
    public Image playerAtackImage;

    public Image playerSkill1;
    public Image playerSkill2;
    public Image playerSkill3;

    public Image playerPodSkill1;
    public Image playerPodSkill2;
    public Image playerPodSkill3;
    #endregion

    [HideInInspector]
    public int skill1;
    [HideInInspector]
    public int skill2;
    [HideInInspector]
    public int skill3;


    [HideInInspector]
    public GameObject playerObj;
    [HideInInspector]
    public int indexPlayer;

    [HideInInspector]
    public GameObject monsterObj;

    [HideInInspector]
    public int monsterGold;

    public int indexMonster;

    public GameObject winPanel;
    public GameObject losePanel;

    MonsterBarHelper monsterBarHelper;
    PlayerHelper playerHelper;

    bool isWork = true;

    void Start()
    {
        isWork = true;
        indexPlayer = PlayerPrefs.GetInt("playerIndex");

        skill1 = PlayerPrefs.GetInt("playerSkill1");
        skill2 = PlayerPrefs.GetInt("playerSkill2");
        skill3 = PlayerPrefs.GetInt("playerSkill3");

        atackImage = PlayerPrefs.GetInt("atackImage");
        defenceImage = PlayerPrefs.GetInt("defenceImage");

        atackScreenImage.sprite = attackSprite[atackImage];
        defenceScreenImage.sprite = defenceSprite[defenceImage];

        energyBottleCount = PlayerPrefs.GetInt("energyPotions");
        hpBottleCount = PlayerPrefs.GetInt("hpPotions");

        hpBottleText.text = hpBottleCount.ToString();
        energyBottleText.text = energyBottleCount.ToString();

        ChangeIco();
        PlayerSpawn(indexPlayer);
        MonsterSpawn(indexMonster);

        playerHelper = GameObject.FindObjectOfType<PlayerHelper>();
        monsterBarHelper = GameObject.FindObjectOfType<MonsterBarHelper>();
        Time.timeScale = 1;
    }


    void Update()
    {
        PlayerWinFunction();
        PlayerLoseFunction();
    }


    public void PlayerSpawn(int index)
    {
        playerObj = Instantiate(heroCharacters[index]) as GameObject;
        playerObj.transform.position = playerInstantiatePosition.position;
    }

    public void MonsterSpawn(int index)
    {
        monsterObj = Instantiate(monsterCharacters[index]) as GameObject;
        monsterObj.transform.position = monsterInstantiatePosition.position;
    }

    public void PlayerLoseFunction()
    {
        if (playerHelper.playerHp <=0)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

        public void PlayerWinFunction()
    {
        if (monsterBarHelper.monsterHp <= 0 && isWork == true)
        {
            if (SceneManager.GetActiveScene().buildIndex == LevelManager.countUnlockedLevel)
            {
                LevelManager.countUnlockedLevel++;
            }

            playerHelper.goldPlayer += monsterBarHelper.monsterGold;
            PlayerPrefs.SetInt("playerGold", playerHelper.goldPlayer);
            Destroy(monsterObj);
            Time.timeScale = 0.0f;
            winPanel.SetActive(true);
            isWork = false;
        }
        else
        {
            return;
        }
    }

    public void ChangeIco()
    {
        playerSkill1.sprite = stackIcons[skill1];
        playerSkill2.sprite = stackIcons[skill2];
        playerSkill3.sprite = stackIcons[skill3];
        playerPodSkill1.sprite = stackIcons[skill1];
        playerPodSkill2.sprite = stackIcons[skill2];
        playerPodSkill3.sprite = stackIcons[skill3];
        playerImage.sprite = heroIcons[indexPlayer];
    }
}
