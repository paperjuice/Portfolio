using UnityEngine;
using System.Collections;

public class move_panel : MonoBehaviour {

    [SerializeField]
    private float x;

    [SerializeField]
    private GameObject panel;

    

    void OnMouseDown()
    {
            panel.transform.position += new Vector3(x, 0f, 0f);
    }
}
