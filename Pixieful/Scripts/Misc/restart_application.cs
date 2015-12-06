using UnityEngine;
using System.Collections;

public class restart_application : MonoBehaviour {


    public string level_name;

    void OnMouseDown()
    {
        Application.LoadLevel(level_name);
        print("asdasdad");
    }
}
