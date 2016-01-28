using UnityEngine;
using System.Collections;

public class restart_game : MonoBehaviour {

    public string level_name;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Application.LoadLevel(level_name);
        }
    }

    void OnMouseDown()
    {
        Application.LoadLevel(level_name);
    }
}
