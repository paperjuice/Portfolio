using UnityEngine;
using System.Collections;

public class goBackOnEsc : MonoBehaviour {


    public string levelName;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(levelName);
        }
    }
}
