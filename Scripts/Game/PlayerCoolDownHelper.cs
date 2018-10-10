using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCoolDownHelper : MonoBehaviour
{

    public List<Skill> skills;
    public Text hpButtle;
    public Text energyButtle;

    public int byttlePlayerHp = 1;
    public int byttlePlayerEnergy = 1;

    [HideInInspector]
    public float startCoolDown = 0;

    HitHelper hitHelper;
    MonsterHelper monsterHelper;
    PlayerHelper playerHelper;
    GameHelper gameHelper;
    MonsterBarHelper monsterBarHelper;

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (skills[0].currentCoolDown >= skills[0].coolDown)
            {
                if (playerHelper.playerEnergy > 0)
                {
                    hitHelper.Atack();
                    monsterHelper.MonsterAtack();
                    monsterBarHelper.monsterHp -= playerHelper.atackPlayer;
                    playerHelper.playerEnergy -= 2;
                    skills[0].currentCoolDown = 0;
                }
                else
                {
                    return;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (skills[1].currentCoolDown >= skills[1].coolDown)
            {
                if (playerHelper.playerEnergy > 0)
                {
                    hitHelper.Atack();
                    monsterHelper.MonsterAtack();
                    playerHelper.SuperAtack(gameHelper.indexPlayer);
                    skills[1].currentCoolDown = 0;
                }
                else
                {
                    return;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (skills[2].currentCoolDown >= skills[2].coolDown)
            {
                playerHelper.SuperSkill(gameHelper.indexPlayer);
                skills[2].currentCoolDown = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (skills[3].currentCoolDown >= skills[3].coolDown)
            {
                if (byttlePlayerHp > 0)
                {
                    playerHelper.playerHp += 10;
                    byttlePlayerHp -= 1;
                    skills[3].currentCoolDown = 0;
                }
                else
                {
                    return;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (skills[4].currentCoolDown >= skills[4].coolDown)
            {
                if (byttlePlayerHp > 0)
                {
                    playerHelper.playerEnergy += 15;
                    byttlePlayerEnergy -= 1;
                    skills[4].currentCoolDown = 0;
                }
                else
                {
                    return;
                }

            }
        }
    }

    private void Update()
    {
        foreach (Skill s in skills)
        {

            if (s.currentCoolDown < s.coolDown)
            {
                s.currentCoolDown += Time.deltaTime;
                s.skillIcon.fillAmount = s.currentCoolDown / s.coolDown;
            }
        }

        hpButtle.text = byttlePlayerHp.ToString();
        energyButtle.text = byttlePlayerEnergy.ToString();
    }

    private void Start()
    {
        hitHelper = GameObject.FindObjectOfType<HitHelper>();
        monsterHelper = GameObject.FindObjectOfType<MonsterHelper>();
        playerHelper = GameObject.FindObjectOfType<PlayerHelper>();
        gameHelper = GameObject.FindObjectOfType<GameHelper>();
        monsterBarHelper = GameObject.FindObjectOfType<MonsterBarHelper>();

        foreach (Skill skill in skills)
        {
            skill.currentCoolDown = skill.coolDown;
        }

        PlayerPrefs.SetInt("HPBottle", byttlePlayerHp);
        PlayerPrefs.SetInt("EnergyBottle", byttlePlayerEnergy);

    }
}

[System.Serializable]
public class Skill
{
    public float coolDown;
    public Image skillIcon;
    [HideInInspector]
    public float currentCoolDown;


}
