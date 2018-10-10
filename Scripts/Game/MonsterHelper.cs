using System.Collections;
using UnityEngine;
using UnityEngine.UI;

class MonsterHelper : MonoBehaviour
{
    public int damageMonster = 0;
    public GameObject[] bulletPrefab = null;
    public float attackSpeed = 5.0f;

    GameHelper gameHelper;
    PlayerHelper playerHelper;
    MonsterBarHelper monsterBar;

    private void Start()
    {
        gameHelper = GameObject.FindObjectOfType<GameHelper>();
        playerHelper = GameObject.FindObjectOfType<PlayerHelper>();
        monsterBar = GameObject.FindObjectOfType<MonsterBarHelper>();
        StartCoroutine(MonsterAttackPlayer());
    }

    public void MonsterAtack()
    {
        GetComponent<Animator>().SetTrigger("MonsterGetHit");
    }

    public IEnumerator MonsterAttackPlayer()
    {
        yield return new WaitForSeconds(attackSpeed);

        GameObject bullet = Instantiate(bulletPrefab[gameHelper.indexMonster]) as GameObject;
        bullet.transform.position = transform.position;
        if (playerHelper.defencePlayer <= damageMonster)
        {
            playerHelper.playerHp -= (1 + (damageMonster - playerHelper.defencePlayer) * 0.05f);
        }

        if (playerHelper.defencePlayer > damageMonster)
        {
            playerHelper.playerHp -=(1/ (1 + (playerHelper.defencePlayer - damageMonster) * 0.05f));
        }     
        monsterBar.monsterEnergy -= 2;
        StartCoroutine(MonsterAttackPlayer());
    }
}