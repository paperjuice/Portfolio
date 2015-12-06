using UnityEngine;
using System.Collections;

public class destroyOnCollision : MonoBehaviour {

    private GameObject[] theObjects;


   // public GameObject particle_1;
    public string nameOfTheTag;




    void Awake()
    {
        theObjects = GameObject.FindGameObjectsWithTag(nameOfTheTag);
    }



    void OnCollisionEnter2D(Collision2D col)
    {
        foreach (GameObject theObject in theObjects)
        {
            if (col.gameObject == theObject)
            {
                Destroy(gameObject);

               // Instantiate(particle_1, transform.position, transform.rotation);
                
            }
        }

    }
}
