using UnityEngine;
using System.Collections;

public class objToFollow : MonoBehaviour {

    private float dist = 1000f;
    private RaycastHit rayhit;
    private int mask;

    void Awake()
    {
        mask = LayerMask.GetMask("floor");
    }

    void Update()
    {
        ObjPosition();
    }

    void ObjPosition()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        transform.position = new Vector3(camRay.origin.x, camRay.origin.y, 0f);

    }
}
