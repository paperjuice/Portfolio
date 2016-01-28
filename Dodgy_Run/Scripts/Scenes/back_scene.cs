using UnityEngine;
using System.Collections;

public class back_scene : MonoBehaviour {

    public string scene_name;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(scene_name);
        }
    }
}
