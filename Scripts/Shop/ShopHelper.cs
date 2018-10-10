using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopHelper : MonoBehaviour
{
    public Sprite[] attackSprite;
    public Sprite[] defenceSprite;

    public GameObject confirmationMenu;
    public Button yes;
    public Button no;
    public Image confirmationMenuImage;

    public Sprite[] heroImage;
    public Image heroImagePlayer;

    public Text playerGoldText = null;
    public Text notEnougthMoneyText = null;

    [HideInInspector]
    public int playerGoldShop = 0;

    [HideInInspector]
    public int spriteAttackToSaveOptions;

    [HideInInspector]
    public int spriteDefencekToSaveOptions;

    [HideInInspector]
    public int atackImage = 0;
    [HideInInspector]
    public int defenceImage = 0;

    [HideInInspector]
    public int playerDamageShop;
    [HideInInspector]
    public int playerDefenceShop;
    [HideInInspector]
    public int playerHPShop = 0;
    [HideInInspector]
    public int playerEnergyShop = 0;

    [HideInInspector]
    public int indexPlayer;

    [HideInInspector]
    public int checkButton;

    [HideInInspector]
    int price = 0;

    void Start()
    {
        playerGoldShop = PlayerPrefs.GetInt("playerGold");
        indexPlayer = PlayerPrefs.GetInt("playerIndex");
        heroImagePlayer.sprite = heroImage[indexPlayer];
    }

    void Update()
    {
        playerGoldText.text = playerGoldShop.ToString();
    }

    public void YesButton()
    {
        if (checkButton == 0)
        {
            playerGoldShop -= price;
            PlayerPrefs.SetInt("playerGold", playerGoldShop);
            PlayerPrefs.SetInt("atackImage", atackImage);
            PlayerPrefs.SetInt("playerDamage", playerDamageShop);

            confirmationMenu.SetActive(false);
        }

        if (checkButton == 1)
        {
            playerGoldShop -= price;
            PlayerPrefs.SetInt("playerGold", playerGoldShop);
            PlayerPrefs.SetInt("defenceImage", defenceImage);
            PlayerPrefs.SetInt("playerDefence", playerDefenceShop);
            confirmationMenu.SetActive(false);
        }

        if (checkButton == 2)
        {
            playerGoldShop -= price;
            PlayerPrefs.SetInt("hpPotions", playerHPShop);
            PlayerPrefs.SetInt("energyPotions", playerEnergyShop);
            confirmationMenu.SetActive(false);
        }

    }

    public void NoButton()
    {
        confirmationMenu.SetActive(false);
        return;
    }

    public void UpgradeAttack1()
    {
        price = 50;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);
            confirmationMenuImage.sprite = attackSprite[1];
            atackImage = 1;
            playerDamageShop = 2;
            checkButton = 0;
            playerDamageShop += PlayerPrefs.GetInt("playerDamage");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }

    public void UpgradeAttack2()
    {
        price = 100;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);
            confirmationMenuImage.sprite = attackSprite[2];
            atackImage = 2;
            playerDamageShop = 3;
            checkButton = 0;
            playerDamageShop += PlayerPrefs.GetInt("playerDamage");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }

    public void UpgradeAttack3()
    {
        price = 150;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);
            confirmationMenuImage.sprite = attackSprite[3];
            atackImage = 3;
            playerDamageShop = 5;
            checkButton = 0;
            playerDamageShop += PlayerPrefs.GetInt("playerDamage");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }

    public void UpgradeAttack4()
    {
        price = 200;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);
            confirmationMenuImage.sprite = attackSprite[4];
            atackImage = 4;
            playerDamageShop = 7;
            checkButton = 0;
            playerDamageShop += PlayerPrefs.GetInt("playerDamage");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }

    public void UpgradeAttack5()
    {
        price = 300;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);
            confirmationMenuImage.sprite = attackSprite[5];
            atackImage = 5;
            playerDamageShop = 9;
            checkButton = 0;
            playerDamageShop += PlayerPrefs.GetInt("playerDamage");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }

    public void UpgradeAttack6()
    {
        price = 380;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);
            confirmationMenuImage.sprite = attackSprite[6];
            atackImage = 6;
            playerDamageShop = 15;
            checkButton = 0;
            playerDamageShop += PlayerPrefs.GetInt("playerDamage");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }

    public void UpgradeAttack7()
    {
        price = 450;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);
            confirmationMenuImage.sprite = attackSprite[7];
            atackImage = 7;
            playerDamageShop = 20;
            checkButton = 0;
            playerDamageShop += PlayerPrefs.GetInt("playerDamage");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }

    public void UpgradeAttack8()
    {
        price = 500;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);
            confirmationMenuImage.sprite = attackSprite[8];
            atackImage = 8;

            playerDamageShop = 28;
            checkButton = 0;
            playerDamageShop += PlayerPrefs.GetInt("playerDamage");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }

    public void UpgradeDefence1()
    {
        price = 80;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);
            confirmationMenuImage.sprite = defenceSprite[1];
            defenceImage = 1;

            playerDefenceShop = 4;
            checkButton = 1;
            playerDefenceShop += PlayerPrefs.GetInt("playerDefence");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }

    public void UpgradeDefence2()
    {
        price = 200;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);
            confirmationMenuImage.sprite = defenceSprite[2];
            defenceImage = 2;

            playerDefenceShop = 8;
            checkButton = 1;
            playerDefenceShop += PlayerPrefs.GetInt("playerDefence");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }

    public void UpgradeDefence3()
    {
        price = 350;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);
            confirmationMenuImage.sprite = defenceSprite[3];
            defenceImage = 3;

            playerDefenceShop = 15;
            checkButton = 1;
            playerDefenceShop += PlayerPrefs.GetInt("playerDefence");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }

    public void UpgradeDefence4()
    {
        price = 500;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);
            confirmationMenuImage.sprite = defenceSprite[4];
            defenceImage = 4;

            playerDefenceShop = 20;
            checkButton = 1;
            playerDefenceShop += PlayerPrefs.GetInt("playerDefence");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }

    public void UpgradeHP()
    {
        price = 25;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);

            playerHPShop = 1;
            checkButton = 2;
            playerHPShop += PlayerPrefs.GetInt("hpPotions");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }

    public void UpgradeEnergy()
    {
        price = 15;
        if (playerGoldShop >= price)
        {
            confirmationMenu.SetActive(true);

            playerEnergyShop = 1;
            checkButton = 2;
            playerEnergyShop += PlayerPrefs.GetInt("energyPotions");
        }
        else
        {
            notEnougthMoneyText.IsActive();
        }
    }
}
