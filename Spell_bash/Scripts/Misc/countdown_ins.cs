using UnityEngine;
using System.Collections;

public class countdown_ins : MonoBehaviour {

    public GameObject three;
    public GameObject two;
    public GameObject one;
    public GameObject duel;
    public float time;

    IEnumerator Start()
    {
        Instantiate(three, transform.position, transform.rotation);

        yield return new WaitForSeconds(time);

        Instantiate(two, transform.position, transform.rotation);

        yield return new WaitForSeconds(time);

        Instantiate(one, transform.position, transform.rotation);

        yield return new WaitForSeconds(time);

        Instantiate(duel, transform.position, transform.rotation);


    }
}
