using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Domirdor : MonoBehaviour {

    public int playerHP = 100;
    public int playerMaxHP = 100;

    public int hpPotions = 0;
    public int energyPotions = 0;

    public int playerIndex = 0;

    public int playerEnergy = 100;
    public int playerMaxEnergy = 100;

    public int playerDamage = 17;
    public int playerDefence = 10;

    public int playerGold = 0;

    public int atackImage = 0;
    public int defenceImage = 0;

    public string playerAtack = "DormidorAtack";
    public string playerGetHit = "DormidorGetHit";
    public string playerDeth = "DormidorDeth";

    public int skill1 = 0;
    public int skill2 = 1;
    public int skill3 = 2;

    public Domirdor(int playerHP,int playerMaxHP, int playerIndex, int playerEnergy, int playerDamage, int playerDefence, int playerGold, 
        string playerAtack, string playerGetHit, string playerDeth, int playerMaxEnergy, int skill1, int skill2, int skill3,
        int atackImage, int defenceImage , int hpPotions, int energyPotions)
    {
        this.playerHP = playerHP;
        this.playerMaxHP = playerMaxHP;
        this.playerIndex = playerIndex;
        this.playerEnergy = playerEnergy;
        this.playerDamage = playerDamage;
        this.playerDefence = playerDefence;
        this.playerGold = playerGold;
        this.playerAtack = playerAtack;
        this.playerGetHit = playerGetHit;
        this.playerDeth = playerDeth;
        this.playerMaxEnergy = playerMaxEnergy;
        this.skill1 = skill1;
        this.skill2 = skill2;
        this.skill3 = skill3;
        this.atackImage = atackImage;
        this.defenceImage = defenceImage;
        this.hpPotions = hpPotions;
        this.energyPotions = energyPotions;
    }

    public Domirdor()
    { }

    public void DomirdorFunctionSave()
    {
        PlayerPrefs.SetInt("playerHP", playerHP);
        PlayerPrefs.SetInt("playerMaxHP", playerMaxHP);
        PlayerPrefs.SetInt("playerEnergy", playerEnergy);
        PlayerPrefs.SetInt("playerMaxEnergy", playerMaxEnergy);
        PlayerPrefs.SetInt("playerDamage", playerDamage);
        PlayerPrefs.SetInt("playerDefence", playerDefence);
        PlayerPrefs.SetInt("playerGold", playerGold);
        PlayerPrefs.SetInt("playerIndex", playerIndex);
        PlayerPrefs.SetInt("playerSkill1", skill1);
        PlayerPrefs.SetInt("playerSkill2", skill2);
        PlayerPrefs.SetInt("playerSkill3", skill3);

        PlayerPrefs.SetInt("energyPotions", energyPotions);
        PlayerPrefs.SetInt("hpPotions", hpPotions);

        PlayerPrefs.SetInt("atackImage", atackImage);
        PlayerPrefs.SetInt("defenceImage", defenceImage);

        PlayerPrefs.SetString("PlayerAtack", playerAtack);
        PlayerPrefs.SetString("PlayerGetHit", playerGetHit);
        PlayerPrefs.SetString("PlayerDeth", playerDeth);
    }
}
