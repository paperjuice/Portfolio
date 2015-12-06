using UnityEngine;
using System.Collections;

public class change_level_on_back : MonoBehaviour {

    public string level_name;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(level_name);
        }
    }
}
