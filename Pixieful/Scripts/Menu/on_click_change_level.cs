using UnityEngine;
using System.Collections;

public class on_click_change_level : MonoBehaviour {

    public string level_name;
    
    void OnMouseDown()
    {
        Application.LoadLevel(level_name);
    }
}
