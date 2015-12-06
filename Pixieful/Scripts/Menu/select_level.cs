using UnityEngine;
using System.Collections;

public class select_level : MonoBehaviour {

    public bool is_unlocked = false;
    public string level_name;




    void OnMouseDown()
    {
        Application.LoadLevel(level_name);
    }
}
