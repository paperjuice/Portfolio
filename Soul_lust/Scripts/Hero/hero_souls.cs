using UnityEngine;
using System.Collections;

public class hero_souls : MonoBehaviour {

    private GameObject[] souls;
    private GameObject controller;
    private GameObject player;

    public float soul_potency;


    void Awake()
    {
        controller = GameObject.FindGameObjectWithTag("controller");
        player = GameObject.FindGameObjectWithTag("Player");
    }


    IEnumerator Start()
    {
        while (true)
        {
            souls = GameObject.FindGameObjectsWithTag("soul");

            yield return new WaitForSeconds(0.1f);

            //Debug.Log(soul.Length);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        foreach (GameObject soul in souls)
        {
            if (col.gameObject == soul)
            {
                
                soul.GetComponent<BoxCollider>().enabled = false;
                player.GetComponent<hero_behaviour>().hp += soul_potency;
                if (controller != null)
                {
                    controller.GetComponent<controller>().current_progress++;
                }
                Destroy(soul.gameObject);
            }
        }
    }
}
