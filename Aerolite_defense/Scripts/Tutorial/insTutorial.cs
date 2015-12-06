using UnityEngine;
using System.Collections;

public class insTutorial : MonoBehaviour {


    private GameObject[] obs;
    private bool stopIns =false;
    private bool speakAboutLives;

    public GameObject tut_1;
    public GameObject tut_2;
   // public GameObject tut_3;

    public float timeTillIns;
   




    IEnumerator Start()
    {
        yield return new WaitForSeconds(timeTillIns);
        
        Instantiate(tut_1, transform.position, transform.rotation);
    }


    void Update()
    {
        obs = GameObject.FindGameObjectsWithTag("obstacle");


        foreach (GameObject ob in obs)
        {
            if (ob.GetComponent<obsColorRoll>().colorCode == 2 && stopIns == false)
            {
                Instantiate(tut_2, transform.position, transform.rotation);
                stopIns = true;
                speakAboutLives = true;
            }


        }
    }

}
