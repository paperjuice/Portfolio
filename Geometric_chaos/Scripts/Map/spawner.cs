using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {




    public GameObject enemy;
    public int numberOfenemies;
    public float timeToWait;   //time to wait until wave spawnes


    IEnumerator Start()
    {
        while (numberOfenemies > 0)
        {
            yield return new WaitForSeconds(timeToWait);

            Instantiate(enemy, transform.position, transform.rotation);

            numberOfenemies--;
        }
    }
}
