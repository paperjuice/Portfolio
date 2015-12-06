using UnityEngine;
using System.Collections;

public class load_level_on_click : MonoBehaviour {

    public string levelName;

    void OnMouseDown()
    {
        Application.LoadLevel(levelName);
    }
}
