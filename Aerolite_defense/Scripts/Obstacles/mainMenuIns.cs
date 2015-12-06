using UnityEngine;
using System.Collections;

public class mainMenuIns : MonoBehaviour {

    public GameObject obj;
    public float seconds;


    //custom while loop with a set time o "random seconds" in between every call
    IEnumerator Start()
    {
        while (true)
        {
            seconds = Random.Range(2f, 6f);
            
            Instantiate(obj, transform.position, transform.rotation);

            yield return new WaitForSeconds(seconds);
        }
    }
}
