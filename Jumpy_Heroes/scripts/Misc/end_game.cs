using UnityEngine;
using System.Collections;

public class end_game : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
