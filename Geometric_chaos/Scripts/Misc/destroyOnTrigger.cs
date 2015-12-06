using UnityEngine;
using System.Collections;

public class destroyOnTrigger : MonoBehaviour {

    private GameObject[] theObjects;


    public GameObject particle_1;
    public string nameOfTheTag;




    void Awake()
    {
        theObjects = GameObject.FindGameObjectsWithTag(nameOfTheTag);
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        foreach (GameObject theObject in theObjects)
        {
            if (col.gameObject == theObject)
            {
                Destroy(gameObject);

                Instantiate(particle_1, transform.position, transform.rotation *=Quaternion.EulerAngles(70f, 0f,0f));
            }
        }

    }
}
