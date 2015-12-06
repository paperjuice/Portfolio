using UnityEngine;
using System.Collections;

public class generalEnemyStats : MonoBehaviour {

    public GameObject zombieParts;
    public float hp;



    void Update()
    {
        HealthZero();

    }

    void HealthZero()
    {
        if (hp <= 0)
        {
            Instantiate(zombieParts, transform.position, transform.rotation);
            Instantiate(zombieParts, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
