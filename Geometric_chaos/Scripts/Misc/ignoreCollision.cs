using UnityEngine;
using System.Collections;

public class ignoreCollision : MonoBehaviour {

    private GameObject[] ignoredObjs;

    public string whatToIgnore;



    void Awake()
    {
        ignoredObjs = GameObject.FindGameObjectsWithTag(whatToIgnore);
    }

    void Start()
    { 

        foreach(GameObject ignoredObj in ignoredObjs )
        {
            Physics2D.IgnoreCollision(ignoredObj.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
