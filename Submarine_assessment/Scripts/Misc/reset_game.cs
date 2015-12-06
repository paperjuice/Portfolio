using UnityEngine;
using System.Collections;

public class reset_game : MonoBehaviour {

    //Ionut Vericiu

	//on "x" press we reload the scene and we reset the in-game time
    void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            Application.LoadLevel("Game_1");
            Time.timeScale = 1f;
        }
    }
}
