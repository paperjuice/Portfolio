using UnityEngine;
using System.Collections;

public class insAttack : MonoBehaviour {

    public GameObject projectile;
    public float cd;


    IEnumerator Start()
    { 
        while(true)
        {
            Instantiate(projectile, transform.position, transform.rotation);

            yield return new WaitForSeconds(cd);

        }

    }
    
}
