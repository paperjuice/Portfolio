using UnityEngine;
using System.Collections;

public class dont_destory_on_load : MonoBehaviour {


    

    void Start()
    {
        
        DontDestroyOnLoad(gameObject);
    }
}
