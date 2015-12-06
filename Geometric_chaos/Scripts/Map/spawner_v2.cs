using UnityEngine;
using System.Collections;

public class spawner_v2 : MonoBehaviour {

    public GameObject enemy_1;

    public int currentWave;
    public int maxWaves;
    public float timeBetweenWaves;


    IEnumerator Start()
    {
        yield return new WaitForSeconds(5.0f);


        while (currentWave < maxWaves)
        {
            Instantiate(enemy_1, transform.position, transform.rotation);
            currentWave++;

            yield return new WaitForSeconds(timeBetweenWaves);



        }
    }

}
