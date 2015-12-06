using UnityEngine;
using System.Collections;

public class restartGame : MonoBehaviour {


    public string levelName;



    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Application.LoadLevel(levelName);
            score.coinsCollected = 0f;
        }
    }
}
