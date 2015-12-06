using UnityEngine;
using System.Collections;

public class sound_on_tap : MonoBehaviour {

    public GameObject sound;

    void OnMouseDown()
    {
        Instantiate(sound, transform.position, transform.rotation);
    }
}
