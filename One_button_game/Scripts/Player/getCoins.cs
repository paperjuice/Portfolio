using UnityEngine;
using System.Collections;

public class getCoins : MonoBehaviour {

    private GameObject[] coins;


    IEnumerator Start()
    {
        while (true)
        {
            coins = GameObject.FindGameObjectsWithTag("coin");
            yield return new WaitForSeconds(0.1f);
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        foreach (GameObject coin in coins)
        {
            if (col.gameObject == coin)
            {
                Debug.Log("coin got");
                Destroy(coin.gameObject);
                score.coinsCollected++;
            }
        }
    }
}
