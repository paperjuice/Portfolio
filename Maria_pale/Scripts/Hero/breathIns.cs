using UnityEngine;
using System.Collections;

public class breathIns : MonoBehaviour {

    public GameObject breath;
    public float time;


    IEnumerator Start()
    {
        while (true)
        {
            breath.gameObject.SetActive(true);

            yield return new WaitForSeconds(time);

            breath.gameObject.SetActive(false);



        }
    }

}
