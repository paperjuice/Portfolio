using UnityEngine;
using System.Collections;

public class restart_application_v2 : MonoBehaviour {

    public string level_name;
    public GameObject sound;

    void OnMouseDown()
    {
        Instantiate(sound, transform.position, Quaternion.identity);

        Application.LoadLevel(level_name);
    }
}
