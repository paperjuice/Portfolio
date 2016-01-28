using UnityEngine;
using System.Collections;

public class hero_souls : MonoBehaviour {

    private GameObject[] souls;
    private GameObject[] souls_currency;
    private GameObject controller;
    private GameObject player;

    public float soul_potency;
    public float soul_currency_potency;


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
            souls_currency = GameObject.FindGameObjectsWithTag("soul_currency");

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

        foreach (GameObject soul_currency in souls_currency)
        {
            if (col.gameObject == soul_currency)
            {
                soul_currency.GetComponent<BoxCollider>().enabled = false;
                hero_behaviour.currency += soul_currency_potency;

                Destroy(soul_currency.gameObject);
            }
        }
    }
}
