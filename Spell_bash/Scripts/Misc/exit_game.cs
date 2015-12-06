using UnityEngine;
using System.Collections;

public class exit_game : MonoBehaviour {

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (Input.GetKey(KeyCode.Alpha2))
            {
                Application.Quit();
            }
        }
    }
}
