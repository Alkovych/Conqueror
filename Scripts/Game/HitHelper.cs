using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitHelper : MonoBehaviour {

    PlayerHelper playerHelper;

    void Start () {
        playerHelper = GameObject.FindObjectOfType<PlayerHelper>();
    }

    public void Atack()
    {
        GetComponent<Animator>().SetTrigger(playerHelper.atack);
    }

    public void GetHitPlayer()
    {
        GetComponent<Animator>().SetTrigger(playerHelper.getHit);
    }

    public void PlayerDeth()
    {
        GetComponent<Animator>().SetTrigger(playerHelper.deth);
    }
}
