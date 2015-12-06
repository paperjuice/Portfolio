using UnityEngine;
using System.Collections;

public class insIntro : MonoBehaviour {

    public GameObject text_1;
    public GameObject text_2;


    IEnumerator Start()
    {
        Instantiate(text_1, transform.position, transform.rotation);

        yield return new WaitForSeconds(2f);

        Instantiate(text_2, transform.position, transform.rotation);

        yield return new WaitForSeconds(2f);

        Application.LoadLevel("MainMenu");
    }
}
