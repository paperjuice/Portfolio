using UnityEngine;
using System.Collections;

public class insObstacles : MonoBehaviour {



    public GameObject obj;
    public float time_until_start;
    public float time_between_waves;

    private float r;

   


    IEnumerator Start()
    {
        

        while (true)
        {
            yield return new WaitForSeconds(time_until_start);

            if (obj != null)
            {
               
            //roll a number between -1 and 1(exclusive);
               r= Random.Range(-1f,1f);

                Instantiate(obj, transform.position = new Vector3(r, 6f, 0f) , transform.rotation);

                if (time_between_waves >= 0.8f)
                {
                    time_between_waves -= 0.15f; //time that goes down after each obj
                }
            }

            yield return new WaitForSeconds(time_between_waves);
        }
    }
}
