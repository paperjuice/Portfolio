using UnityEngine;
using System.Collections;

public class shipSupport_Movement : MonoBehaviour {

    private RaycastHit rayhit;
    private float dist = 1000f;
    private int mask;

    void Awake()
    {
        mask = LayerMask.GetMask("floor");
    }

    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        
        if(Physics.Raycast(camRay, out rayhit, dist, mask))
        {
            Vector3 asd = rayhit.point - transform.position;
            asd.z = 0f;

            transform.rotation = Quaternion.LookRotation(asd);
        }
    }
}
