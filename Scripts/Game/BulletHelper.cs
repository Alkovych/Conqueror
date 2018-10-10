using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHelper : MonoBehaviour {

    HitHelper hitHelper;

    void Start () {


    }
	
	void Update () {
        if (hitHelper == null)
        {
            hitHelper = GameObject.FindObjectOfType<HitHelper>();
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, hitHelper.transform.position, Time.deltaTime * 100);

            if (Vector2.Distance(transform.position, hitHelper.transform.position) < 0.1f)
            {
                //Popal
                hitHelper.GetHitPlayer();
               
                Destroy(gameObject);
            }
        }
	}
}
