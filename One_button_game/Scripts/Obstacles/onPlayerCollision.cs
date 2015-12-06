using UnityEngine;
using System.Collections;

public class onPlayerCollision : MonoBehaviour {

    private GameObject player;
    private GameObject endGameScreen;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        endGameScreen = GameObject.FindGameObjectWithTag("endGame");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            player.SetActive(false);
            endGameScreen.transform.localPosition = new Vector3(0f, -6.7f, 9.2f);
            endGameScreen.GetComponent<restartGame>().enabled = true;
        }
    }
}
