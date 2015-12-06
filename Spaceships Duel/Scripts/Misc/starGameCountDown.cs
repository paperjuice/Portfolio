using UnityEngine;
using System.Collections;

public class starGameCountDown : MonoBehaviour {

    private GameObject player_1;
    private GameObject player_2;
    private GameObject[] aas;           //autoattacks
    private bool unlockPowers;

    public GameObject _1;
    public GameObject _2;
    public GameObject _3;
    public GameObject duel;


    void Awake()
    {
        player_1 = GameObject.FindGameObjectWithTag("Player_1");
        player_2 = GameObject.FindGameObjectWithTag("Player_2");
        aas = GameObject.FindGameObjectsWithTag("aa");
    }


    IEnumerator Start()
    {
        Instantiate(_1, transform.position, transform.rotation);

        yield return new WaitForSeconds(1f);

        Instantiate(_2, transform.position, transform.rotation);

        yield return new WaitForSeconds(1f);

        Instantiate(_3, transform.position, transform.rotation);

        yield return new WaitForSeconds(1f);

        Instantiate(duel, transform.position, transform.rotation);

        yield return new WaitForSeconds(1.5f);

        player_1.GetComponent<playerBehaviour>().enabled = true;
        player_2.GetComponent<playerBehaviour>().enabled = true;

        player_1.GetComponent<playerSts>().enabled = true;
        player_2.GetComponent<playerSts>().enabled = true;

        //unlockPowers = true;


        foreach (GameObject aa in aas)
            {
                if (aa.GetComponent<insAA>()!=null)
                aa.GetComponent<insAA>().enabled = true;

                if (aa.GetComponent<insPower>() != null)
                aa.GetComponent<insPower>().enabled = true;
            }
    }

    
}
