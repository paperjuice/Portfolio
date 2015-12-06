using UnityEngine;
using System.Collections;

public class spwnBehaviour : MonoBehaviour {


    public GameObject enemy;
    public float cd;

    IEnumerator Start()
    {
        while (true)
        {
            Instantiate(enemy, transform.position, transform.rotation);

            yield return new WaitForSeconds(cd);
        }
    }
}
