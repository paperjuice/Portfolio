using UnityEngine;
using System.Collections;

public class obs_ins : MonoBehaviour {

    [SerializeField]
    private float time;
    [SerializeField] 
    public float ms = 2f;

    public GameObject obstacle;




    IEnumerator Start()
    {
        while (true)
        {
            transform.position = new Vector2(Random.Range(-2.3f, 2.3f), transform.position.y);
            Instantiate(obstacle, transform.position, transform.rotation);

            yield return new WaitForSeconds(time);

            if (time >= 0.2f)
            {
                time -= 0.01f;
            }

            if (ms <= 10f)
            {
                ms += 0.1f;
            }
        }
    }



}
