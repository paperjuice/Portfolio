using UnityEngine;
using System.Collections;

public class tutorial_scene_1 : MonoBehaviour {

	
    void Start()
    {
        if(player_behaviour.high_score != 0f)
        {
            enabled = false;
        }
    }


    void OnMouseDown()
    {
        if (player_behaviour.high_score != 0f)
        {
            Application.LoadLevel("Scene_1");
        }
        else
        {
            Application.LoadLevel("Tutorial");
        }
    }
}
