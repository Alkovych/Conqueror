using UnityEngine;
using UnityEngine.UI;

class MonsterBarHelper : MonoBehaviour
{
    public Text monsterHpText = null;
    public Text monsterEnergyText = null;

    public int monsterHp;
    public int monsterMaxHp = 100;
    public int monsterEnergy;
    public int monsterGold = 0;

    public Slider monsterHP = null;
    public Slider monsterEnergySlider = null;


    void Update()
    {
        monsterHP.maxValue = monsterMaxHp;
        monsterHP.value = monsterHp;
        monsterHpText.text = monsterHp.ToString();
        monsterEnergySlider.maxValue = 100;
        monsterEnergySlider.value = monsterEnergy;
        monsterEnergyText.text = monsterEnergy.ToString();
    }


    void Start()
    {
    }
}

