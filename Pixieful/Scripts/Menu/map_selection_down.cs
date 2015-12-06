using UnityEngine;
using System.Collections;

public class map_selection_down : MonoBehaviour {

    public GameObject camera;
    public float limite;



    void OnMouseDown()
    {
        if (camera.transform.position.y > limite)
        {
            camera.transform.position += new Vector3(0f, -30f, 0f);
        }
    }
}
