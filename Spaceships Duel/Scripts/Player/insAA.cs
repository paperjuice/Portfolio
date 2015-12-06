using UnityEngine;
using System.Collections;

public class insAA : MonoBehaviour {



    public GameObject aaSoundSfx;
    public GameObject projectile;
    public GameObject particles;
    public float time_between_attack;

    IEnumerator Start()
    {
        while (true)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            Instantiate(particles, transform.position, transform.rotation);
            Instantiate(aaSoundSfx, transform.position, transform.rotation);

            yield return new WaitForSeconds(time_between_attack);
        
        }
    }
}
