using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHelper : MonoBehaviour {

    public Text textDamagePlayer;
    public Text textDefencePlayer;
    public Text textGoldPlayer;

    public int goldPlayer;
    public int atackPlayer;
    public int defencePlayer;

    public Text playerHpText;
    public Text playerEnergyText;

    public float playerHp;
    public int playerEnergy;

    public Slider playerHPSlider;
    public Slider playerEnergySlider;

    [HideInInspector]
    public string atack;
    [HideInInspector]
    public string getHit;
    [HideInInspector]
    public string deth;

    public int playerGold;

    MonsterBarHelper monsterBarHelper;

    void Start () {
        goldPlayer = PlayerPrefs.GetInt("playerGold");
        atackPlayer = PlayerPrefs.GetInt("playerDamage");
        defencePlayer = PlayerPrefs.GetInt("playerDefence");
        atack = PlayerPrefs.GetString("PlayerAtack");
        getHit = PlayerPrefs.GetString("PlayerGetHit");
        deth = PlayerPrefs.GetString("PlayerDeth");
        playerHp = PlayerPrefs.GetInt("playerHP");
        playerEnergy = PlayerPrefs.GetInt("playerEnergy");

        monsterBarHelper = GameObject.FindObjectOfType<MonsterBarHelper>();
    }
	
	void Update () {
        textDamagePlayer.text = atackPlayer.ToString();
        textGoldPlayer.text = goldPlayer.ToString();
        textDefencePlayer.text = defencePlayer.ToString();
        playerHpText.text = playerHp.ToString();
        playerEnergyText.text = playerEnergy.ToString();
        playerEnergySlider.maxValue = 100;
        playerEnergySlider.value = playerEnergy;
        playerHPSlider.maxValue = 100;
        playerHPSlider.value = playerHp;
    }

    public void SuperAtack(int index)
    {
        switch (index)
        {
            case 0: int secondAtackDormidor = 5;
                monsterBarHelper.monsterHp -= secondAtackDormidor;
                playerEnergy -= 5;
                break;
            case 1: int secondAtackKaligan = 6;
                monsterBarHelper.monsterHp -= secondAtackKaligan;
                playerEnergy -= 5;
                break;
            case 2: int secondAtackKaoraks = 8;
                monsterBarHelper.monsterHp -= secondAtackKaoraks;
                playerEnergy -= 5;
                break;

            default:
                break;
        }
    }

    public void SuperSkill(int index)
    {
        switch (index)
        {
            case 0:
                atackPlayer += 2;
                playerEnergy -= 7;
                break;
            case 1:
                playerHp += 10;
                playerEnergy -= 7;
                break;
            case 2:
                defencePlayer += 5;
                playerEnergy -= 7;
                break;

            default:
                break;
        }
    }
}
