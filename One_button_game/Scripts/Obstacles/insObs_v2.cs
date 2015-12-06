using UnityEngine;
using System.Collections;

public class insObs_v2 : MonoBehaviour {

    private float r;

    public GameObject black_obs;
    public GameObject white_obs;
    public float timeBetweenObs;
   


    IEnumerator Start()
    {
        while (true)
        {
            r = Random.Range(0.1f, -11.0f);


           // timeBetweenObs = Random.Range(2f, 5f);


            if (r >= -4.0f)
            {
                Instantiate(white_obs, transform.position = new Vector2(transform.position.x, r), transform.rotation);
            }
            else if (r <= -7.5f)
            {
                Instantiate(black_obs, transform.position = new Vector2(transform.position.x, r), transform.rotation);
            }


            yield return new WaitForSeconds(timeBetweenObs);

            if (timeBetweenObs >= 1.0f)
            {
                timeBetweenObs -= 0.03f;
            }

        }
    }
}
