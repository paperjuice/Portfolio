using UnityEngine;
using System.Collections;

public class tutorial_controller : MonoBehaviour {

    public GameObject tut_1;
    public GameObject tut_2;
    public GameObject tut_3;
    public GameObject tut_4;
    public GameObject tut_5;


    IEnumerator Start()
    {
        Instantiate(tut_1, tut_1.transform.position, transform.rotation);

        yield return new WaitForSeconds(3f);

        Instantiate(tut_2, tut_1.transform.position, transform.rotation);

        yield return new WaitForSeconds(4f);

        tut_3.gameObject.SetActive(true);

        yield return new WaitForSeconds(4f);

        /*
        tut_3.GetComponent<rotate_behaviour>().rs = 20f;

        yield return new WaitForSeconds(20f);

        tut_4.gameObject.SetActive(false);
        tut_5.gameObject.SetActive(true);
         */
    }
}
