using UnityEngine;
using System.Collections;

public class start_game : MonoBehaviour {

    [SerializeField]
    private string level_name;

    void OnMouseDown()
    {
        Application.LoadLevel(level_name);
    }
}
