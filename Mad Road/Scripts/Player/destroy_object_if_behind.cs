using UnityEngine;
using System.Collections;

public class destroy_object_if_behind : MonoBehaviour {


    private GameObject[] rocks;
    private GameObject[] ramps;
    private GameObject[] coins;



    IEnumerator Start()
    {
        while (true)
        {
            rocks = GameObject.FindGameObjectsWithTag("rock");
            ramps = GameObject.FindGameObjectsWithTag("ramp");
            coins = GameObject.FindGameObjectsWithTag("coin");
            yield return new WaitForSeconds(0.1f);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        foreach (GameObject rock in rocks)
        {
            if (col.gameObject == rock)
            {
                Destroy(rock.gameObject);
            }
        }

        foreach (GameObject ramp in ramps)
        {
            if (col.gameObject == ramp)
            {
                Destroy(ramp.gameObject);
            }
        }

        foreach (GameObject coin  in coins)
        {
            if (col.gameObject == coin)
            {
                Destroy(coin.gameObject);
            }
        }
    }


}
