using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {


    public TextMesh text;
    public static float coinsCollected;

    



    


    void Update()
    {
        text.text = "Gems Collected:  \n" + coinsCollected; 
    }
}
